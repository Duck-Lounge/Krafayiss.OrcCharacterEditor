using OrcCharacterEditor.Enumerators;
using OrcCharacterEditor.Helpers;
using OrcCharacterEditor.Models;

namespace OrcCharacterEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var traits = GetTraits();
            UpdateCharImage(traits);
            UpdateCharParameters(traits);
        }

        // ��������� ����������� � ��������� ��� ��������� �����������
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var traits = GetTraits();
            UpdateCharImage(traits);
            UpdateCharParameters(traits);
        }

        // ������������ ��������� �������� ����� 200% �������� � ��������� ��������� ��� ��������� �������������
        private void TrackBar_Skroll(object sender, EventArgs e)
        {
            CheckTrackBarMaxValue(sender, e);
            var traits = GetTraits();
            UpdateCharParameters(traits);
        }

        public void CheckTrackBarMaxValue(object sender, EventArgs e)
        {
            var changedTrackBar = sender as TrackBar;
            if (changedTrackBar == null) return;

            var trackBars = new[] { trackBarDamage, trackBarDexterity, trackBarIntelligence, trackBar�harisma };

            foreach (var tb in trackBars)
            {
                if (tb == changedTrackBar)
                    continue;

                int sumOthers = trackBars
                    .Where(x => x != tb)
                    .Sum(x => x.Value);

                int maxAllowed = 200 - sumOthers;
                if (maxAllowed > 100) maxAllowed = 100;
                if (maxAllowed < 0) maxAllowed = 0;

                tb.Maximum = maxAllowed;
            }
        }

        public Character GetTraits()
        {
            // ���������� ���
            Gender gender;
            if (radioButtonMale.Checked) gender = Gender.Male;
            else gender = Gender.Female;

            // ���������� �����
            CharClass classType;
            if (radioButtonWarrior.Checked) classType = CharClass.Warrior;
            else if (radioButtonArcher.Checked) classType = CharClass.Archer;
            else classType = CharClass.Mage;

            // ������� ������ ���������
            Character mainTraits = new()
            {
                Gender = gender,
                Class = classType,
                Damage = trackBarDamage.Value,
                Dexterity = trackBarDexterity.Value,
                Intelligence = trackBarIntelligence.Value,
                �harisma = trackBar�harisma.Value
            };

            return mainTraits;
        }

        public void UpdateCharImage(Character mainTraits)
        {
            // �������� �������� �� ��������
            pictureBoxChar.Image = CharImageMap.GetImage(mainTraits.Gender, mainTraits.Class);
        }

        public void UpdateCharParameters(Character charTraits)
        {
            var charParameters = FormUpdate.ParametersUpdate(charTraits);

            // ���������� ����������
            labelHealth.Text = $"Health: {charParameters.Health}%";
            labelStamina.Text = $"Stamina: {charParameters.Stamina}%";
            labelLuck.Text = $"Luck: {charParameters.Luck}%";
            labelCritChance.Text = $"Crit Chance: {charParameters.CritChance}%";
        }
    }
}
