using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesign
{
    public partial class mainForm : Form
    {
        private bool dragging = false;
        private int mValX = 0, mValY = 0;

        public mainForm()
        {
            InitializeComponent();

            this.panel6.Controls.Add(main.MainSection);
            main.MainSection.Dock = DockStyle.Fill;
            main.MainSection.BringToFront();
            this.homeButton.BackColor = Color.FromArgb(37, 46, 59); //Color.FromArgb(0, 102, 204); 
            this.highLightPanel.Location = this.homeButton.Location;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 181)
            {
                menuPanel.Width = 42;
                rebLabel.Visible = false;
                linePanel.Width = 22;
                menuButton.Location = new Point(0, 0);
                workPictureBox.Location = new Point(5, 45); //115; 33  -- 3; 37
            }
            else
            {
                menuPanel.Width = 181;
                rebLabel.Visible = true;
                linePanel.Width = 161;
                menuButton.Location = new Point(138, 0); //138; 2
                workPictureBox.Location = new Point(115, 33);
            }
        }
        // Кнопки close, maximize, minimize
        private void closeBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizeBut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        // перемещение формы по экрану
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.mValX = e.X;
            this.mValY = e.Y;
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                this.SetDesktopLocation(MousePosition.X - this.mValX, MousePosition.Y - this.mValY);
            }
        }

        // отображение разделов по нажатию на кнопку
        private void homeButton_Click_1(object sender, EventArgs e)
        {
            main.MainSection.BringToFront();
            this.ColorBtnChange();
            //homeButton.BackColor = Color.FromArgb(0, 102, 204);
            this.homeButton.BackColor = Color.FromArgb(37, 46, 59); 
            this.highLightPanel.Location = this.homeButton.Location;
            this.homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        private void treeBtn_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(TreeReb.TreeRebuild))
            {
                this.panel6.Controls.Add(TreeReb.TreeRebuild);
                TreeReb.TreeRebuild.Dock = DockStyle.Fill;
                TreeReb.TreeRebuild.BringToFront();
            }
            else
            {
                TreeReb.TreeRebuild.BringToFront();
            }

            this.ColorBtnChange();
            //treeBtn.BackColor = Color.FromArgb(0, 102, 204);
            this.treeBtn.BackColor = Color.FromArgb(37, 46, 59);
            this.highLightPanel.Location = this.treeBtn.Location;
            this.treeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        private void indexButton_Click(object sender, EventArgs e)
        {
            this.ColorBtnChange();
            //indexButton.BackColor = Color.FromArgb(0, 102, 204);
            this.indexButton.BackColor = Color.FromArgb(37, 46, 59);
            this.highLightPanel.Location = this.indexButton.Location;
            this.indexButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        private void jobButton_Click(object sender, EventArgs e)
        {
            this.ColorBtnChange();
            //jobButton.BackColor = Color.FromArgb(0, 102, 204);
            this.jobButton.BackColor = Color.FromArgb(37, 46, 59);
            this.highLightPanel.Location = this.jobButton.Location;
            this.jobButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.ColorBtnChange();
            //settingsButton.BackColor = Color.FromArgb(0, 102, 204);
            this.settingsButton.BackColor = Color.FromArgb(37, 46, 59);
            this.highLightPanel.Location = this.settingsButton.Location;
            this.settingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.ColorBtnChange();
            //logoutButton.BackColor = Color.FromArgb(0, 102, 204);
            this.logoutButton.BackColor = Color.FromArgb(37, 46, 59);
            this.highLightPanel.Location = this.logoutButton.Location;
            this.logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 46, 59);
        }

        // Методы
        // 1. изменение цвета кнопки (выделение разделов)
        private void ColorBtnChange()
        {
            this.homeButton.BackColor = Color.FromArgb(26, 32, 40);
            this.homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);

            this.treeBtn.BackColor = Color.FromArgb(26, 32, 40);
            this.treeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);

            this.indexButton.BackColor = Color.FromArgb(26, 32, 40);
            this.indexButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);

            this.jobButton.BackColor = Color.FromArgb(26, 32, 40);
            this.jobButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);

            this.settingsButton.BackColor = Color.FromArgb(26, 32, 40);
            this.settingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);

            this.logoutButton.BackColor = Color.FromArgb(26, 32, 40);
            this.logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);
        }
    }
}
