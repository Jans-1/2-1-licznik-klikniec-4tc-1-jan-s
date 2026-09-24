using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clicker
{
    public class MainForm : Form
    {
        private int clickCount = 0;
        private Label lblCount;
        private Button btnClick;
        private Button btnReset;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ── Window settings ──
            this.Text = "Clicker";
            this.Size = new Size(350, 280);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── Click-count label ──
            lblCount = new Label
            {
                Text = "0",
                Font = new Font("Segoe UI", 48, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 120
            };

            // ── Click button ──
            btnClick = new Button
            {
                Text = "Kliknij mnie!",
                Font = new Font("Segoe UI", 14),
                Size = new Size(200, 50),
                Location = new Point(70, 130),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnClick.FlatAppearance.BorderSize = 0;
            btnClick.Click += BtnClick_Click;

            // ── Reset button ──
            btnReset = new Button
            {
                Text = "Zeruj",
                Font = new Font("Segoe UI", 11),
                Size = new Size(200, 40),
                Location = new Point(70, 190),
                BackColor = Color.FromArgb(200, 50, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Click += BtnReset_Click;

            // ── Add controls ──
            this.Controls.Add(lblCount);
            this.Controls.Add(btnClick);
            this.Controls.Add(btnReset);
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            clickCount++;
            lblCount.Text = clickCount.ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            clickCount = 0;
            lblCount.Text = "0";
        }
    }
}
