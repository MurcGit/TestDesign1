namespace TestDesign
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.MinCloPanel = new System.Windows.Forms.Panel();
            this.minimizeBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.privatePicBox = new System.Windows.Forms.PictureBox();
            this.checkBoxButton = new System.Windows.Forms.Button();
            this.UserPctBox = new System.Windows.Forms.PictureBox();
            this.PasswordPctBox = new System.Windows.Forms.PictureBox();
            this.MinCloPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privatePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MinCloPanel
            // 
            this.MinCloPanel.Controls.Add(this.minimizeBut);
            this.MinCloPanel.Controls.Add(this.closeBut);
            this.MinCloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MinCloPanel.Location = new System.Drawing.Point(0, 0);
            this.MinCloPanel.Name = "MinCloPanel";
            this.MinCloPanel.Size = new System.Drawing.Size(339, 32);
            this.MinCloPanel.TabIndex = 6;
            this.MinCloPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinCloPanel_MouseDown);
            this.MinCloPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinCloPanel_MouseMove);
            this.MinCloPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinCloPanel_MouseUp);
            // 
            // minimizeBut
            // 
            this.minimizeBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBut.FlatAppearance.BorderSize = 0;
            this.minimizeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBut.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBut.Image")));
            this.minimizeBut.Location = new System.Drawing.Point(274, -1);
            this.minimizeBut.Name = "minimizeBut";
            this.minimizeBut.Size = new System.Drawing.Size(32, 45);
            this.minimizeBut.TabIndex = 5;
            this.minimizeBut.UseVisualStyleBackColor = true;
            this.minimizeBut.Click += new System.EventHandler(this.minimizeBut_Click);
            // 
            // closeBut
            // 
            this.closeBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBut.FlatAppearance.BorderSize = 0;
            this.closeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.closeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Image = ((System.Drawing.Image)(resources.GetObject("closeBut.Image")));
            this.closeBut.Location = new System.Drawing.Point(307, 0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(32, 32);
            this.closeBut.TabIndex = 4;
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 48);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ";
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(21, 119);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(296, 16);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            this.userTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox_KeyDown);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.ForeColor = System.Drawing.Color.White;
            this.passTextBox.Location = new System.Drawing.Point(21, 167);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(296, 16);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            this.passTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTextBox_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(242, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(21, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(21, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(21, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 1);
            this.panel5.TabIndex = 10;
            // 
            // privatePicBox
            // 
            this.privatePicBox.Image = ((System.Drawing.Image)(resources.GetObject("privatePicBox.Image")));
            this.privatePicBox.Location = new System.Drawing.Point(301, 169);
            this.privatePicBox.Name = "privatePicBox";
            this.privatePicBox.Size = new System.Drawing.Size(16, 16);
            this.privatePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.privatePicBox.TabIndex = 10;
            this.privatePicBox.TabStop = false;
            this.privatePicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.privatePicBox_MouseDown);
            this.privatePicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.privatePicBox_MouseUp);
            // 
            // checkBoxButton
            // 
            this.checkBoxButton.FlatAppearance.BorderSize = 0;
            this.checkBoxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkBoxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxButton.ForeColor = System.Drawing.Color.White;
            this.checkBoxButton.Image = global::TestDesign.Properties.Resources.unchecked_16;
            this.checkBoxButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxButton.Location = new System.Drawing.Point(15, 202);
            this.checkBoxButton.Name = "checkBoxButton";
            this.checkBoxButton.Size = new System.Drawing.Size(115, 23);
            this.checkBoxButton.TabIndex = 2;
            this.checkBoxButton.Text = "Remember me";
            this.checkBoxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxButton.UseVisualStyleBackColor = true;
            this.checkBoxButton.Click += new System.EventHandler(this.checkBoxButton_Click);
            // 
            // UserPctBox
            // 
            this.UserPctBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPctBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPctBox.Image")));
            this.UserPctBox.Location = new System.Drawing.Point(22, 120);
            this.UserPctBox.Name = "UserPctBox";
            this.UserPctBox.Size = new System.Drawing.Size(65, 15);
            this.UserPctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UserPctBox.TabIndex = 12;
            this.UserPctBox.TabStop = false;
            this.UserPctBox.Click += new System.EventHandler(this.UserPctBox_Click);
            // 
            // PasswordPctBox
            // 
            this.PasswordPctBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordPctBox.Image = ((System.Drawing.Image)(resources.GetObject("PasswordPctBox.Image")));
            this.PasswordPctBox.Location = new System.Drawing.Point(22, 168);
            this.PasswordPctBox.Name = "PasswordPctBox";
            this.PasswordPctBox.Size = new System.Drawing.Size(63, 15);
            this.PasswordPctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PasswordPctBox.TabIndex = 13;
            this.PasswordPctBox.TabStop = false;
            this.PasswordPctBox.Click += new System.EventHandler(this.PasswordPctBox_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(339, 350);
            this.Controls.Add(this.PasswordPctBox);
            this.Controls.Add(this.UserPctBox);
            this.Controls.Add(this.checkBoxButton);
            this.Controls.Add(this.privatePicBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MinCloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.MinCloPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privatePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MinCloPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button minimizeBut;
        private System.Windows.Forms.PictureBox privatePicBox;
        private System.Windows.Forms.Button checkBoxButton;
        private System.Windows.Forms.PictureBox UserPctBox;
        private System.Windows.Forms.PictureBox PasswordPctBox;
    }
}