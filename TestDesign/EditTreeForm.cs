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
    public partial class EditTreeForm : Form
    {
        // переменные для реализации перемещения формы
        private bool dragging = false;
        private int mValX = 0, mValY = 0;

        // реализация свойства для обращения к форме из других форм
        private static EditTreeForm _editTree;
        public static EditTreeForm EditTree
        {
            get
            {
                if (_editTree == null)
                {
                    _editTree = new EditTreeForm();
                }
                return _editTree;
            }
        }

        // конструктор \\
        public EditTreeForm()
        {
            InitializeComponent(); 
        }

        // кнопки \\
        // 1. закрыть
        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }

        // 2. свернуть
        private void minimizeBut_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // 3. очистить все поля
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            this.idTextBox.Text = "";
            this.parentIdTextBox.Text = "";
            this.valueTextBox.Text = "";
            this.identTextBox.Text = "";
            this.levelTextBox.Text = "";
        }

        // 4. отмена
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
        }

        // 5. сохранить
        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        // события \\
        // 1. перемещение формы
        private void minClosePanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.mValX = e.X;
            this.mValY = e.Y;
        }

        private void minClosePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                this.SetDesktopLocation(MousePosition.X - this.mValX, MousePosition.Y - mValY);
            }
        }

        private void minClosePanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        // 2. Удаление watermark при изменении в текстбоксе \\
        #region Удаление дефолтных значений из ТекстБоксов
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idTextBox.Text.Trim() == "")
            {
                idTextBox.Text = idTextBox.Text.Trim();
                idPctBox.Show();
                delButton1.Hide();
            }
            else
            {
                idPctBox.Hide();
                delButton1.Show();
            }
        }

        private void parentIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (parentIdTextBox.Text.Trim() == "")
            {
                parentIdTextBox.Text = parentIdTextBox.Text.Trim();
                parentPctBox.Show();
                delButton2.Hide();
            }
            else
            {
                parentPctBox.Hide();
                delButton2.Show();
            }
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (valueTextBox.Text.Trim() == "")
            {
                valueTextBox.Text = valueTextBox.Text.Trim();
                valuePctBox.Show();
                delButton3.Hide();
            }
            else
            {
                valuePctBox.Hide();
                delButton3.Show();
            }
        }

        private void identTextBox_TextChanged(object sender, EventArgs e)
        {
            if (identTextBox.Text.Trim() == "")
            {
                identTextBox.Text = identTextBox.Text.Trim();
                identPctBox.Show();
                delButton4.Hide();
            }
            else
            {
                identPctBox.Hide();
                delButton4.Show();
            }
        }

        private void levelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (levelTextBox.Text.Trim() == "")
            {
                levelTextBox.Text = levelTextBox.Text.Trim();
                lvlPctBox.Show();
                delButton5.Hide();
            }
            else
            {
                lvlPctBox.Hide();
                delButton5.Show();
            }
        }
        #endregion

        // 3. При клике на Picterbox(ident,value,id) установка фокуса на текстбокс \\
        #region установка фокуса на текстбокс
        private void idPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Focus();
        }

        private void parentPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            parentIdTextBox.Focus();
        }

        private void valuePctBox_MouseClick(object sender, MouseEventArgs e)
        {
            valueTextBox.Focus();
        }

        private void identPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            identTextBox.Focus();
        }

        private void lvlPctBox_MouseClick(object sender, MouseEventArgs e)
        {
            levelTextBox.Focus();
        }
        #endregion

        // 4. Удаление текста в тексбоксе при нажатии на кнопку удалить(крестик)
        #region Удаление текста в тексбоксе при нажатии на кнопку удалить(крестик)
        private void delButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.idTextBox.Text = "";
            this.idTextBox.Focus();
        }

        private void delButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.parentIdTextBox.Text = "";
            this.parentIdTextBox.Focus();
        }

        private void delButton3_MouseClick(object sender, MouseEventArgs e)
        {
            this.valueTextBox.Text = "";
            this.valueTextBox.Focus();
        }

        private void delButton4_MouseClick(object sender, MouseEventArgs e)
        {
            this.identTextBox.Text = "";
            this.identTextBox.Focus();
        }

        private void delButton5_MouseClick(object sender, MouseEventArgs e)
        {
            this.levelTextBox.Text = "";
            this.levelTextBox.Focus();
        }
        #endregion
    }
}
