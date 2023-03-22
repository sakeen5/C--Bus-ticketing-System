
namespace WindowsFormsApp2
{
    partial class UpdateStock
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
            this.txtTotalAc = new System.Windows.Forms.TextBox();
            this.txtTotalnonAc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalReserved = new System.Windows.Forms.TextBox();
            this.lebel5 = new System.Windows.Forms.Label();
            this.txtTotalPremium = new System.Windows.Forms.TextBox();
            this.lebel4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.txtOutputReserved = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputTotalPremium = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputTotalnonAc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputTotalAc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtTotalReserved);
            this.panel1.Controls.Add(this.lebel5);
            this.panel1.Controls.Add(this.txtTotalPremium);
            this.panel1.Controls.Add(this.lebel4);
            this.panel1.Controls.Add(this.txtTotalnonAc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTotalAc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 441);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Ac";
            // 
            // txtTotalAc
            // 
            this.txtTotalAc.Location = new System.Drawing.Point(156, 94);
            this.txtTotalAc.Name = "txtTotalAc";
            this.txtTotalAc.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAc.TabIndex = 2;
            // 
            // txtTotalnonAc
            // 
            this.txtTotalnonAc.Location = new System.Drawing.Point(156, 151);
            this.txtTotalnonAc.Name = "txtTotalnonAc";
            this.txtTotalnonAc.Size = new System.Drawing.Size(100, 22);
            this.txtTotalnonAc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(47, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total non-Ac";
            // 
            // txtTotalReserved
            // 
            this.txtTotalReserved.Location = new System.Drawing.Point(156, 265);
            this.txtTotalReserved.Name = "txtTotalReserved";
            this.txtTotalReserved.Size = new System.Drawing.Size(100, 22);
            this.txtTotalReserved.TabIndex = 8;
            // 
            // lebel5
            // 
            this.lebel5.AutoSize = true;
            this.lebel5.BackColor = System.Drawing.Color.LightGray;
            this.lebel5.Location = new System.Drawing.Point(47, 268);
            this.lebel5.Name = "lebel5";
            this.lebel5.Size = new System.Drawing.Size(69, 17);
            this.lebel5.TabIndex = 7;
            this.lebel5.Text = "Reserved";
            // 
            // txtTotalPremium
            // 
            this.txtTotalPremium.Location = new System.Drawing.Point(156, 204);
            this.txtTotalPremium.Name = "txtTotalPremium";
            this.txtTotalPremium.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPremium.TabIndex = 6;
            // 
            // lebel4
            // 
            this.lebel4.AutoSize = true;
            this.lebel4.BackColor = System.Drawing.Color.LightGray;
            this.lebel4.Location = new System.Drawing.Point(47, 207);
            this.lebel4.Name = "lebel4";
            this.lebel4.Size = new System.Drawing.Size(99, 17);
            this.lebel4.TabIndex = 5;
            this.lebel4.Text = "Total Premium";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.btnUpdated);
            this.panel2.Controls.Add(this.txtOutputReserved);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtOutputTotalPremium);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtOutputTotalnonAc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtOutputTotalAc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(410, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 437);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(109, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdated
            // 
            this.btnUpdated.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdated.Location = new System.Drawing.Point(106, 356);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(91, 26);
            this.btnUpdated.TabIndex = 19;
            this.btnUpdated.Text = "Updated";
            this.btnUpdated.UseVisualStyleBackColor = true;
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // txtOutputReserved
            // 
            this.txtOutputReserved.Location = new System.Drawing.Point(162, 285);
            this.txtOutputReserved.Name = "txtOutputReserved";
            this.txtOutputReserved.ReadOnly = true;
            this.txtOutputReserved.Size = new System.Drawing.Size(100, 22);
            this.txtOutputReserved.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(53, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reserved";
            // 
            // txtOutputTotalPremium
            // 
            this.txtOutputTotalPremium.Location = new System.Drawing.Point(162, 224);
            this.txtOutputTotalPremium.Name = "txtOutputTotalPremium";
            this.txtOutputTotalPremium.ReadOnly = true;
            this.txtOutputTotalPremium.Size = new System.Drawing.Size(100, 22);
            this.txtOutputTotalPremium.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(53, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Premium";
            // 
            // txtOutputTotalnonAc
            // 
            this.txtOutputTotalnonAc.Location = new System.Drawing.Point(162, 171);
            this.txtOutputTotalnonAc.Name = "txtOutputTotalnonAc";
            this.txtOutputTotalnonAc.ReadOnly = true;
            this.txtOutputTotalnonAc.Size = new System.Drawing.Size(100, 22);
            this.txtOutputTotalnonAc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(53, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total non-Ac";
            // 
            // txtOutputTotalAc
            // 
            this.txtOutputTotalAc.Location = new System.Drawing.Point(162, 114);
            this.txtOutputTotalAc.Name = "txtOutputTotalAc";
            this.txtOutputTotalAc.ReadOnly = true;
            this.txtOutputTotalAc.Size = new System.Drawing.Size(100, 22);
            this.txtOutputTotalAc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(53, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Ac";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Updated";
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateStock";
            this.Text = "UpdateStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTotalReserved;
        private System.Windows.Forms.Label lebel5;
        private System.Windows.Forms.TextBox txtTotalPremium;
        private System.Windows.Forms.Label lebel4;
        private System.Windows.Forms.TextBox txtTotalnonAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.TextBox txtOutputReserved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputTotalPremium;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputTotalnonAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutputTotalAc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}