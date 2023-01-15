using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        // array <-> List
        List<Student> _student = new List<Student>();
        double maxgrade = 0, mingrade = int.MaxValue;
        int lenghtSTD = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // get value from oblect attribute
            String name = this.textBoxName.Text;
            String id = this.textID.Text;
            String year = this.textBirthYear.Text;
            String weight = this.textWeight.Text;
            String grade = this.textGrade.Text;
            String major = this.textMajor.Text;

            // convert string to int
            int iYear = Int32.Parse(year);
            double iWeight = Double.Parse(weight);
            double iGrade = Double.Parse(grade);

            // create object from student
            Student newStudent = new Student(name, id, iYear,iWeight,iGrade,major);
            // add new student ti list
            this._student.Add(newStudent);

            //calculate max min
            if (iGrade > maxgrade)
              {
                  maxgrade = iGrade;
              }

            if (iGrade < mingrade)
            {
                mingrade = iGrade;
            }


            // create textbox
            this.textBoxName.Text = "";
            this.textBirthYear.Text = "";
            this.textID.Text= "";
            this.textGrade.Text = "";
            this.textWeight.Text = "";
            this.textMajor.Text = "";
            this.textMax.Text = "";
            this.textMin.Text = "";
            this.textLenght.Text = "";

            //add prople
            lenghtSTD = lenghtSTD + 1;

            //show mix min lenght
            this.textMin.Text = this.textMin.Text + mingrade;
            this.textMax.Text = this.textMax.Text + maxgrade;
            this.textLenght.Text = this.textLenght.Text + lenghtSTD;

            BindingSource source = new BindingSource();
            source.DataSource = this._student;
            this.dataGridView1.DataSource = source;

        }

        //clear value
        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBoxName.Text = "";
            this.textBirthYear.Text = "";
            this.textID.Text = "";
            this.textGrade.Text = "";
            this.textWeight.Text = "";
            this.textMajor.Text = "";
        }
    }
}
