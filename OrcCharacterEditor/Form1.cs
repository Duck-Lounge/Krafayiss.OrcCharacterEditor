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
            var character = GetTraits();
            UpdateCharImage(character);
            UpdateCharParameters(character);
        }

        // ��������� ����������� � ��������� ��� ��������� �����������
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var character = GetTraits();
            UpdateCharImage(character);
            UpdateCharParameters(character);
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

        public CharacterBase GetTraits()
        {         
            // ���������� ���
            Gender gender;
            if (radioButtonMale.Checked) gender = Gender.Male;
            else gender = Gender.Female;

            // ���������� �����
            CharacterBase character;
            if (radioButtonWarrior.Checked) character = new Warrior(trackBarDamage.Value,
                                                                    trackBarDexterity.Value,
                                                                    trackBarIntelligence.Value,
                                                                    trackBar�harisma.Value,
                                                                    gender);
            else if (radioButtonArcher.Checked) character = new Archer (trackBarDamage.Value,
                                                                        trackBarDexterity.Value,
                                                                        trackBarIntelligence.Value,
                                                                        trackBar�harisma.Value,
                                                                        gender);
            else character = new Mage(trackBarDamage.Value,
                                      trackBarDexterity.Value,
                                      trackBarIntelligence.Value,
                                      trackBar�harisma.Value,
                                      gender);

            return character;
        }

        public void UpdateCharImage(CharacterBase character)
        {
            // �������� �������� �� ��������
            pictureBoxChar.Image = CharImageMap.GetImage(character.ImageName);
        }

        public void UpdateCharParameters(CharacterBase character)
        {
            var charParameters = FormUpdate.ParametersUpdate(character);

            // ���������� ����������
            labelHealth.Text = $"Health: {charParameters.Health}%";
            labelStamina.Text = $"Stamina: {charParameters.Stamina}%";
            labelLuck.Text = $"Luck: {charParameters.Luck}%";
            labelCritChance.Text = $"Crit Chance: {charParameters.CritChance}%";
        }
    }
}
