using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MyLibrary
{
    public partial class CatalogForm : Form
    {
        private string connectionString = @"Data Source=C:\Projects\library_system";

        public CatalogForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.White;

            var dgv = this.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {

                dgv.BorderStyle = BorderStyle.None;
                dgv.BackgroundColor = System.Drawing.Color.White;
                dgv.RowHeadersVisible = false; 
                dgv.AllowUserToAddRows = false; 

                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = System.Drawing.Color.FromArgb(238, 238, 238);

                dgv.RowTemplate.Height = 45;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.5f);
                dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
                dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(234, 242, 251); 
                dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0); 
                dgv.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0); 

                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersHeight = 50;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(41, 57, 85); 
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                var grid = this.Controls.OfType<DataGridView>().FirstOrDefault();
                if (grid != null)
                {
                    grid.Top = 80; 
                    grid.Height = this.ClientSize.Height - 100; 
                    grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                }

                this.Paint += (sender, e) =>
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    using (var headerBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(41, 57, 85)))
                    {
                        e.Graphics.FillRectangle(headerBrush, 0, 0, this.Width, 80);
                    }

                    using (var titleFont = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold))
                    using (var textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                    {
                        e.Graphics.DrawString("КАТАЛОГ КНИГ", titleFont, textBrush, new System.Drawing.PointF(20, 20));
                    }

                    using (var linePen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 120, 212), 4))
                    {
                        e.Graphics.DrawLine(linePen, 0, 80, this.Width, 80);
                    }
                };
            }
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM books";

                    SqliteCommand command = new SqliteCommand(query, connection);

                    DataTable dataTable = new DataTable();

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе: " + ex.Message);
                }
            }
        }
    }
}