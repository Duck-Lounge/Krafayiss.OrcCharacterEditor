namespace OrcCharacterEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.radioMage = new System.Windows.Forms.RadioButton();
            this.radioArcher = new System.Windows.Forms.RadioButton();
            this.radioWarrior = new System.Windows.Forms.RadioButton();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblChaValue = new System.Windows.Forms.Label();
            this.lblIntValue = new System.Windows.Forms.Label();
            this.lblAgiValue = new System.Windows.Forms.Label();
            this.lblStrValue = new System.Windows.Forms.Label();
            this.trackBarCha = new System.Windows.Forms.TrackBar();
            this.trackBarInt = new System.Windows.Forms.TrackBar();
            this.trackBarAgi = new System.Windows.Forms.TrackBar();
            this.trackBarStr = new System.Windows.Forms.TrackBar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.panelLeft.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxClass.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStr)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.groupBoxGender);
            this.panelLeft.Controls.Add(this.groupBoxClass);
            this.panelLeft.Controls.Add(this.groupBoxStats);
            this.panelLeft.Location = new System.Drawing.Point(12, 12);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(420, 744);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGender.Controls.Add(this.radioFemale);
            this.groupBoxGender.Controls.Add(this.radioMale);
            this.groupBoxGender.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(414, 80);
            this.groupBoxGender.TabIndex = 0;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол персонажа";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(150, 34);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(84, 24);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.Text = "Женский";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(20, 34);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(96, 24);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Мужской";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.Gender_CheckedChanged);
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClass.Controls.Add(this.radioMage);
            this.groupBoxClass.Controls.Add(this.radioArcher);
            this.groupBoxClass.Controls.Add(this.radioWarrior);
            this.groupBoxClass.Location = new System.Drawing.Point(3, 89);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Size = new System.Drawing.Size(414, 110);
            this.groupBoxClass.TabIndex = 1;
            this.groupBoxClass.TabStop = false;
            this.groupBoxClass.Text = "Класс персонажа";
            // 
            // radioMage
            // 
            this.radioMage.AutoSize = true;
            this.radioMage.Location = new System.Drawing.Point(280, 47);
            this.radioMage.Name = "radioMage";
            this.radioMage.Size = new System.Drawing.Size(64, 24);
            this.radioMage.TabIndex = 2;
            this.radioMage.Text = "Маг";
            this.radioMage.UseVisualStyleBackColor = true;
            this.radioMage.CheckedChanged += new System.EventHandler(this.Class_CheckedChanged);
            // 
            // radioArcher
            // 
            this.radioArcher.AutoSize = true;
            this.radioArcher.Location = new System.Drawing.Point(150, 47);
            this.radioArcher.Name = "radioArcher";
            this.radioArcher.Size = new System.Drawing.Size(86, 24);
            this.radioArcher.TabIndex = 1;
            this.radioArcher.Text = "Лучник";
            this.radioArcher.UseVisualStyleBackColor = true;
            this.radioArcher.CheckedChanged += new System.EventHandler(this.Class_CheckedChanged);
            // 
            // radioWarrior
            // 
            this.radioWarrior.AutoSize = true;
            this.radioWarrior.Checked = true;
            this.radioWarrior.Location = new System.Drawing.Point(20, 47);
            this.radioWarrior.Name = "radioWarrior";
            this.radioWarrior.Size = new System.Drawing.Size(86, 24);
            this.radioWarrior.TabIndex = 0;
            this.radioWarrior.TabStop = true;
            this.radioWarrior.Text = "Воин";
            this.radioWarrior.UseVisualStyleBackColor = true;
            this.radioWarrior.CheckedChanged += new System.EventHandler(this.Class_CheckedChanged);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStats.Controls.Add(this.lblChaValue);
            this.groupBoxStats.Controls.Add(this.lblIntValue);
            this.groupBoxStats.Controls.Add(this.lblAgiValue);
            this.groupBoxStats.Controls.Add(this.lblStrValue);
            this.groupBoxStats.Controls.Add(this.trackBarCha);
            this.groupBoxStats.Controls.Add(this.trackBarInt);
            this.groupBoxStats.Controls.Add(this.trackBarAgi);
            this.groupBoxStats.Controls.Add(this.trackBarStr);
            this.groupBoxStats.Location = new System.Drawing.Point(3, 206);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(414, 530);
            this.groupBoxStats.TabIndex = 2;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Характеристики (макс суммарно 200%)";
            // 
            // lblChaValue
            // 
            this.lblChaValue.AutoSize = true;
            this.lblChaValue.Location = new System.Drawing.Point(350, 430);
            this.lblChaValue.Name = "lblChaValue";
            this.lblChaValue.Size = new System.Drawing.Size(40, 20);
            this.lblChaValue.TabIndex = 7;
            this.lblChaValue.Text = "0%";
            // 
            // lblIntValue
            // 
            this.lblIntValue.AutoSize = true;
            this.lblIntValue.Location = new System.Drawing.Point(350, 300);
            this.lblIntValue.Name = "lblIntValue";
            this.lblIntValue.Size = new System.Drawing.Size(40, 20);
            this.lblIntValue.TabIndex = 6;
            this.lblIntValue.Text = "0%";
            // 
            // lblAgiValue
            // 
            this.lblAgiValue.AutoSize = true;
            this.lblAgiValue.Location = new System.Drawing.Point(350, 170);
            this.lblAgiValue.Name = "lblAgiValue";
            this.lblAgiValue.Size = new System.Drawing.Size(40, 20);
            this.lblAgiValue.TabIndex = 5;
            this.lblAgiValue.Text = "0%";
            // 
            // lblStrValue
            // 
            this.lblStrValue.AutoSize = true;
            this.lblStrValue.Location = new System.Drawing.Point(350, 40);
            this.lblStrValue.Name = "lblStrValue";
            this.lblStrValue.Size = new System.Drawing.Size(40, 20);
            this.lblStrValue.TabIndex = 4;
            this.lblStrValue.Text = "0%";
            // 
            // trackBarCha
            // 
            this.trackBarCha.LargeChange = 5;
            this.trackBarCha.Location = new System.Drawing.Point(20, 420);
            this.trackBarCha.Maximum = 100;
            this.trackBarCha.Name = "trackBarCha";
            this.trackBarCha.Size = new System.Drawing.Size(320, 69);
            this.trackBarCha.SmallChange = 5;
            this.trackBarCha.TabIndex = 3;
            this.trackBarCha.TickFrequency = 5;
            this.trackBarCha.Scroll += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarCha.Value = 0;
            // 
            // trackBarInt
            // 
            this.trackBarInt.LargeChange = 5;
            this.trackBarInt.Location = new System.Drawing.Point(20, 290);
            this.trackBarInt.Maximum = 100;
            this.trackBarInt.Name = "trackBarInt";
            this.trackBarInt.Size = new System.Drawing.Size(320, 69);
            this.trackBarInt.SmallChange = 5;
            this.trackBarInt.TabIndex = 2;
            this.trackBarInt.TickFrequency = 5;
            this.trackBarInt.Scroll += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarInt.Value = 0;
            // 
            // trackBarAgi
            // 
            this.trackBarAgi.LargeChange = 5;
            this.trackBarAgi.Location = new System.Drawing.Point(20, 160);
            this.trackBarAgi.Maximum = 100;
            this.trackBarAgi.Name = "trackBarAgi";
            this.trackBarAgi.Size = new System.Drawing.Size(320, 69);
            this.trackBarAgi.SmallChange = 5;
            this.trackBarAgi.TabIndex = 1;
            this.trackBarAgi.TickFrequency = 5;
            this.trackBarAgi.Scroll += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarAgi.Value = 0;
            // 
            // trackBarStr
            // 
            this.trackBarStr.LargeChange = 5;
            this.trackBarStr.Location = new System.Drawing.Point(20, 30);
            this.trackBarStr.Maximum = 100;
            this.trackBarStr.Name = "trackBarStr";
            this.trackBarStr.Size = new System.Drawing.Size(320, 69);
            this.trackBarStr.SmallChange = 5;
            this.trackBarStr.TabIndex = 0;
            this.trackBarStr.TickFrequency = 5;
            this.trackBarStr.Scroll += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarStr.Value = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.pictureBoxCharacter);
            this.panelRight.Controls.Add(this.textBoxDetails);
            this.panelRight.Location = new System.Drawing.Point(438, 12);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(574, 744);
            this.panelRight.TabIndex = 1;
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCharacter.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(568, 420);
            this.pictureBoxCharacter.TabIndex = 0;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(3, 430);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetails.Size = new System.Drawing.Size(568, 311);
            this.textBoxDetails.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "Form1";
            this.Text = "Orc Character Editor";
            // set background image at runtime by loading from Resources\parchment_bg.png
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxClass.ResumeLayout(false);
            this.groupBoxClass.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStr)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.RadioButton radioMage;
        private System.Windows.Forms.RadioButton radioArcher;
        private System.Windows.Forms.RadioButton radioWarrior;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.TrackBar trackBarStr;
        private System.Windows.Forms.TrackBar trackBarAgi;
        private System.Windows.Forms.TrackBar trackBarInt;
        private System.Windows.Forms.TrackBar trackBarCha;
        private System.Windows.Forms.Label lblChaValue;
        private System.Windows.Forms.Label lblIntValue;
        private System.Windows.Forms.Label lblAgiValue;
        private System.Windows.Forms.Label lblStrValue;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.TextBox textBoxDetails;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // load background
            string bg = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "parchment_bg.png");
            if (System.IO.File.Exists(bg))
            {
                this.BackgroundImage = Image.FromFile(bg);
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
        }
    }
}
