

using OrcCharacterEditor.Logic.Enumerators;
using OrcCharacterEditor.Logic.Helpers;
using OrcCharacterEditor.Logic.Models;

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

        // Обновляем изображение и параметры при изменении радиокнопок
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var character = GetTraits();
            UpdateCharImage(character);
            UpdateCharParameters(character);
        }

        // Ограничиваем установку значений более 200% суммарно и обновляем параметры при изменении характеристик
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

            var trackBars = new[] { trackBarDamage, trackBarDexterity, trackBarIntelligence, trackBarCharisma };

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
            // Определяем пол
            Gender gender;
            if (radioButtonMale.Checked) gender = Gender.Male;
            else gender = Gender.Female;

            // Определяем класс
            CharacterBase character;
            if (radioButtonWarrior.Checked) character = new Warrior(trackBarDamage.Value,
                                                                    trackBarDexterity.Value,
                                                                    trackBarIntelligence.Value,
                                                                    trackBarCharisma.Value,
                                                                    gender);
            else if (radioButtonArcher.Checked) character = new Archer (trackBarDamage.Value,
                                                                        trackBarDexterity.Value,
                                                                        trackBarIntelligence.Value,
                                                                        trackBarCharisma.Value,
                                                                        gender);
            else character = new Mage(trackBarDamage.Value,
                                      trackBarDexterity.Value,
                                      trackBarIntelligence.Value,
                                      trackBarCharisma.Value,
                                      gender);

            return character;
        }

        public void UpdateCharImage(CharacterBase character)
        {
            // Получаем картинку из маппинга
            pictureBoxChar.Image = CharImageHelper.GetImage(character);
        }

        public void UpdateCharParameters(CharacterBase character)
        {
            var charParameters = CharUpdate.ParametersUpdate(character);

            // Обновление интерфейса
            labelHealth.Text = $"Health: {charParameters.Health}%";
            labelStamina.Text = $"Stamina: {charParameters.Stamina}%";
            labelLuck.Text = $"Luck: {charParameters.Luck}%";
            labelCritChance.Text = $"Crit Chance: {charParameters.CritChance}%";
            labelAttack.Text = $"Attack: {character.CalculateAttackPower()} dps";
        }
    }
}
