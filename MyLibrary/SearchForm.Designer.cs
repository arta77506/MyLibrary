namespace MyLibrary
{
    partial class SearchForm
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
            txtSearch = new TextBox();
            btnFind = new Button();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1112, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(607, 606);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(149, 48);
            btnFind.TabIndex = 1;
            btnFind.Text = "Найти";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(160, 170);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(1070, 376);
            dgvResults.TabIndex = 2;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 681);
            Controls.Add(dgvResults);
            Controls.Add(btnFind);
            Controls.Add(txtSearch);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnFind;
        private DataGridView dgvResults;
    }
}