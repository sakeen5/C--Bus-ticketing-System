
namespace WindowsFormsApp2
{
    partial class AdminPanel
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
            this.btnStockTicket = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnSellingHistory = new System.Windows.Forms.Button();
            this.btnBusSchedule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btnBusSchedule);
            this.panel1.Controls.Add(this.btnSellingHistory);
            this.panel1.Controls.Add(this.btnUpdateStock);
            this.panel1.Controls.Add(this.btnStockTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnStockTicket
            // 
            this.btnStockTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockTicket.ForeColor = System.Drawing.Color.White;
            this.btnStockTicket.Location = new System.Drawing.Point(26, 25);
            this.btnStockTicket.Name = "btnStockTicket";
            this.btnStockTicket.Size = new System.Drawing.Size(111, 52);
            this.btnStockTicket.TabIndex = 0;
            this.btnStockTicket.Text = "Stock Ticket";
            this.btnStockTicket.UseVisualStyleBackColor = true;
            this.btnStockTicket.Click += new System.EventHandler(this.btnStockTicket_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStock.Location = new System.Drawing.Point(167, 25);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(118, 52);
            this.btnUpdateStock.TabIndex = 1;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnSellingHistory
            // 
            this.btnSellingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellingHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellingHistory.ForeColor = System.Drawing.Color.White;
            this.btnSellingHistory.Location = new System.Drawing.Point(312, 25);
            this.btnSellingHistory.Name = "btnSellingHistory";
            this.btnSellingHistory.Size = new System.Drawing.Size(111, 52);
            this.btnSellingHistory.TabIndex = 2;
            this.btnSellingHistory.Text = "Sell History";
            this.btnSellingHistory.UseVisualStyleBackColor = true;
            this.btnSellingHistory.Click += new System.EventHandler(this.btnSellingHistory_Click);
            // 
            // btnBusSchedule
            // 
            this.btnBusSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusSchedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusSchedule.ForeColor = System.Drawing.Color.White;
            this.btnBusSchedule.Location = new System.Drawing.Point(450, 25);
            this.btnBusSchedule.Name = "btnBusSchedule";
            this.btnBusSchedule.Size = new System.Drawing.Size(111, 52);
            this.btnBusSchedule.TabIndex = 3;
            this.btnBusSchedule.Text = "Bus Schedule";
            this.btnBusSchedule.UseVisualStyleBackColor = true;
            this.btnBusSchedule.Click += new System.EventHandler(this.btnBusSchedule_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 527);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockTicket;
        private System.Windows.Forms.Button btnBusSchedule;
        private System.Windows.Forms.Button btnSellingHistory;
        private System.Windows.Forms.Button btnUpdateStock;
    }
}