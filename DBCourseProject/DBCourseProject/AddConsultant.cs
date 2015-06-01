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
    public partial class AddConsultant : Form
    {
        public AddConsultant()
        {
            InitializeComponent();
        }

        private void carName_label_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            bool validation = false;
            var error = ErrorBox_label;
            string consultantName = consultantName_textBox.Text;
            string numberTel = numberTel_textBox.Text;
            string address = address_textBox.Text;
            string experience = experience_textBox.Text;
            string merit = merit_textBox.Text;
            
            if (string.IsNullOrEmpty(consultantName))
            {
                error.Text = "Не заполнено поле \"Имя\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(numberTel))
            {
                error.Text = "Не заполнено поле \"Номер телефона\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(address))
            {
                error.Text = "Не заполнено поле \"Адрес\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(experience))
            {
                error.Text = "Не заполнено поле \"Стаж\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(merit))
            {
                error.Text = "Не заполнено поле \"Заслуги\"! \n";
                validation = false;
            }
            else
            {
                validation = true;
            }

            if (validation)
            {
                this.DialogResult = DialogResult.OK;
                mainForm.AddConsultantToDatagrid(consultantName, numberTel, address, Convert.ToInt32(experience), merit);
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

        private void capacity_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentalFees_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mileage_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void color_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void model_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void carName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacity_label_Click(object sender, EventArgs e)
        {

        }

        private void rentalFees_label_Click(object sender, EventArgs e)
        {

        }

        private void mileage_label_Click(object sender, EventArgs e)
        {

        }

        private void color_label_Click(object sender, EventArgs e)
        {

        }

        private void model_label_Click(object sender, EventArgs e)
        {

        }

        private void ErrorBox_label_Click(object sender, EventArgs e)
        {

        }
    }
}
