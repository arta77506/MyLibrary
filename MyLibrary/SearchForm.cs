using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MyLibrary
{
    public partial class SearchForm : Form
    {
        private string connectionString = @"Data Source=C:\Projects\library_system";

        public SearchForm()
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
            }
            this.BackColor = System.Drawing.Color.White;

            var grid = this.Controls.OfType<DataGridView>().FirstOrDefault();
            if (grid != null)
            {
                grid.Top = 130; 
                grid.Height = this.ClientSize.Height - 150;
                grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }


            var txtSearch = this.Controls.OfType<TextBox>().FirstOrDefault();
            if (txtSearch != null)
            {
                txtSearch.Top = 75;
                txtSearch.Left = 20;
                txtSearch.Width = 300;
            }

            this.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


                using (var topBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(244, 246, 249)))
                {
                    e.Graphics.FillRectangle(topBrush, 0, 0, this.Width, 120);
                }


                using (var waterPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(235, 238, 242), 15)) 
                {

                    e.Graphics.DrawEllipse(waterPen, this.Width - 250, 60, 180, 180);

                    e.Graphics.DrawLine(waterPen, this.Width - 110, 210, this.Width - 30, 310);
                }


                using (var font = new System.Drawing.Font("Segoe UI Black", 26))
                using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(41, 57, 85)))
                {
                    e.Graphics.DrawString("ПОИСК ПО ФОНДУ", font, brush, new System.Drawing.PointF(15, 15));
                }


                using (var dotBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 87, 34)))
                using (var dotBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 150, 136)))
                using (var dotBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 120, 212))) 
                {
                    e.Graphics.FillEllipse(dotBrush1, 20, 60, 6, 6);
                    e.Graphics.FillEllipse(dotBrush2, 32, 60, 6, 6);
                    e.Graphics.FillEllipse(dotBrush3, 44, 60, 6, 6);
                }

                using (var linePen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(220, 225, 230), 2))
                {
                    e.Graphics.DrawLine(linePen, 0, 120, this.Width, 120);
                }
            };
            var btnFind = this.Controls.OfType<Button>().FirstOrDefault();
            if (btnFind != null)
            {
                btnFind.Top = 73; 
                btnFind.Left = 330; 
                btnFind.Width = 120;
                btnFind.Height = 28; 


                btnFind.FlatStyle = FlatStyle.Flat;
                btnFind.FlatAppearance.BorderSize = 0;
                btnFind.BackColor = System.Drawing.Color.FromArgb(0, 120, 212); 
                btnFind.ForeColor = System.Drawing.Color.White;
                btnFind.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btnFind.Cursor = Cursors.Hand;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            string query = @"SELECT * FROM books 
                             WHERE title LIKE @q OR author LIKE @q";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@q", "%" + keyword + "%");

                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    dgvResults.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Ничего не найдено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка поиска: " + ex.Message);
                }
            }
        }
    }
}