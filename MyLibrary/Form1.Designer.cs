namespace MyLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(55, 156);
            button1.Name = "button1";
            button1.Size = new Size(324, 73);
            button1.TabIndex = 0;
            button1.Text = "Каталог книг";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 22F);
            button2.Location = new Point(55, 362);
            button2.Name = "button2";
            button2.Size = new Size(324, 73);
            button2.TabIndex = 1;
            button2.Text = "Добавить книгу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 22F);
            button3.Location = new Point(55, 259);
            button3.Name = "button3";
            button3.Size = new Size(324, 73);
            button3.TabIndex = 2;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 22F);
            button4.Location = new Point(55, 466);
            button4.Name = "button4";
            button4.Size = new Size(324, 73);
            button4.TabIndex = 3;
            button4.Text = "Статистика";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1425, 691);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
