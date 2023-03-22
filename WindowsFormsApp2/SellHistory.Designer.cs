
namespace WindowsFormsApp2
{
    partial class SellHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDhakaTicketSold = new System.Windows.Forms.TextBox();
            this.txtTotalChittagongTicketSold = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalFeniTicketSold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDk = new System.Windows.Forms.Button();
            this.btnShowCtg = new System.Windows.Forms.Button();
            this.btnShowFn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnShowFn);
            this.panel1.Controls.Add(this.btnShowCtg);
            this.panel1.Controls.Add(this.btnShowDk);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.txtTotalFeniTicketSold);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalChittagongTicketSold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotalDhakaTicketSold);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 532);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sell History";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Dhaka Ticket sold:";
            // 
            // txtTotalDhakaTicketSold
            // 
            this.txtTotalDhakaTicketSold.Location = new System.Drawing.Point(250, 131);
            this.txtTotalDhakaTicketSold.Name = "txtTotalDhakaTicketSold";
            this.txtTotalDhakaTicketSold.ReadOnly = true;
            this.txtTotalDhakaTicketSold.Size = new System.Drawing.Size(100, 22);
            this.txtTotalDhakaTicketSold.TabIndex = 2;
            // 
            // txtTotalChittagongTicketSold
            // 
            this.txtTotalChittagongTicketSold.Location = new System.Drawing.Point(250, 239);
            this.txtTotalChittagongTicketSold.Name = "txtTotalChittagongTicketSold";
            this.txtTotalChittagongTicketSold.ReadOnly = true;
            this.txtTotalChittagongTicketSold.Size = new System.Drawing.Size(100, 22);
            this.txtTotalChittagongTicketSold.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total ChittaGong Ticket sold:";
            // 
            // txtTotalFeniTicketSold
            // 
            this.txtTotalFeniTicketSold.Location = new System.Drawing.Point(250, 343);
            this.txtTotalFeniTicketSold.Name = "txtTotalFeniTicketSold";
            this.txtTotalFeniTicketSold.ReadOnly = true;
            this.txtTotalFeniTicketSold.Size = new System.Drawing.Size(100, 22);
            this.txtTotalFeniTicketSold.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Feni Ticket sold:";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(58, 448);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(80, 28);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(223, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDk
            // 
            this.btnShowDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDk.Location = new System.Drawing.Point(250, 187);
            this.btnShowDk.Name = "btnShowDk";
            this.btnShowDk.Size = new System.Drawing.Size(80, 28);
            this.btnShowDk.TabIndex = 9;
            this.btnShowDk.Text = "Show";
            this.btnShowDk.UseVisualStyleBackColor = true;
            this.btnShowDk.Click += new System.EventHandler(this.btnShowDk_Click);
            // 
            // btnShowCtg
            // 
            this.btnShowCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCtg.Location = new System.Drawing.Point(250, 288);
            this.btnShowCtg.Name = "btnShowCtg";
            this.btnShowCtg.Size = new System.Drawing.Size(80, 28);
            this.btnShowCtg.TabIndex = 10;
            this.btnShowCtg.Text = "Show";
            this.btnShowCtg.UseVisualStyleBackColor = true;
            this.btnShowCtg.Click += new System.EventHandler(this.btnShowCtg_Click);
            // 
            // btnShowFn
            // 
            this.btnShowFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFn.Location = new System.Drawing.Point(250, 387);
            this.btnShowFn.Name = "btnShowFn";
            this.btnShowFn.Size = new System.Drawing.Size(80, 28);
            this.btnShowFn.TabIndex = 11;
            this.btnShowFn.Text = "Show";
            this.btnShowFn.UseVisualStyleBackColor = true;
            this.btnShowFn.Click += new System.EventHandler(this.btnShowFn_Click);
            // 
            // SellHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 556);
            this.Controls.Add(this.panel1);
            this.Name = "SellHistory";
            this.Text = "SellHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtTotalFeniTicketSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalChittagongTicketSold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalDhakaTicketSold;
        private System.Windows.Forms.Button btnShowFn;
        private System.Windows.Forms.Button btnShowCtg;
        private System.Windows.Forms.Button btnShowDk;
    }
}