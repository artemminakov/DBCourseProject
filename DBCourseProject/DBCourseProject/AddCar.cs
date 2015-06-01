using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseProject
{
    public partial class AddCar : Form
    {

        private Form1 mainForm;
        private bool update = false;
        private string updateCarId;
        public AddCar(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        public AddCar(Form1 _mainForm, string carId, string carName, string model, string color, string mileage, 
            string rentalFees, string capacity)
        {
            update = true;
            updateCarId = carId;
            InitializeComponent();
            mainForm = _mainForm;
            carName_textBox.AppendText(carName);
            model_textBox.AppendText(model);
            color_textBox.AppendText(color);
            mileage_textBox.AppendText(mileage);
            rentalFees_textBox.AppendText(rentalFees);
            capacity_textBox.AppendText(capacity);
        }

        public AddCar()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            bool validation = false;
            var error = ErrorBox_label;
            string carName = carName_textBox.Text;
            string model = model_textBox.Text;
            string color = color_textBox.Text;
            string mileage = mileage_textBox.Text;
            string rentalFees = rentalFees_textBox.Text;
            string capacity = capacity_textBox.Text;

            if (string.IsNullOrEmpty(carName))
            {
                error.Text = "Не заполнено поле \"Марка\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(model))
            {
                error.Text = "Не заполнено поле \"Модель\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(color))
            {
                error.Text = "Не заполнено поле \"Цвет\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(mileage))
            {
                error.Text = "Не заполнено поле \"Пробег\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(rentalFees))
            {
                error.Text = "Не заполнено поле \"Стоимость проката\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(capacity))
            {
                error.Text = "Не заполнено поле \"Вместимость\"! \n";
                validation = false;
            }
            else
            {
                validation = true;
            }

            if (validation)
            {
                if (update)
                {
                    this.DialogResult = DialogResult.OK;
                    mainForm.UpdateCarDatagrid(updateCarId, carName, model, color, Convert.ToInt32(mileage), Convert.ToInt32(rentalFees), Convert.ToInt32(capacity));
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    mainForm.AddCarToDatagrid(carName, model, color, Convert.ToInt32(mileage), Convert.ToInt32(rentalFees), Convert.ToInt32(capacity));
                }
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        var x = item as TextBox;
                        x.Text = "";
                    }
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
