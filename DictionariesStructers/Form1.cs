using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionariesStructers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Student
        {
            public double No { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> NewStudents = new List<Student>()
            {
                new Student{No=100,Name="John",Surname="Doe"},
                new Student{No=110,Name="John2",Surname="Doe"},
                new Student{No=130,Name="John3",Surname="Doe"}
            };

            Dictionary<Double, Student> List = NewStudents.ToDictionary(N => N.No);
            foreach (KeyValuePair<Double,Student> student in List)
            {
                listBoxControl1.Items.Add(student.Key.ToString() + "-" + student.Value.Name + " " + student.Value.Surname);
            }

        }




    }
}
