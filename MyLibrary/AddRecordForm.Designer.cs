namespace MyLibrary
{
    partial class AddRecordForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtInv = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtYear = new TextBox();
            txtPages = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 103);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Инвентарный №";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 140);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 181);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 221);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Жанр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 261);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Год издания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 308);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 5;
            label6.Text = "Кол-во страниц";
            // 
            // txtInv
            // 
            txtInv.Location = new Point(649, 100);
            txtInv.Name = "txtInv";
            txtInv.Size = new Size(100, 23);
            txtInv.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(649, 137);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(649, 178);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(649, 218);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(649, 258);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 10;
            // 
            // txtPages
            // 
            txtPages.Location = new Point(649, 305);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(100, 23);
            txtPages.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(869, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 41);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить книгу";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 468);
            Controls.Add(btnSave);
            Controls.Add(txtPages);
            Controls.Add(txtYear);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtInv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRecordForm";
            Text = "AddRecordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtInv;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtYear;
        private TextBox txtPages;
        private Button btnSave;
    }
}