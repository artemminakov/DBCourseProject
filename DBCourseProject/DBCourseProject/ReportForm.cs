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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public ReportForm(int[] array)
        {
            InitializeComponent();
            JanuaryReport_label.Text = array[0].ToString();
            FebruaryReport_label.Text = array[1].ToString();
            MarchReport_label.Text = array[2].ToString();
            AprilReport_label.Text = array[3].ToString();
            MayReport_label.Text = array[4].ToString();
            JuneReport_label.Text = array[5].ToString();
            JulyReport_label.Text = array[6].ToString();
            AugustReport_label.Text = array[7].ToString();
            SeptemberReport_label.Text = array[8].ToString();
            OctoberReport_label.Text = array[9].ToString();
            NovemberReport_label.Text = array[10].ToString();
            DecemberReport_label.Text = array[11].ToString();           
            
        }
    }
}
