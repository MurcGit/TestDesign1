using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace TestDesign
{
    public partial class LogIn : Form
    {
        private const string conString = @"Server=virt30; Initial Catalog=ForAnalysts; Integrated Security=True; Pooling=True; Connection Timeout=60;";
        private const string sqlQuery = @"Select Username, UserPassword from prs.UserLoginTest";
        private List<UserLogin> userLog;

        private bool draging = false;
        private int mValX = 0, mValY = 0;

        public LogIn()
        {
            InitializeComponent();

            this.userLog = UserLogCol(); //заполнение листа логинами и паролями

            if (Properties.Settings.Default.CheckBox == "unchecked")
            {
                checkBoxButton.Image = Properties.Resources.unchecked_16;
            }
            else
            {
                checkBoxButton.Image = Properties.Resources.checked_16;

                userTextBox.Text = Properties.Settings.Default.Username;
                passTextBox.Text = Properties.Settings.Default.Password;
            }
        }

                    // методы \\
        // 1. заполнения коллекции логинов
        [SqlFunction(DataAccess = DataAccessKind.Read, SystemDataAccess = SystemDataAccessKind.Read)]
        private static List<UserLogin> UserLogCol()
        {
            List<UserLogin> user = new List<UserLogin>();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    user.Add(new UserLogin() { UserName = reader.GetString(0), UserPassword = reader.GetString(1) });
                                }
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex) { }
            return user;
        }

        // 2. логирования для события при нажатии на кнопку Enter
        private void EnterCode(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, key);
            }
        }

        // 3. логирование
        private void Login()
        {
            string username = this.userTextBox.Text.Trim();
            string password = this.passTextBox.Text.Trim();

            if (this.userLog.Exists(x => x.UserName == username && x.UserPassword == password))
            {
                mainForm mainForm = new mainForm();
                this.SettingsSaver();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
        }

        // 4. сохранение логина и пароля, если чекбокс отмечен
        private void SettingsSaver()
        {
            if (Properties.Settings.Default.CheckBox == "checked")
            {
                Properties.Settings.Default.Username = userTextBox.Text.Trim();
                Properties.Settings.Default.Password = passTextBox.Text.Trim();
                Properties.Settings.Default.Save();
            }
        }

                    // события \\
        // 1. реализация close, minimize
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        // 2. вход по кнопке Login
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        // 3. перемещение формы по экрану
        private void MinCloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.draging = true;
            this.mValX = e.X;
            this.mValY = e.Y;
        }

        private void MinCloPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.draging = false;
        }

        private void MinCloPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                SetDesktopLocation(MousePosition.X - this.mValX, MousePosition.Y - this.mValY);
            }
        }

        // 4. Выполнение Login при нажатии на Enter 
        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.EnterCode(sender, e);
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.EnterCode(sender, e);
        }

        // 5. просмотр скрытого пароля
        private void privatePicBox_MouseDown(object sender, MouseEventArgs e)
        {
            passTextBox.UseSystemPasswordChar = false;
        }

        private void privatePicBox_MouseUp(object sender, MouseEventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
        }

        // 6. свой чекбокс
        private void checkBoxButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckBox == "unchecked")
            {
                checkBoxButton.Image = Properties.Resources.checked_16;
                Properties.Settings.Default.CheckBox = "checked";

                //this.SettingsSaver();    
            }
            else
            {
                checkBoxButton.Image = Properties.Resources.unchecked_16;
                Properties.Settings.Default.CheckBox = "unchecked";
                Properties.Settings.Default.Save();
            }
        }

        // 7. watermark - автоматическое удаление picterbox (Username/Password), при изменении значения текстбокса
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userTextBox.Text.Trim() == "")
            {
                userTextBox.Text = userTextBox.Text.Trim();
                UserPctBox.Show();
            }
            else
            {
                UserPctBox.Hide();
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if(passTextBox.Text == "")
            {
                PasswordPctBox.Show();
            }
            else
            {
                PasswordPctBox.Hide();
            }
        }

        // 8. при клике на picterBox Username/Password активация TextBoX
        private void UserPctBox_Click(object sender, EventArgs e)
        {
            userTextBox.Focus();
        }

        private void PasswordPctBox_Click(object sender, EventArgs e)
        {
            passTextBox.Focus();
        }
    }
}
