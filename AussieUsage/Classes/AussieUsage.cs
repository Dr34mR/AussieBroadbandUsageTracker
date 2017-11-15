using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AussieUsage.Classes
{
    public class AussieUsage
    {
        public int RolloverDayOfMonth;
        public DateTime LastUpdated;

        public long Down1;
        public long Up1;
        public long AllowanceMb1;
        public long Left1;

        public long Down2;
        public long Up2;
        public long AllowanceMb2;
        public long Left2;

        public AussieUsage(XmlDocument xmlRetrieved)
        {
            if (xmlRetrieved == null) return;

            var tempStr = xmlRetrieved["usage"]["rollover"].FirstChild.InnerText;
            int.TryParse(tempStr, out RolloverDayOfMonth);

            tempStr = xmlRetrieved["usage"]["lastupdated"].FirstChild.InnerText;
            DateTime.TryParse(tempStr, out LastUpdated);

            tempStr = xmlRetrieved["usage"]["down1"].FirstChild.InnerText;
            long.TryParse(tempStr, out Down1);

            tempStr = xmlRetrieved["usage"]["down2"].FirstChild.InnerText;
            long.TryParse(tempStr, out Down2);

            tempStr = xmlRetrieved["usage"]["up1"].FirstChild.InnerText;
            long.TryParse(tempStr, out Up1);

            tempStr = xmlRetrieved["usage"]["up2"].FirstChild.InnerText;
            long.TryParse(tempStr, out Up2);

            tempStr = xmlRetrieved["usage"]["left1"].FirstChild.InnerText;
            long.TryParse(tempStr, out Left1);

            tempStr = xmlRetrieved["usage"]["left2"].FirstChild.InnerText;
            long.TryParse(tempStr, out Left2);

            tempStr = xmlRetrieved["usage"]["allowance1_mb"].FirstChild.InnerText;
            long.TryParse(tempStr, out AllowanceMb1);

            tempStr = xmlRetrieved["usage"]["allowance2_mb"].FirstChild.InnerText;
            long.TryParse(tempStr, out AllowanceMb2);
        }
    }
}
