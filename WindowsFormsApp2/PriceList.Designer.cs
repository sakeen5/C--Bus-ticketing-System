
namespace WindowsFormsApp2
{
    partial class PriceList
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
            this.pnlPriceList = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateofOrder = new System.Windows.Forms.DateTimePicker();
            this.cmbTypeandPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateofOrder = new System.Windows.Forms.Label();
            this.txtOutputTickets = new System.Windows.Forms.Label();
            this.lblTypeandPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPriceList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPriceList
            // 
            this.pnlPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPriceList.Controls.Add(this.btnConfirm);
            this.pnlPriceList.Controls.Add(this.txtTickets);
            this.pnlPriceList.Controls.Add(this.label6);
            this.pnlPriceList.Controls.Add(this.label5);
            this.pnlPriceList.Controls.Add(this.dtpDateofOrder);
            this.pnlPriceList.Controls.Add(this.cmbTypeandPrice);
            this.pnlPriceList.Controls.Add(this.label4);
            this.pnlPriceList.Controls.Add(this.cmbTime);
            this.pnlPriceList.Controls.Add(this.label3);
            this.pnlPriceList.Controls.Add(this.cmbDestination);
            this.pnlPriceList.Controls.Add(this.label2);
            this.pnlPriceList.Controls.Add(this.label1);
            this.pnlPriceList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPriceList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPriceList.ForeColor = System.Drawing.Color.Black;
            this.pnlPriceList.Location = new System.Drawing.Point(16, 28);
            this.pnlPriceList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPriceList.Name = "pnlPriceList";
            this.pnlPriceList.Size = new System.Drawing.Size(301, 401);
            this.pnlPriceList.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(109, 345);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 32);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(170, 285);
            this.txtTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(92, 25);
            this.txtTickets.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(38, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tickets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Order";
            // 
            // dtpDateofOrder
            // 
            this.dtpDateofOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofOrder.Location = new System.Drawing.Point(170, 231);
            this.dtpDateofOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateofOrder.Name = "dtpDateofOrder";
            this.dtpDateofOrder.Size = new System.Drawing.Size(92, 25);
            this.dtpDateofOrder.TabIndex = 7;
            // 
            // cmbTypeandPrice
            // 
            this.cmbTypeandPrice.AutoCompleteCustomSource.AddRange(new string[] {
            "AC:1500(Cox\'s Bazar)",
            "Non-AC:900",
            "Premium:2100",
            "AC:1100(Chittagong)",
            "Non-AC:600",
            "Premium:1650",
            "AC:700(Feni)",
            "Non-AC:370",
            "Premium:1000"});
            this.cmbTypeandPrice.FormattingEnabled = true;
            this.cmbTypeandPrice.Items.AddRange(new object[] {
            "AC:1500(COX-DHK)",
            "Non-AC:900(COX-DHK)",
            "Premium:2100(COX-DHK)",
            "AC:1000(CTG-DHK)",
            "Non-AC:600(CTG-DHK)",
            "Premium:1800(CTG-DHK)",
            "AC:500(FENI-DHK)",
            "Non-AC:360(FENI-DHK)",
            "Premium:1000(FENI-DHK)"});
            this.cmbTypeandPrice.Location = new System.Drawing.Point(170, 190);
            this.cmbTypeandPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTypeandPrice.Name = "cmbTypeandPrice";
            this.cmbTypeandPrice.Size = new System.Drawing.Size(92, 28);
            this.cmbTypeandPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(38, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type and Price";
            // 
            // cmbTime
            // 
            this.cmbTime.AutoCompleteCustomSource.AddRange(new string[] {
            "11AM,Airport(Ctg)",
            "11AM,Abdullahpur(Ctg)",
            "1PM,Abdullahpur(Feni)",
            "1PM,Airport(Feni)",
            "3PM,Airport(Cox)",
            "3PM,Abdullahpur(Cox)",
            "1PM,Feni(Dha)",
            "1PM,Feni(Dha)",
            "7PM,Dumpara(Dha)",
            "8PM,Boddarhut(Dha)",
            "3PM,Beach point(Dha)",
            "4PM,Dolphinmor(Dha)"});
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "11AM,Airport(Chittagong)",
            "11AM,Abdullahpur(Chittagong)",
            "1PM,Airport(Feni)",
            "1PM,Abdullahpur(Feni)",
            "11PM,Airport(Cox\'s Bazar)",
            "11PM,Abdullahpur(Cox\'s Bazar)",
            "3PM,Dumpara(Dhaka)",
            "3PM,Boddarhut(Dhaka)",
            "7PM,Feni(Dhaka)",
            "7PM,Feni(Dhaka)",
            "11AM,Dalphinmor(Dhaka)",
            "7PM,Beach point(Dhaka)"});
            this.cmbTime.Location = new System.Drawing.Point(170, 137);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(92, 28);
            this.cmbTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time\r\n";
            // 
            // cmbDestination
            // 
            this.cmbDestination.AutoCompleteCustomSource.AddRange(new string[] {
            "Dhaka to Cox\'s Bazar",
            "Dhaka to Chittagong",
            "Dhaka to Feni",
            "Chittagong to Dhaka",
            "Cox\'s Bazar to Dhaka",
            "Feni to Dhaka"});
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "Dhaka to Chittagong",
            "Dhaka to Feni",
            "Dhaka to Cox\'s Bazar",
            "Chittagong to Dhaka",
            "Feni to Dhaka",
            "Cox\'s Bazar to Dhaka"});
            this.cmbDestination.Location = new System.Drawing.Point(170, 79);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(92, 28);
            this.cmbDestination.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lblDateofOrder);
            this.panel2.Controls.Add(this.txtOutputTickets);
            this.panel2.Controls.Add(this.lblTypeandPrice);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDestination);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtDestination);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(329, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 401);
            this.panel2.TabIndex = 1;
            // 
            // lblDateofOrder
            // 
            this.lblDateofOrder.AutoSize = true;
            this.lblDateofOrder.BackColor = System.Drawing.Color.White;
            this.lblDateofOrder.Enabled = false;
            this.lblDateofOrder.Location = new System.Drawing.Point(134, 240);
            this.lblDateofOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateofOrder.Name = "lblDateofOrder";
            this.lblDateofOrder.Size = new System.Drawing.Size(77, 13);
            this.lblDateofOrder.TabIndex = 28;
            this.lblDateofOrder.Text = "oDate of Order";
            // 
            // txtOutputTickets
            // 
            this.txtOutputTickets.AutoSize = true;
            this.txtOutputTickets.BackColor = System.Drawing.Color.White;
            this.txtOutputTickets.Enabled = false;
            this.txtOutputTickets.Location = new System.Drawing.Point(138, 290);
            this.txtOutputTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOutputTickets.Name = "txtOutputTickets";
            this.txtOutputTickets.Size = new System.Drawing.Size(48, 13);
            this.txtOutputTickets.TabIndex = 27;
            this.txtOutputTickets.Text = "oTickets";
            // 
            // lblTypeandPrice
            // 
            this.lblTypeandPrice.AutoSize = true;
            this.lblTypeandPrice.BackColor = System.Drawing.Color.White;
            this.lblTypeandPrice.Enabled = false;
            this.lblTypeandPrice.Location = new System.Drawing.Point(138, 197);
            this.lblTypeandPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeandPrice.Name = "lblTypeandPrice";
            this.lblTypeandPrice.Size = new System.Drawing.Size(85, 13);
            this.lblTypeandPrice.TabIndex = 26;
            this.lblTypeandPrice.Text = "oType and Price";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Enabled = false;
            this.lblTime.Location = new System.Drawing.Point(138, 145);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "oTime\r\n";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BackColor = System.Drawing.Color.White;
            this.lblDestination.Enabled = false;
            this.lblDestination.Location = new System.Drawing.Point(134, 86);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(66, 13);
            this.lblDestination.TabIndex = 24;
            this.lblDestination.Text = "oDestination";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(117, 340);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(8, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tickets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date of Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(8, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Type and Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(8, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Time\r\n";
            // 
            // txtDestination
            // 
            this.txtDestination.AutoSize = true;
            this.txtDestination.BackColor = System.Drawing.Color.White;
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(8, 86);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(60, 13);
            this.txtDestination.TabIndex = 13;
            this.txtDestination.Text = "Destination";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(113, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Order";
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPriceList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PriceList";
            this.Text = "PriceList";
            this.pnlPriceList.ResumeLayout(false);
            this.pnlPriceList.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPriceList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateofOrder;
        private System.Windows.Forms.ComboBox cmbTypeandPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeandPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtDestination;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtOutputTickets;
        private System.Windows.Forms.Label lblDateofOrder;
    }
}