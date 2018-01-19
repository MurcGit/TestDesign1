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
    public partial class FindTreeForm : Form
    {
        private bool dragging = false;
        private int mValX = 0;
        private int mValY = 0;

        private static FindTreeForm _findTree;
        public static FindTreeForm FindTree
        {
            get
            {
                if (_findTree == null)
                {
                    _findTree = new FindTreeForm();
                }
                return _findTree;
            }
        }

        public FindTreeForm()
        {
            InitializeComponent();
        }

                    // события \\
        // 1. Перемещение формы 
        private void MinCloPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.mValX = e.X;
            this.mValY = e.Y;
        }

        private void MinCloPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MinCloPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                SetDesktopLocation(MousePosition.X - this.mValX, MousePosition.Y - mValY);
            }
        }

        // 2. При нажатии на Enter вызывается метод FindNodeMet, который вызывает событие нажатия на кнопку поиска
        #region На Enter поиск
        private void identTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void valueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void ident2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void value2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void identAddTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void valueAddTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }

        private void idAddTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.FindNodeMet(sender, e);
        }
        #endregion

        // 3. Удаление watermark при изменении в текстбоксе \\
        #region Удаление дефолтных значений из ТекстБоксов

        private void identTextBox_TextChanged(object sender, EventArgs e)
        {
            if(identTextBox.Text.Trim() == "")
            {
                identTextBox.Text = identTextBox.Text.Trim();
                identPctBox.Show();
                delButton1.Hide();
            }
            else
            {
                identPctBox.Hide();
                delButton1.Show();
            }
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (valueTextBox.Text.Trim() == "")
            {
                valueTextBox.Text = valueTextBox.Text.Trim();
                valuePctBox.Show();
                delButton2.Hide();
            }
            else
            {
                valuePctBox.Hide();
                delButton2.Show();
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idTextBox.Text.Trim() == "")
            {
                idTextBox.Text = idTextBox.Text.Trim();
                idPctBox.Show();
                delButton3.Hide();
            }
            else
            {
                idPctBox.Hide();
                delButton3.Show();
            }
        }

        private void ident2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ident2TextBox.Text.Trim() == "")
            {
                ident2TextBox.Text = ident2TextBox.Text.Trim();
                ident2PctBox.Show();
                delButton4.Hide();
            }
            else
            {
                ident2PctBox.Hide();
                delButton4.Show();
            }
        }

        private void value2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (value2TextBox.Text.Trim() == "")
            {
                value2TextBox.Text = value2TextBox.Text.Trim();
                value2PctBox.Show();
                delButton5.Hide();
            }
            else
            {
                value2PctBox.Hide();
                delButton5.Show();
            }
        }

        private void identAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (identAddTextBox.Text.Trim() == "")
            {
                identAddTextBox.Text = identAddTextBox.Text.Trim();
                identAddPctBox.Show();
                delButton6.Hide();
            }
            else
            {
                identAddPctBox.Hide();
                delButton6.Show();
            }
        }

        private void valueAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (valueAddTextBox.Text.Trim() == "")
            {
                valueAddTextBox.Text = valueAddTextBox.Text.Trim();
                valueAddPctBox.Show();
                delButton7.Hide();
            }
            else
            {
                valueAddPctBox.Hide();
                delButton7.Show();
            }
        }

        private void idAddTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idAddTextBox.Text.Trim() == "")
            {
                idAddTextBox.Text = idAddTextBox.Text.Trim();
                idAddPctBox.Show();
                delButton8.Hide();
            }
            else
            {
                idAddPctBox.Hide();
                delButton8.Show();
            }
        }
        #endregion

        // 4. При клике на Picterbox(ident,value,id) установка фокуса на текстбокс \\
        #region установка фокуса на текстбокс
        private void identPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            identTextBox.Focus();
        }

        private void valuePctBox_MouseClick(object sender, MouseEventArgs e)
        {
            valueTextBox.Focus();
        }

        private void idPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Focus();
        }

        private void ident2PctBox_MouseClick(object sender, MouseEventArgs e)
        {
            ident2TextBox.Focus();
        }

        private void value2PctBox_MouseClick(object sender, MouseEventArgs e)
        {
            value2TextBox.Focus();
        }

        private void identAddPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            identAddTextBox.Focus();
        }

        private void valueAddPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            valueAddTextBox.Focus();
        }

        private void idAddPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            idAddTextBox.Focus();
        }
        #endregion

        // 5. Удаление текста в тексбоксе при нажатии на кнопку удалить(крестик)
        #region Удаление текста в тексбоксе при нажатии на кнопку удалить(крестик)
        private void delButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.identTextBox.Text = "";
            this.identTextBox.Focus();
        }

        private void delButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.valueTextBox.Text = "";
            this.valueTextBox.Focus();
        }

        private void delButton3_MouseClick(object sender, MouseEventArgs e)
        {
            this.idTextBox.Text = "";
            this.idTextBox.Focus();
        }

        private void delButton4_MouseClick(object sender, MouseEventArgs e)
        {
            this.ident2TextBox.Text = "";
            this.ident2TextBox.Focus();
        }

        private void delButton5_MouseClick(object sender, MouseEventArgs e)
        {
            this.value2TextBox.Text = "";
            this.value2TextBox.Focus();
        }

        private void delButton6_MouseClick(object sender, MouseEventArgs e)
        {
            this.identAddTextBox.Text = "";
            this.identAddTextBox.Focus();
        }

        private void delButton7_MouseClick(object sender, MouseEventArgs e)
        {
            this.valueAddTextBox.Text = "";
            this.valueAddTextBox.Focus();
        }

        private void delButton8_MouseClick(object sender, MouseEventArgs e)
        {
            this.idAddTextBox.Text = "";
            this.idAddTextBox.Focus();
        }
        #endregion

                    // кнопки \\
        // 1. Закрыть
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Hide();    //this.Close();
            this.CenterToScreen();
        }

        // 2. Свернуть
        private void minimizeBut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        // 3. Очистить всё
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            this.identTextBox.Text = "";
            this.valueTextBox.Text = "";
            this.idTextBox.Text = "";
            this.identTextBox.Focus();

            this.ident2TextBox.Text = "";
            this.value2TextBox.Text = "";

            this.identAddTextBox.Text = "";
            this.valueAddTextBox.Text = "";
            this.idAddTextBox.Text = "";
        }

        // 4. Найти узел
        private void findNodeButton_Click(object sender, EventArgs e)
        {
            if (TreeReb.OutPutTree(this.IfEmpty()))
            {
                this.Hide();    //this.Close();
                this.CenterToScreen();
            }
        }

                // методы \\
        // 1. Замена дефолтных значений на пустоту
        private string[] IfEmpty()
        {
            string[] ArrValue = new string[8] { valueTextBox.Text.Trim(), identTextBox.Text.Trim(), idTextBox.Text.Trim(),
                                                ident2TextBox.Text.Trim(), value2TextBox.Text.Trim(),
                                                identAddTextBox.Text.Trim(), valueAddTextBox.Text.Trim(), idAddTextBox.Text.Trim() };
            return ArrValue;
        }

        // 2. При нажатии на Enter вызывается событие нажатия на кнопку поиска
        private void FindNodeMet(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Enter)
            {
                findNodeButton_Click(sender, key);
            }
        }

    }
}
