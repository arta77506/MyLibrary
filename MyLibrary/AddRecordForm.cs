using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MyLibrary
{
    public partial class AddRecordForm : Form
    {
        private string connectionString = @"Data Source=C:\Projects\library_system";

        public AddRecordForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;

            foreach (Control control in this.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10);
                    lbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100); 
                }

                else if (control is TextBox txt)
                {
                    txt.Font = new System.Drawing.Font("Segoe UI", 12);
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
                    txt.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
                }

                else if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                    btn.Height = 45; 

                    btn.MouseEnter += (s, e) => btn.BackColor = System.Drawing.Color.FromArgb(0, 90, 158);
                    btn.MouseLeave += (s, e) => btn.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);

                }
            }
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250); 

            foreach (Control c in this.Controls)
            {
                if (c is Label lbl) lbl.BackColor = System.Drawing.Color.Transparent;
            }

            this.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (var waterFont = new System.Drawing.Font("Segoe UI Black", 50, System.Drawing.FontStyle.Bold))
                using (var waterBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(230, 235, 240))) 
                {
                    e.Graphics.DrawString("ДОБАВЛЕНИЕ\nНОВОЙ ЗАПИСИ", waterFont, waterBrush, new System.Drawing.PointF(10, 40));
                }

                using (var accentBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 120, 212)))
                {
                    e.Graphics.FillRectangle(accentBrush, 0, 20, 10, 50);
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Название книги обязательно для заполнения!");
                return;
            }

            string query = @"INSERT INTO books (inv_number, title, author, genre, year_published, pages) 
                             VALUES (@inv, @title, @author, @genre, @year, @pages)";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand(query, connection);

                    command.Parameters.AddWithValue("@inv", txtInv.Text);
                    command.Parameters.AddWithValue("@title", txtTitle.Text);
                    command.Parameters.AddWithValue("@author", txtAuthor.Text);
                    command.Parameters.AddWithValue("@genre", txtGenre.Text);

                    int.TryParse(txtYear.Text, out int year);
                    int.TryParse(txtPages.Text, out int pages);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@pages", pages);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Книга успешно добавлена в базу данных!");

                    txtInv.Clear();
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    txtGenre.Clear();
                    txtYear.Clear();
                    txtPages.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }
            }
        }
    }
}