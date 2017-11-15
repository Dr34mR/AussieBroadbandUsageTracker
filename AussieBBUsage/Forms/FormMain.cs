using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Xml;
using System.Windows.Forms;
using AussieBBUsage.Helpers;
using AussieBBUsage.Properties;

namespace AussieBBUsage.Forms
{
    public partial class FormMain : Form
    {
        private CookieContainer _cookieContainer = new CookieContainer();

        private const string LoginUrl = "https://my.aussiebroadband.com.au/";
        private const string UsageUrl = "https://my.aussiebroadband.com.au/usage.php?&xml=yes";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_cookieContainer.Count != 1) if (!LoginToAussie()) return;

            var xmlRequest = WebRequest.Create(UsageUrl) as HttpWebRequest;
            if (xmlRequest == null) return;

            xmlRequest.CookieContainer = _cookieContainer;

            var xmlResponse = xmlRequest.GetResponse() as HttpWebResponse;
            if (xmlResponse == null) return;

            var xmlDoc = new XmlDocument();
            var xmlStream = xmlResponse.GetResponseStream();
            if (xmlStream == null) return;

            try { xmlDoc.Load(xmlStream); }
            catch
            {
                MessageBox.Show(this, "Unable to retrieve data\nPlease check username / password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _cookieContainer = new CookieContainer();
                Settings.Default.Reset();
                Settings.Default.Save();
                xmlResponse.Dispose();
                xmlStream.Dispose();
                return;
            }

            xmlResponse.Dispose();
            xmlStream.Dispose();

            var usage = new AussieUsage(xmlDoc);
            UpdateUsage(usage);
        }

        private void UpdateUsage(AussieUsage usage)
        {
            txtDown.Text = $@"{usage.Down1:n0}";
            txtUp.Text = $@"{usage.Up1:n0}";
            txtCombined.Text = $@"{usage.Down1 + usage.Up1:n0}";

            txtMonthCap.Text = $@"{usage.AllowanceMb1:n0}";
            txtMonthRemain.Text = $@"{usage.Left1:n0}";

            lblLastUpdated.Text = usage.LastUpdated.ToString("G");

            txtRolloverDay.Text = NumericalHelper.Ordinal(usage.RolloverDayOfMonth);

            var currentDay = DateTime.Now.Day;
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;

            DateTime endDate;
            DateTime startDate;

            if (currentDay < usage.RolloverDayOfMonth)
            {
                endDate = new DateTime(currentYear, currentMonth, usage.RolloverDayOfMonth);
                startDate = endDate.AddMonths(-1);
            }
            else
            {
                startDate = new DateTime(currentYear, currentMonth, usage.RolloverDayOfMonth);
                endDate = startDate.AddMonths(1);
            }

            var remaining = Math.Floor((endDate - DateTime.Now).TotalDays) + 1;
            txtDaysRemain.Text = remaining.ToString(CultureInfo.CurrentCulture);

            var elapsed = Math.Floor((DateTime.Now - startDate).TotalDays) + 1;

            txtAvgMonth.Text = $@"{Math.Floor((usage.Down1 + usage.Up1) / elapsed):n0}";
            txtAvgRemain.Text = $@"{Math.Floor(usage.Left1 / (remaining - 1)):n0}";
        }

        private void GetLoginInfo()
        {
            var loginForm = new FormLogin();
            loginForm.ShowDialog(this);
            if (!loginForm.PressedOk)
            {
                loginForm.Dispose();
                return;
            }

            var userEntropy = new byte[20];
            var passEntropy = new byte[20];

            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(userEntropy);
            rng.GetBytes(passEntropy);
            rng.Dispose();

            Settings.Default.UserEntropy = userEntropy;
            Settings.Default.PassEntropy = passEntropy;
            Settings.Default.UserCipherText = ProtectedData.Protect(loginForm.UserName, userEntropy, DataProtectionScope.CurrentUser);
            Settings.Default.PassCipherText = ProtectedData.Protect(loginForm.UserPass, passEntropy, DataProtectionScope.CurrentUser);
            Settings.Default.Save();

            loginForm.Dispose();
        }

        private bool LoginToAussie()
        {
            if (Settings.Default.UserCipherText == null) GetLoginInfo();
            if (Settings.Default.UserCipherText == null) return false;

            var byteUser = ProtectedData.Unprotect(Settings.Default.UserCipherText, Settings.Default.UserEntropy, DataProtectionScope.CurrentUser);
            var bytePass = ProtectedData.Unprotect(Settings.Default.PassCipherText, Settings.Default.PassEntropy, DataProtectionScope.CurrentUser);

            var loginRequest = (HttpWebRequest) WebRequest.Create(LoginUrl);

            var outgoingQueryString = HttpUtility.ParseQueryString(string.Empty);
            outgoingQueryString.Add("login_username", Encoding.UTF8.GetString(byteUser));
            outgoingQueryString.Add("login_password", Encoding.UTF8.GetString(bytePass));
            outgoingQueryString.Add("submit", "Login");
            var postData = outgoingQueryString.ToString();

            var ascii = new ASCIIEncoding();
            var postBytes = ascii.GetBytes(postData);

            loginRequest.Method = "POST";
            loginRequest.CookieContainer = _cookieContainer;
            loginRequest.ContentType = "application/x-www-form-urlencoded";
            loginRequest.ContentLength = postBytes.Length;
            loginRequest.UserAgent = "";
            loginRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

            using (var stream = loginRequest.GetRequestStream()) { stream.Write(postBytes, 0, postBytes.Length); }
            var response = (HttpWebResponse) loginRequest.GetResponse();

            var returnSuccess = response.StatusCode == HttpStatusCode.OK;

            response.Dispose();
            return returnSuccess;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
