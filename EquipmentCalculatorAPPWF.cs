using System;
using System.Globalization;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace EquipmentCalculatorAPPWF
{
    public partial class EquipmentCalculatorAPPWF : Form
    {
        public EquipmentCalculatorAPPWF()
        {
            InitializeComponent();
        }

        private void CycleTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(e);
        }

        private void WorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(e);
        }

        private void EfficiencyFactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDecimalInput(e);
        }

        private void WorkValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDecimalInput(e);
        }

        private void ValidateNumericInput(KeyPressEventArgs e) // Метод для проверки ввода в текстовое поле
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateDecimalInput(KeyPressEventArgs e) // Метод для проверки в числовое поле
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private (int bucket, int cycle, int day, decimal kfPI, int workValue) GetInputValues() // Метод собирает введённые данные и преобразует их в в цифровые
        {
            int bucket = Convert.ToInt32(comboBox1.Text);
            int cycle = Convert.ToInt32(CycleTime.Text);
            int day = Convert.ToInt32(WorkingDays.Text);
            decimal kfPI = decimal.TryParse(EfficiencyFactor.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal temp) ? temp : 0;
            int workValue = Convert.ToInt32(WorkValueBox.Text);

            return (bucket, cycle, day, kfPI, workValue);
        }

        private void Button1_Click(object sender, EventArgs e) // Создание кнопки вывода результата на экран
        {
            var (bucket, cycle, day, kfPI, workValue) = GetInputValues();
            CalculateAndDisplayResults(bucket, cycle, day, kfPI, workValue);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            var (bucket, cycle, day, kfPI, workValue) = GetInputValues();
            decimal result1 = CalculateResult(bucket, cycle, day, kfPI);
            decimal numberOfExcavators = CalculateNumberOfExcavators(workValue, result1);

            if (string.IsNullOrEmpty(FilePath.Text))
            {
                MessageBox.Show("Пожалуйста, выберите путь для сохранения документа.");
                return;
            }

            CreateDocument(result1, numberOfExcavators);
            MessageBox.Show("Документ успешно создан");
        }

        private decimal CalculateResult(int bucket, int cycle, int day, decimal kfPI) //Метод для выполнения расчётов производительности
        {
            return bucket * (86400 / cycle) * day * kfPI;
        }

        private decimal CalculateNumberOfExcavators(int workValue, decimal result1) // Метод для выполнения расчётов количества
        {
            return workValue / result1;
        }

        private void CalculateAndDisplayResults(int bucket, int cycle, int day, decimal kfPI, int workValue) // Метод отвечающий за расчёты и отображение результатов в форме
        {
            decimal result1 = CalculateResult(bucket, cycle, day, kfPI);
            decimal numberOfExcavators = CalculateNumberOfExcavators(workValue, result1);

            Result.Text = $"{EnteredName.Text} / {result1} / {numberOfExcavators}";
        }

        private void CreateDocument(decimal result1, decimal numberOfExcavators) // Метод создания и сохранение документа 
        {
            using (var document = DocX.Create(FilePath.Text))
            {
                document.InsertParagraph("Данные по экскаватору").FontSize(20).Bold().SpacingAfter(20);

                var table = document.InsertTable(6, 2);
                table.Rows[0].Cells[0].Paragraphs[0].Append("Наименование показателя");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Значение");

                table.Rows[1].Cells[0].Paragraphs[0].Append("Модель экскаватора");
                table.Rows[1].Cells[1].Paragraphs[0].Append(EnteredName.Text);

                table.Rows[2].Cells[0].Paragraphs[0].Append("Производительность, тыс. м³/год");
                table.Rows[2].Cells[1].Paragraphs[0].Append(result1.ToString());

                table.Rows[3].Cells[0].Paragraphs[0].Append("Объем работ, тыс. м³");
                table.Rows[3].Cells[1].Paragraphs[0].Append(WorkValueBox.Text);

                table.Rows[4].Cells[0].Paragraphs[0].Append("Количество, шт.");
                table.Rows[4].Cells[1].Paragraphs[0].Append(numberOfExcavators.ToString());

                document.Save();
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Documents|*.docx";
                saveFileDialog.Title = "Сохранить документ как";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath.Text = saveFileDialog.FileName; // Отображение выбранного пути
                }
            }
        }
    }
}
