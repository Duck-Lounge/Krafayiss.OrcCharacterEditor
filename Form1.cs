using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace OrcCharacterEditor
{
    public partial class Form1 : Form
    {
        private int prevStr = 0, prevAgi = 0, prevInt = 0, prevCha = 0;
        public Form1()
        {
            InitializeComponent();
            // initialize previous values
            prevStr = trackBarStr.Value;
            prevAgi = trackBarAgi.Value;
            prevInt = trackBarInt.Value;
            prevCha = trackBarCha.Value;
            UpdateCharacterImage();
            UpdateStats();
        }

        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        private void Class_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCharacterImage();
            UpdateStats();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            // enforce step of 5 (TrackBar already set), enforce sum <=200%
            int sum = trackBarStr.Value + trackBarAgi.Value + trackBarInt.Value + trackBarCha.Value;
            TrackBar tb = sender as TrackBar;
            if (sum > 200)
            {
                // revert to previous value for the changed trackbar
                if (tb == trackBarStr) trackBarStr.Value = prevStr;
                if (tb == trackBarAgi) trackBarAgi.Value = prevAgi;
                if (tb == trackBarInt) trackBarInt.Value = prevInt;
                if (tb == trackBarCha) trackBarCha.Value = prevCha;
                return;
            }
            // save prevs
            prevStr = trackBarStr.Value;
            prevAgi = trackBarAgi.Value;
            prevInt = trackBarInt.Value;
            prevCha = trackBarCha.Value;
            // update labels
            lblStrValue.Text = trackBarStr.Value + "%";
            lblAgiValue.Text = trackBarAgi.Value + "%";
            lblIntValue.Text = trackBarInt.Value + "%";
            lblChaValue.Text = trackBarCha.Value + "%";
            UpdateStats();
        }

        private void UpdateCharacterImage()
        {
            string gender = radioMale.Checked ? "male" : "female";
            string cls = radioWarrior.Checked ? "warrior" : (radioArcher.Checked ? "archer" : "mage");
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", $"orc_{gender}_{cls}.png");
            if (File.Exists(path))
            {
                pictureBoxCharacter.Image = Image.FromFile(path);
                pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void UpdateStats()
        {
            // Base values
            double baseHealth = 100.0;
            double baseStamina = 100.0;
            double baseLuck = 100.0;
            double crit = 5.0;

            // Gender bonuses
            if (radioFemale.Checked) baseLuck += 10.0;
            else baseHealth += 10.0;

            // From Strength: every 5% => +2% health and +2% stamina
            int strengthBlocks = trackBarStr.Value / 5;
            baseHealth += strengthBlocks * 2.0;
            baseStamina += strengthBlocks * 2.0;

            // Agility: every5% => +2% health +1% luck
            int agiBlocks = trackBarAgi.Value / 5;
            baseHealth += agiBlocks * 2.0;
            baseLuck += agiBlocks * 1.0;
            if (trackBarAgi.Value >= 50) crit += 5.0;

            // Intelligence: every5% => +2% luck and -1% stamina
            int intBlocks = trackBarInt.Value / 5;
            baseLuck += intBlocks * 2.0;
            baseStamina -= intBlocks * 1.0;
            if (trackBarInt.Value >= 50) crit += 5.0;

            // Charisma: every5% => +2% luck and -1% health
            int chaBlocks = trackBarCha.Value / 5;
            baseLuck += chaBlocks * 2.0;
            baseHealth -= chaBlocks * 1.0;

            // Minimum constraints
            if (baseStamina < 1.0) baseStamina = 1.0;
            if (baseHealth < 1.0) baseHealth = 1.0;

            // Update display block
            string details = "";
            details += $"Раса: Орк\\r\\n";
            details += $"Пол: {(radioMale.Checked ? \"Мужской\" : \"Женский\")}\\r\\n";
            details += $"Класс: {(radioWarrior.Checked ? \"Воин\" : (radioArcher.Checked ? \"Лучник\" : \"Маг\"))}\\r\\n";
            details += $"\\r\\nХарактеристики:\\r\\n";
            details += $"  Сила: {trackBarStr.Value}%\\r\\n";
            details += $"  Ловкость: {trackBarAgi.Value}%\\r\\n";
            details += $"  Интеллект: {trackBarInt.Value}%\\r\\n";
            details += $"  Харизма: {trackBarCha.Value}%\\r\\n";
            details += $"\\r\\nПараметры (на основе модификаторов):\\r\\n";
            details += $"  Здоровье: {Math.Round(baseHealth,1)}%\\r\\n";
            details += $"  Выносливость: {Math.Round(baseStamina,1)}%\\r\\n";
            details += $"  Удача: {Math.Round(baseLuck,1)}%\\r\\n";
            details += $"  Критический удар: {Math.Round(crit,1)}%\\r\\n";

            textBoxDetails.Text = details;
        }
    }
}
