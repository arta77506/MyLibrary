using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MyLibrary
{
    public partial class StatisticsForm : Form
    {
        private string connectionString = @"Data Source=C:\Projects\library_system";

        public StatisticsForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);

            foreach (Control control in this.Controls)
            {
                if (control is Label lbl)
                {
                    if (lbl.Name.Contains("Total") || lbl.Name.Contains("Issued"))
                    {
                        // Это наши цифры
                        lbl.Font = new System.Drawing.Font("Segoe UI Black", 36);
                        lbl.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
                        lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        lbl.AutoSize = true;
                    }
                    else
                    {
                        // Это подписи ("Всего книг:", "Выдано:")
                        lbl.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular);
                        lbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
                        lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    }
                }
            }
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); 

            foreach (Control c in this.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.BackColor = System.Drawing.Color.Transparent;
                    if (lbl.Name.Contains("Total") || lbl.Name.Contains("Issued"))
                        lbl.ForeColor = System.Drawing.Color.FromArgb(0, 190, 255);
                    else
                        lbl.ForeColor = System.Drawing.Color.LightGray; 
                }
            }

            this.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (var bgFont = new System.Drawing.Font("Segoe UI", 48, System.Drawing.FontStyle.Bold))
                using (var bgBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(40, 40, 40))) 
                {
                    e.Graphics.DrawString("STATISTICS", bgFont, bgBrush, new System.Drawing.PointF(10, 10));
                }


                using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(60, 60, 60), 2))
                {

                    e.Graphics.DrawLine(pen, 50, this.Height / 2, this.Width - 50, this.Height / 2);
                }
            };
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryTotal = "SELECT COUNT(*) FROM books";
                    SqliteCommand cmdTotal = new SqliteCommand(queryTotal, connection);
                    long total = (long)cmdTotal.ExecuteScalar();
                    lblTotal.Text = total.ToString();

                    string queryIssued = "SELECT COUNT(*) FROM books WHERE status = 'Выдана'";
                    SqliteCommand cmdIssued = new SqliteCommand(queryIssued, connection);
                    long issued = (long)cmdIssued.ExecuteScalar();
                    lblIssued.Text = issued.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подсчете статистики: " + ex.Message);
                }
            }
        }
    }
}