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
        }

        // Обновляем изображение и параметры при изменении радиокнопок
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCharImage();
            UpdateCharParameters();
        }

        // Ограничиваем установку значений более 200% суммарно и обновляем параметры при изменении характеристик
        private void TrackBar_Skroll(object sender, EventArgs e)
        {
            CheckTrackBarMaxValue(sender, e);
            UpdateCharParameters();
        }

        public void CheckTrackBarMaxValue(object sender, EventArgs e)
        {
            var changedTrackBar = sender as TrackBar;
            if (changedTrackBar == null)
                return;

            // Получаем сумму значений остальных TrackBar
            int sum = 0;
            foreach (var tb in new[] { trackBarDamage, trackBarDexterity, trackBarIntelligence, trackBarСharisma })
            {
                if (tb != changedTrackBar)
                    sum += tb.Value;
            }

            // Получаем максимальное допустимое значение изменяемого TrackBar
            int maxAllowed = 200 - sum;
            if (maxAllowed < 0) maxAllowed = 0;

            if (changedTrackBar.Value > maxAllowed)
            {
                changedTrackBar.Value = maxAllowed;
            }
        }

        public Character GetTraits()
        {
            // Определяем пол
            Gender gender;
            if (radioButtonMale.Checked) gender = Gender.Male;
            else gender = Gender.Female;

            // Определяем класс
            Class classType;
            if (radioButtonWarrior.Checked) classType = Class.Warrior;
            else if (radioButtonArcher.Checked) classType = Class.Archer;
            else classType = Class.Mage;

            // Создаем объект персонажа
            Character mainTraits = new()
            {
                Gender = gender,
                Class = classType,
                Damage = trackBarDamage.Value,
                Dexterity = trackBarDexterity.Value,
                Intelligence = trackBarIntelligence.Value,
                Сharisma = trackBarСharisma.Value
            };

            return mainTraits;
        }

        public void UpdateCharImage()
        {
            var mainTraits = GetTraits();

            // Получаем картинку из маппинга
            pictureBoxChar.Image = CharImageMap.GetImage(mainTraits.Gender, mainTraits.Class);
        }

        public void UpdateCharParameters()
        {
            var charTraits = GetTraits();
            FormUpdate.ParametersUpdate(charTraits);

            // Обновление интерфейса
            labelHealth.Text = $"Health: {health}%";
            labelStamina.Text = $"Stamina: {stamina}%";
            labelLuck.Text = $"Luck: {luck}%";
            labelCritChance.Text = $"Crit Chance: {crit}%";

            // Обновление картинки
            pictureBoxCharacter.Image = CharacterImageMap.GetImage(gender, classType);
        }
    }
}
