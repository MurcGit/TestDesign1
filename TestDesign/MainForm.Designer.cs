namespace TestDesign
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizeBut = new System.Windows.Forms.Button();
            this.closeBut = new System.Windows.Forms.Button();
            this.maximizeBut = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highLightPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.linePanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.jobButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.workPictureBox = new System.Windows.Forms.PictureBox();
            this.treeBtn = new System.Windows.Forms.Button();
            this.rebLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workPictureBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.minimizeBut);
            this.panel5.Controls.Add(this.closeBut);
            this.panel5.Controls.Add(this.maximizeBut);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(852, 32);
            this.panel5.TabIndex = 3;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(11, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "        Rebuilder - Concept";
            // 
            // minimizeBut
            // 
            this.minimizeBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBut.FlatAppearance.BorderSize = 0;
            this.minimizeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBut.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBut.Image")));
            this.minimizeBut.Location = new System.Drawing.Point(738, 0);
            this.minimizeBut.Name = "minimizeBut";
            this.minimizeBut.Size = new System.Drawing.Size(38, 32);
            this.minimizeBut.TabIndex = 7;
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
            this.closeBut.Location = new System.Drawing.Point(814, 0);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(38, 32);
            this.closeBut.TabIndex = 5;
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // maximizeBut
            // 
            this.maximizeBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBut.FlatAppearance.BorderSize = 0;
            this.maximizeBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.maximizeBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.maximizeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBut.Image = ((System.Drawing.Image)(resources.GetObject("maximizeBut.Image")));
            this.maximizeBut.Location = new System.Drawing.Point(776, 0);
            this.maximizeBut.Name = "maximizeBut";
            this.maximizeBut.Size = new System.Drawing.Size(38, 32);
            this.maximizeBut.TabIndex = 6;
            this.maximizeBut.UseVisualStyleBackColor = true;
            this.maximizeBut.Click += new System.EventHandler(this.maximizeBut_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(652, 509);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.highLightPanel);
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Controls.Add(this.linePanel);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Controls.Add(this.jobButton);
            this.menuPanel.Controls.Add(this.indexButton);
            this.menuPanel.Controls.Add(this.workPictureBox);
            this.menuPanel.Controls.Add(this.treeBtn);
            this.menuPanel.Controls.Add(this.rebLabel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 32);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(181, 528);
            this.menuPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 528);
            this.panel1.TabIndex = 12;
            // 
            // highLightPanel
            // 
            this.highLightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.highLightPanel.Location = new System.Drawing.Point(0, 89);
            this.highLightPanel.Name = "highLightPanel";
            this.highLightPanel.Size = new System.Drawing.Size(4, 43);
            this.highLightPanel.TabIndex = 11;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 440);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(180, 43);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "      Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 89);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(180, 43);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "      Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(138, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(42, 32);
            this.menuButton.TabIndex = 10;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.linePanel.Location = new System.Drawing.Point(10, 433);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(161, 1);
            this.linePanel.TabIndex = 5;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 483);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 43);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "      LogOut";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // jobButton
            // 
            this.jobButton.FlatAppearance.BorderSize = 0;
            this.jobButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.jobButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobButton.ForeColor = System.Drawing.Color.White;
            this.jobButton.Image = ((System.Drawing.Image)(resources.GetObject("jobButton.Image")));
            this.jobButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobButton.Location = new System.Drawing.Point(0, 218);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(180, 43);
            this.jobButton.TabIndex = 8;
            this.jobButton.Text = "      Job Monitor";
            this.jobButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.Click += new System.EventHandler(this.jobButton_Click);
            // 
            // indexButton
            // 
            this.indexButton.FlatAppearance.BorderSize = 0;
            this.indexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.indexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.indexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexButton.ForeColor = System.Drawing.Color.White;
            this.indexButton.Image = ((System.Drawing.Image)(resources.GetObject("indexButton.Image")));
            this.indexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.indexButton.Location = new System.Drawing.Point(0, 175);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(180, 43);
            this.indexButton.TabIndex = 7;
            this.indexButton.Text = "      Index Rebuild";
            this.indexButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.indexButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // workPictureBox
            // 
            this.workPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("workPictureBox.Image")));
            this.workPictureBox.Location = new System.Drawing.Point(115, 33);
            this.workPictureBox.Name = "workPictureBox";
            this.workPictureBox.Size = new System.Drawing.Size(32, 32);
            this.workPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.workPictureBox.TabIndex = 6;
            this.workPictureBox.TabStop = false;
            // 
            // treeBtn
            // 
            this.treeBtn.FlatAppearance.BorderSize = 0;
            this.treeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.treeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.treeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treeBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeBtn.ForeColor = System.Drawing.Color.White;
            this.treeBtn.Image = ((System.Drawing.Image)(resources.GetObject("treeBtn.Image")));
            this.treeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.treeBtn.Location = new System.Drawing.Point(0, 132);
            this.treeBtn.Name = "treeBtn";
            this.treeBtn.Size = new System.Drawing.Size(180, 43);
            this.treeBtn.TabIndex = 5;
            this.treeBtn.Text = "      Tree Rebuild";
            this.treeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.treeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.treeBtn.UseVisualStyleBackColor = true;
            this.treeBtn.Click += new System.EventHandler(this.treeBtn_Click);
            // 
            // rebLabel
            // 
            this.rebLabel.AutoSize = true;
            this.rebLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebLabel.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rebLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.rebLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rebLabel.Location = new System.Drawing.Point(30, 37);
            this.rebLabel.Name = "rebLabel";
            this.rebLabel.Size = new System.Drawing.Size(95, 33);
            this.rebLabel.TabIndex = 5;
            this.rebLabel.Text = "Rebuilder";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(181, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(671, 528);
            this.panel6.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(852, 560);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workPictureBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button maximizeBut;
        private System.Windows.Forms.Button minimizeBut;
        private System.Windows.Forms.Label rebLabel;
        private System.Windows.Forms.Button treeBtn;
        private System.Windows.Forms.PictureBox workPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jobButton;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel highLightPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

