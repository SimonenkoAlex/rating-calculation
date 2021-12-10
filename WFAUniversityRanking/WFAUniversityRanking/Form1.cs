using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WFAUniversityRanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string firstName = tBFirstname.Text;
            string secondName = tBSecondname.Text;
            string pathronymic = tBPatronymic.Text;
            Student student = new Student(firstName, secondName, pathronymic, 3, "ИВТм-212", 1);
            rTBOutput.Text = student.getSurnameAndInitials();
        }
    }
}
