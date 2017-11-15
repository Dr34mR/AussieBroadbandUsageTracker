namespace AussieUsage
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblDown = new System.Windows.Forms.Label();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.lblLastHeading = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.txtCombined = new System.Windows.Forms.TextBox();
            this.lblCombined = new System.Windows.Forms.Label();
            this.txtMonthCap = new System.Windows.Forms.TextBox();
            this.txtMonthRemain = new System.Windows.Forms.TextBox();
            this.lblMonthCap = new System.Windows.Forms.Label();
            this.lblMonthRemain = new System.Windows.Forms.Label();
            this.txtAvgMonth = new System.Windows.Forms.TextBox();
            this.lblAvgMonth = new System.Windows.Forms.Label();
            this.txtAvgRemain = new System.Windows.Forms.TextBox();
            this.txtRolloverDay = new System.Windows.Forms.TextBox();
            this.txtDaysRemain = new System.Windows.Forms.TextBox();
            this.lblAvgRemain = new System.Windows.Forms.Label();
            this.lblRolloverDay = new System.Windows.Forms.Label();
            this.lblDaysRemain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Location = new System.Drawing.Point(12, 50);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(38, 13);
            this.lblDown.TabIndex = 3;
            this.lblDown.Text = "Down:";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(118, 47);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(100, 20);
            this.txtDown.TabIndex = 7;
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(118, 73);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(100, 20);
            this.txtUp.TabIndex = 8;
            // 
            // lblLastHeading
            // 
            this.lblLastHeading.AutoSize = true;
            this.lblLastHeading.Location = new System.Drawing.Point(93, 17);
            this.lblLastHeading.Name = "lblLastHeading";
            this.lblLastHeading.Size = new System.Drawing.Size(74, 13);
            this.lblLastHeading.TabIndex = 9;
            this.lblLastHeading.Text = "Last Updated:";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(173, 17);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(38, 13);
            this.lblLastUpdated.TabIndex = 21;
            this.lblLastUpdated.Text = "NONE";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(12, 76);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(24, 13);
            this.lblUp.TabIndex = 22;
            this.lblUp.Text = "Up:";
            // 
            // txtCombined
            // 
            this.txtCombined.Location = new System.Drawing.Point(118, 99);
            this.txtCombined.Name = "txtCombined";
            this.txtCombined.Size = new System.Drawing.Size(100, 20);
            this.txtCombined.TabIndex = 23;
            // 
            // lblCombined
            // 
            this.lblCombined.AutoSize = true;
            this.lblCombined.Location = new System.Drawing.Point(12, 102);
            this.lblCombined.Name = "lblCombined";
            this.lblCombined.Size = new System.Drawing.Size(57, 13);
            this.lblCombined.TabIndex = 24;
            this.lblCombined.Text = "Combined:";
            // 
            // txtMonthCap
            // 
            this.txtMonthCap.Location = new System.Drawing.Point(118, 140);
            this.txtMonthCap.Name = "txtMonthCap";
            this.txtMonthCap.Size = new System.Drawing.Size(100, 20);
            this.txtMonthCap.TabIndex = 25;
            // 
            // txtMonthRemain
            // 
            this.txtMonthRemain.Location = new System.Drawing.Point(118, 166);
            this.txtMonthRemain.Name = "txtMonthRemain";
            this.txtMonthRemain.Size = new System.Drawing.Size(100, 20);
            this.txtMonthRemain.TabIndex = 26;
            // 
            // lblMonthCap
            // 
            this.lblMonthCap.AutoSize = true;
            this.lblMonthCap.Location = new System.Drawing.Point(12, 143);
            this.lblMonthCap.Name = "lblMonthCap";
            this.lblMonthCap.Size = new System.Drawing.Size(69, 13);
            this.lblMonthCap.TabIndex = 27;
            this.lblMonthCap.Text = "Monthly Cap:";
            // 
            // lblMonthRemain
            // 
            this.lblMonthRemain.AutoSize = true;
            this.lblMonthRemain.Location = new System.Drawing.Point(12, 169);
            this.lblMonthRemain.Name = "lblMonthRemain";
            this.lblMonthRemain.Size = new System.Drawing.Size(100, 13);
            this.lblMonthRemain.TabIndex = 28;
            this.lblMonthRemain.Text = "Monthly Remaining:";
            // 
            // txtAvgMonth
            // 
            this.txtAvgMonth.Location = new System.Drawing.Point(325, 47);
            this.txtAvgMonth.Name = "txtAvgMonth";
            this.txtAvgMonth.Size = new System.Drawing.Size(100, 20);
            this.txtAvgMonth.TabIndex = 29;
            // 
            // lblAvgMonth
            // 
            this.lblAvgMonth.AutoSize = true;
            this.lblAvgMonth.Location = new System.Drawing.Point(232, 50);
            this.lblAvgMonth.Name = "lblAvgMonth";
            this.lblAvgMonth.Size = new System.Drawing.Size(70, 13);
            this.lblAvgMonth.TabIndex = 30;
            this.lblAvgMonth.Text = "Avg Per Day:";
            // 
            // txtAvgRemain
            // 
            this.txtAvgRemain.Location = new System.Drawing.Point(325, 73);
            this.txtAvgRemain.Name = "txtAvgRemain";
            this.txtAvgRemain.Size = new System.Drawing.Size(100, 20);
            this.txtAvgRemain.TabIndex = 31;
            // 
            // txtRolloverDay
            // 
            this.txtRolloverDay.Location = new System.Drawing.Point(325, 140);
            this.txtRolloverDay.Name = "txtRolloverDay";
            this.txtRolloverDay.Size = new System.Drawing.Size(100, 20);
            this.txtRolloverDay.TabIndex = 32;
            // 
            // txtDaysRemain
            // 
            this.txtDaysRemain.Location = new System.Drawing.Point(325, 166);
            this.txtDaysRemain.Name = "txtDaysRemain";
            this.txtDaysRemain.Size = new System.Drawing.Size(100, 20);
            this.txtDaysRemain.TabIndex = 33;
            // 
            // lblAvgRemain
            // 
            this.lblAvgRemain.AutoSize = true;
            this.lblAvgRemain.Location = new System.Drawing.Point(232, 76);
            this.lblAvgRemain.Name = "lblAvgRemain";
            this.lblAvgRemain.Size = new System.Drawing.Size(87, 13);
            this.lblAvgRemain.TabIndex = 34;
            this.lblAvgRemain.Text = "Per Day Remain:";
            // 
            // lblRolloverDay
            // 
            this.lblRolloverDay.AutoSize = true;
            this.lblRolloverDay.Location = new System.Drawing.Point(232, 143);
            this.lblRolloverDay.Name = "lblRolloverDay";
            this.lblRolloverDay.Size = new System.Drawing.Size(71, 13);
            this.lblRolloverDay.TabIndex = 35;
            this.lblRolloverDay.Text = "Rollover Day:";
            // 
            // lblDaysRemain
            // 
            this.lblDaysRemain.AutoSize = true;
            this.lblDaysRemain.Location = new System.Drawing.Point(232, 169);
            this.lblDaysRemain.Name = "lblDaysRemain";
            this.lblDaysRemain.Size = new System.Drawing.Size(87, 13);
            this.lblDaysRemain.TabIndex = 36;
            this.lblDaysRemain.Text = "Days Remaining:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 204);
            this.Controls.Add(this.lblDaysRemain);
            this.Controls.Add(this.lblRolloverDay);
            this.Controls.Add(this.lblAvgRemain);
            this.Controls.Add(this.txtDaysRemain);
            this.Controls.Add(this.txtRolloverDay);
            this.Controls.Add(this.txtAvgRemain);
            this.Controls.Add(this.lblAvgMonth);
            this.Controls.Add(this.txtAvgMonth);
            this.Controls.Add(this.lblMonthRemain);
            this.Controls.Add(this.lblMonthCap);
            this.Controls.Add(this.txtMonthRemain);
            this.Controls.Add(this.txtMonthCap);
            this.Controls.Add(this.lblCombined);
            this.Controls.Add(this.txtCombined);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblLastHeading);
            this.Controls.Add(this.txtUp);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.btnRefresh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AussieBB Usage";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.Label lblLastHeading;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.TextBox txtCombined;
        private System.Windows.Forms.Label lblCombined;
        private System.Windows.Forms.TextBox txtMonthCap;
        private System.Windows.Forms.TextBox txtMonthRemain;
        private System.Windows.Forms.Label lblMonthCap;
        private System.Windows.Forms.Label lblMonthRemain;
        private System.Windows.Forms.TextBox txtAvgMonth;
        private System.Windows.Forms.Label lblAvgMonth;
        private System.Windows.Forms.TextBox txtAvgRemain;
        private System.Windows.Forms.TextBox txtRolloverDay;
        private System.Windows.Forms.TextBox txtDaysRemain;
        private System.Windows.Forms.Label lblAvgRemain;
        private System.Windows.Forms.Label lblRolloverDay;
        private System.Windows.Forms.Label lblDaysRemain;
    }
}

