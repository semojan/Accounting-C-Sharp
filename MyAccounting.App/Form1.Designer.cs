namespace MyAccounting.App
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnExpenseReport = new System.Windows.Forms.ToolStripButton();
            this.btnIncomeReport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.toolStripButton2,
            this.btnExpenseReport,
            this.btnIncomeReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::MyAccounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(68, 59);
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MyAccounting.App.Properties.Resources._1371476499_todo_list;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(98, 59);
            this.toolStripButton2.Text = "New Transaction";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnExpenseReport
            // 
            this.btnExpenseReport.Image = global::MyAccounting.App.Properties.Resources.servicesCosts;
            this.btnExpenseReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExpenseReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpenseReport.Name = "btnExpenseReport";
            this.btnExpenseReport.Size = new System.Drawing.Size(85, 59);
            this.btnExpenseReport.Text = "Exense Report";
            this.btnExpenseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenseReport.Click += new System.EventHandler(this.btnExpenseReport_Click);
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Image = global::MyAccounting.App.Properties.Resources._1370791030_credit_card;
            this.btnIncomeReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncomeReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Size = new System.Drawing.Size(89, 59);
            this.btnIncomeReport.Text = "Income Report";
            this.btnIncomeReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Accounting";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnExpenseReport;
        private System.Windows.Forms.ToolStripButton btnIncomeReport;
    }
}

