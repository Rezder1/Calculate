using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipmentCalculatorAPPWF
{
    public partial class EquipmentCalculatorAPPWF : Form
    {
        public EquipmentCalculatorAPPWF()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void СomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CycleTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли введенный символ цифрой или является ли это клавишей Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменяем ввод, если символ не является цифрой
            }
        }

        private void WorkingDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли введенный символ цифрой или является ли это клавишей Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Отменяем ввод, если символ не является цифрой
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void EfficiencyFactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли введенный символ цифрой, точкой или клавишей Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Отменяем ввод, если символ не является цифрой или точкой
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void EquipmentCalculatorAPPWF_Load(object sender, EventArgs e)
        {

        }

        private void WorkValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли введенный символ цифрой, точкой или клавишей Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Отменяем ввод, если символ не является цифрой или точкой
            }
        }

        //Вывод введённых данных в переменные
        private void Button1_Click(object sender, EventArgs e)
        {
            string Name1 = EnteredName.Text;
            string BucketVolume = comboBox1.Text;
            string CycleTime1 = CycleTime.Text;
            string Days = WorkingDays.Text;
            string KPI = EfficiencyFactor.Text;
            string WorkValue = WorkValueBox.Text;

            int Bucket = Convert.ToInt32(BucketVolume);
            int Cycle = Convert.ToInt32(CycleTime1);
            int Day = Convert.ToInt32(Days);
            decimal KfPI;
            if (decimal.TryParse(KPI, NumberStyles.Any, CultureInfo.InvariantCulture, out KfPI))
            {
            }
            ;
            int WorkV= Convert.ToInt32(WorkValue);

            decimal result1 = Bucket * (86400 / Cycle) * Day * KfPI;
            decimal NumberOfExcavators = WorkV / result1;

            Result.Text = $"{Name1} / {result1} / {NumberOfExcavators}";
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            // Получение данных
            string Name1 = EnteredName.Text;
            string BucketVolume = comboBox1.Text;
            string CycleTime1 = CycleTime.Text;
            string Days = WorkingDays.Text;
            string KPI = EfficiencyFactor.Text;
            string WorkValue = WorkValueBox.Text;

            int Bucket = Convert.ToInt32(BucketVolume);
            int Cycle = Convert.ToInt32(CycleTime1);
            int Day = Convert.ToInt32(Days);
            decimal KfPI;
            if (decimal.TryParse(KPI, NumberStyles.Any, CultureInfo.InvariantCulture, out KfPI))
            {
            }
            ;
            int WorkV = Convert.ToInt32(WorkValue);

            decimal result1 = Bucket * (86400 / Cycle) * Day * KfPI;
            decimal NumberOfExcavators = WorkV / result1;

            string a1 = result1.ToString();
            string a2 = NumberOfExcavators.ToString();

            // Проверка, указан ли путь для сохранения
            if (string.IsNullOrEmpty(FilePath.Text))
            {
                MessageBox.Show("Пожалуйста, выберите путь для сохранения документа.");
                return;
            }

            // Создание документа
            using (var document = DocX.Create(FilePath.Text))
            {
                document.InsertParagraph("Данные по экскаватору").FontSize(20).Bold().SpacingAfter(20);

                var table = document.InsertTable(6, 2);
                table.Rows[0].Cells[0].Paragraphs[0].Append("Наименование показателя");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Значение");

                table.Rows[1].Cells[0].Paragraphs[0].Append("Модель эскаватора");
                table.Rows[1].Cells[1].Paragraphs[0].Append(Name1);

                table.Rows[2].Cells[0].Paragraphs[0].Append("Производительность, тыс. м³/год");
                table.Rows[2].Cells[1].Paragraphs[0].Append(a1);

                table.Rows[3].Cells[0].Paragraphs[0].Append("Объем работ, тыс. м³");
                table.Rows[3].Cells[1].Paragraphs[0].Append(WorkValue);

                table.Rows[4].Cells[0].Paragraphs[0].Append("Количество, шт.");
                table.Rows[4].Cells[1].Paragraphs[0].Append(a2);

                document.Save();
            }

            MessageBox.Show("Документ успешно создан");
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
