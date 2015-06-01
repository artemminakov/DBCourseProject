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
    public partial class SQL_QueryForm : Form
    {
        private Form1 mainForm;

        public SQL_QueryForm()
        {
            InitializeComponent();
        }

        public SQL_QueryForm(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void sqlQuery_button_Click(object sender, EventArgs e)
        {
            bool validation = false;
            string query = sqlQuery_textBox.Text;

            if (string.IsNullOrEmpty(query))
            {
                validation = false;
            }
            else
            {
                validation = true;
            }
            if (validation)
            {
                this.DialogResult = DialogResult.OK;
                mainForm.doSQLQuery(query);
            }
        }
    }
}
