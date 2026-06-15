namespace MyLibrary
{
    partial class StatisticsForm
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
            lblTotal = new Label();
            lblIssued = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 22F);
            lblTotal.Location = new Point(503, 360);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 41);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "label1";
            // 
            // lblIssued
            // 
            lblIssued.AutoSize = true;
            lblIssued.Font = new Font("Segoe UI", 22F);
            lblIssued.Location = new Point(1005, 360);
            lblIssued.Name = "lblIssued";
            lblIssued.Size = new Size(97, 41);
            lblIssued.TabIndex = 1;
            lblIssued.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(273, 347);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 2;
            label1.Text = "Всего книг:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(828, 347);
            label2.Name = "label2";
            label2.Size = new Size(171, 54);
            label2.TabIndex = 3;
            label2.Text = "Выдано:";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 686);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIssued);
            Controls.Add(lblTotal);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblIssued;
        private Label label1;
        private Label label2;
    }
}