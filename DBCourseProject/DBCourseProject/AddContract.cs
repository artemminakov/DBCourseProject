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
    public partial class AddContract : Form
    {

        private Form1 mainForm;
        public AddContract(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        public AddContract()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            bool validation = false;
            var error = ErrorBox_label;
            string customerId = customerID_textBox.Text;
            string carId = carID_textBox.Text;
            string consultantId = consultantID_textBox.Text;
            string notes = notes_textBox.Text;
            string expiryDateLease = expiryDateLease_textBox.Text;
            string dateDrawingContract = dateDrawingContract_textBox.Text;

            if (string.IsNullOrEmpty(customerId))
            {
                error.Text = "Не заполнено поле \"Номер клиента\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(carId))
            {
                error.Text = "Не заполнено поле \"Номер автомобиля\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(consultantId))
            {
                error.Text = "Не заполнено поле \"Номер консультанта\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(notes))
            {
                error.Text = "Не заполнено поле \"Заметки\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(expiryDateLease))
            {
                error.Text = "Не заполнено поле \"Дата окончания аренды\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(dateDrawingContract))
            {
                error.Text = "Не заполнено поле \"Дата подписания контракта\"! \n";
                validation = false;
            }
            else
            {
                validation = true;
            }

            if (validation)
            {
                this.DialogResult = DialogResult.OK;
                mainForm.AddContractToDatagrid(Convert.ToInt32(customerId), Convert.ToInt32(carId), Convert.ToInt32(consultantId),
                    notes, expiryDateLease, dateDrawingContract);
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
