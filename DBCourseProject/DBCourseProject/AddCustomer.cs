﻿using System;
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
    public partial class AddCustomer : Form
    {

        private Form1 mainForm;
        private bool update = false;
        private string updateCustomerId;

        public AddCustomer(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        public AddCustomer(Form1 _mainForm, string customerId, string customerName, string numberTel, string address, string creditCard,
            string issuanceRights, string characteristics)
        {
            update = true;
            updateCustomerId = customerId;
            InitializeComponent();
            mainForm = _mainForm;
            customerName_textBox.AppendText(customerName);
            numberTel_textBox.AppendText(numberTel);
            address_textBox.AppendText(address);
            creditCard_textBox.AppendText(creditCard);
            issuanceRights_textBox.AppendText(issuanceRights);
            characteristics_textBox.AppendText(characteristics);
        }

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            bool validation = false;
            var error = ErrorBox_label;
            string customerName = customerName_textBox.Text;
            string numberTel = numberTel_textBox.Text;
            string address = address_textBox.Text;
            string creditCard = creditCard_textBox.Text;
            string issuanceRights = issuanceRights_textBox.Text;
            string characteristics = characteristics_textBox.Text;

            if (string.IsNullOrEmpty(customerName))
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
            else if (string.IsNullOrEmpty(creditCard))
            {
                error.Text = "Не заполнено поле \"Номер кредитной карты\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(issuanceRights))
            {
                error.Text = "Не заполнено поле \"Дата окончания прав\"! \n";
                validation = false;
            }
            else if (string.IsNullOrEmpty(characteristics))
            {
                error.Text = "Не заполнено поле \"Характкристика\"! \n";
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
                    mainForm.UpdateCustomerDatagrid(updateCustomerId, customerName, numberTel, address, creditCard, issuanceRights, characteristics);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    mainForm.AddCustomerToDatagrid(customerName, numberTel, address, creditCard, issuanceRights, characteristics);
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
