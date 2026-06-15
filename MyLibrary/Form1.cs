using System;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            foreach (Control panel in this.Controls)
            {
                if (panel is Panel p && p.Dock == DockStyle.Left)
                {
                    p.BackColor = System.Drawing.Color.FromArgb(30, 30, 30); 

                    foreach (Control btnCtrl in p.Controls)
                    {
                        if (btnCtrl is Button menuBtn)
                        {
                            menuBtn.FlatStyle = FlatStyle.Flat;
                            menuBtn.FlatAppearance.BorderSize = 0;
                            menuBtn.BackColor = System.Drawing.Color.Transparent;
                            menuBtn.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
                            menuBtn.Font = new System.Drawing.Font("Segoe UI", 11);
                            menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                            menuBtn.Padding = new Padding(15, 0, 0, 0);
                            menuBtn.Cursor = Cursors.Hand;

                            // Эффект выделения при наведении мыши
                            menuBtn.MouseEnter += (s, e) => {
                                menuBtn.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                                menuBtn.ForeColor = System.Drawing.Color.White;
                            };
                            menuBtn.MouseLeave += (s, e) => {
                                menuBtn.BackColor = System.Drawing.Color.Transparent;
                                menuBtn.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
                            };
                        }
                    }
                }
            }
            this.BackColor = System.Drawing.Color.FromArgb(18, 22, 33); 

            this.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (var gridPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(30, 35, 50), 1))
                {
                    for (int i = 0; i < this.Width; i += 40) e.Graphics.DrawLine(gridPen, i, 0, i, this.Height);
                    for (int j = 0; j < this.Height; j += 40) e.Graphics.DrawLine(gridPen, 0, j, this.Width, j);
                }

                using (var glowBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(15, 0, 120, 212))) 
                {
                    e.Graphics.FillEllipse(glowBrush, this.Width - 200, -100, 400, 400);
                }

                using (var glowBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(10, 255, 140, 0))) 
                {
                    e.Graphics.FillEllipse(glowBrush2, this.Width - 300, 100, 200, 200);
                }


                using (var accentPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 140, 0), 4))
                {
                    e.Graphics.DrawLine(accentPen, 0, 0, 150, 0);
                }

                using (var titleFont = new System.Drawing.Font("Segoe UI Black", 32, System.Drawing.FontStyle.Bold))
                using (var titleBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                {

                    e.Graphics.DrawString("Добро пожаловать в Nexbib!", titleFont, titleBrush, new System.Drawing.PointF(40, 40));
                }


                using (var subFont = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Regular))
                using (var subBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(150, 170, 190))) 
                {
                    e.Graphics.DrawString("Умная система управления библиотечным фондом", subFont, subBrush, new System.Drawing.PointF(45, 95));
                }
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CatalogForm catalog = new CatalogForm();
            catalog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRecordForm addRecord = new AddRecordForm();
            addRecord.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatisticsForm stats = new StatisticsForm();
            stats.ShowDialog();
        }
    }
}