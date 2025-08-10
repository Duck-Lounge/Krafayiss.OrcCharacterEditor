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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBoxChar = new PictureBox();
            radioButtonMale = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonFemale = new RadioButton();
            label3 = new Label();
            groupBox2 = new GroupBox();
            radioButtonArcher = new RadioButton();
            radioButtonWarrior = new RadioButton();
            radioButtonMage = new RadioButton();
            label4 = new Label();
            trackBarDamage = new TrackBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            trackBarDexterity = new TrackBar();
            trackBarIntelligence = new TrackBar();
            trackBarСharisma = new TrackBar();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            labelHealth = new Label();
            labelStamina = new Label();
            labelLuck = new Label();
            labelCritChance = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarDamage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDexterity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntelligence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarСharisma).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 32);
            label1.TabIndex = 0;
            label1.Text = "Create your character!";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // pictureBoxChar
            // 
            pictureBoxChar.Location = new Point(563, 43);
            pictureBoxChar.Name = "pictureBoxChar";
            pictureBoxChar.Size = new Size(225, 250);
            pictureBoxChar.TabIndex = 3;
            pictureBoxChar.TabStop = false;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new Point(6, 16);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(51, 19);
            radioButtonMale.TabIndex = 4;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Location = new Point(111, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 41);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(63, 16);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(63, 19);
            radioButtonFemale.TabIndex = 6;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonArcher);
            groupBox2.Controls.Add(radioButtonWarrior);
            groupBox2.Controls.Add(radioButtonMage);
            groupBox2.Location = new Point(111, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 38);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // radioButtonArcher
            // 
            radioButtonArcher.AutoSize = true;
            radioButtonArcher.Location = new Point(137, 11);
            radioButtonArcher.Name = "radioButtonArcher";
            radioButtonArcher.Size = new Size(60, 19);
            radioButtonArcher.TabIndex = 10;
            radioButtonArcher.TabStop = true;
            radioButtonArcher.Text = "Archer";
            radioButtonArcher.UseVisualStyleBackColor = true;
            radioButtonArcher.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonWarrior
            // 
            radioButtonWarrior.AutoSize = true;
            radioButtonWarrior.Checked = true;
            radioButtonWarrior.Location = new Point(6, 11);
            radioButtonWarrior.Name = "radioButtonWarrior";
            radioButtonWarrior.Size = new Size(64, 19);
            radioButtonWarrior.TabIndex = 9;
            radioButtonWarrior.TabStop = true;
            radioButtonWarrior.Text = "Warrior";
            radioButtonWarrior.UseVisualStyleBackColor = true;
            radioButtonWarrior.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonMage
            // 
            radioButtonMage.AutoSize = true;
            radioButtonMage.Location = new Point(76, 11);
            radioButtonMage.Name = "radioButtonMage";
            radioButtonMage.Size = new Size(55, 19);
            radioButtonMage.TabIndex = 9;
            radioButtonMage.TabStop = true;
            radioButtonMage.Text = "Mage";
            radioButtonMage.UseVisualStyleBackColor = true;
            radioButtonMage.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 8;
            label4.Text = "Class";
            // 
            // trackBarDamage
            // 
            trackBarDamage.Location = new Point(111, 172);
            trackBarDamage.Name = "trackBarDamage";
            trackBarDamage.Size = new Size(433, 45);
            trackBarDamage.TabIndex = 9;
            trackBarDamage.Scroll += TrackBar_Skroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(13, 172);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "Damage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(13, 223);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Dexterity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(13, 271);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 12;
            label7.Text = "Intelligence";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(13, 322);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 13;
            label8.Text = "Сharisma";
            // 
            // trackBarDexterity
            // 
            trackBarDexterity.Location = new Point(111, 223);
            trackBarDexterity.Name = "trackBarDexterity";
            trackBarDexterity.Size = new Size(433, 45);
            trackBarDexterity.TabIndex = 14;
            trackBarDexterity.Scroll += TrackBar_Skroll;
            // 
            // trackBarIntelligence
            // 
            trackBarIntelligence.Location = new Point(111, 271);
            trackBarIntelligence.Name = "trackBarIntelligence";
            trackBarIntelligence.Size = new Size(433, 45);
            trackBarIntelligence.TabIndex = 15;
            trackBarIntelligence.Scroll += TrackBar_Skroll;
            // 
            // trackBarСharisma
            // 
            trackBarСharisma.Location = new Point(111, 322);
            trackBarСharisma.Name = "trackBarСharisma";
            trackBarСharisma.Size = new Size(433, 45);
            trackBarСharisma.TabIndex = 16;
            trackBarСharisma.Scroll += TrackBar_Skroll;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(111, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(433, 216);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelCritChance);
            groupBox4.Controls.Add(labelLuck);
            groupBox4.Controls.Add(labelStamina);
            groupBox4.Controls.Add(labelHealth);
            groupBox4.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(563, 299);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(225, 149);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parameters";
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Location = new Point(6, 40);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(61, 20);
            labelHealth.TabIndex = 0;
            labelHealth.Text = "Health:";
            // 
            // labelStamina
            // 
            labelStamina.AutoSize = true;
            labelStamina.Location = new Point(6, 60);
            labelStamina.Name = "labelStamina";
            labelStamina.Size = new Size(70, 20);
            labelStamina.TabIndex = 1;
            labelStamina.Text = "Stamina:";
            // 
            // labelLuck
            // 
            labelLuck.AutoSize = true;
            labelLuck.Location = new Point(6, 80);
            labelLuck.Name = "labelLuck";
            labelLuck.Size = new Size(49, 20);
            labelLuck.TabIndex = 2;
            labelLuck.Text = "Luck:";
            // 
            // labelCritChance
            // 
            labelCritChance.AutoSize = true;
            labelCritChance.Location = new Point(6, 100);
            labelCritChance.Name = "labelCritChance";
            labelCritChance.Size = new Size(96, 20);
            labelCritChance.TabIndex = 3;
            labelCritChance.Text = "Crit Chance:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(trackBarСharisma);
            Controls.Add(trackBarIntelligence);
            Controls.Add(trackBarDexterity);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(trackBarDamage);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxChar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarDamage).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDexterity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarIntelligence).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarСharisma).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBoxChar;
        private RadioButton radioButtonMale;
        private GroupBox groupBox1;
        private RadioButton radioButtonFemale;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton radioButtonArcher;
        private RadioButton radioButtonWarrior;
        private RadioButton radioButtonMage;
        private Label label4;
        private TrackBar trackBarDamage;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TrackBar trackBarDexterity;
        private TrackBar trackBarIntelligence;
        private TrackBar trackBarСharisma;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label labelStamina;
        private Label labelHealth;
        private Label labelLuck;
        private Label labelCritChance;
    }
}
