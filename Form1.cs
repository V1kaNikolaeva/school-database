using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using School.db;
using School.Models;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateSubjec()
        {
            BindingList<SubjectModel> subjects = new BindingList<SubjectModel>(SubjectDB.GetAll());
            servicesGridView.DataSource = subjects;
            //subjectsComboBox.Items.Clear();
            //subjectsComboBox.Items.AddRange(subjects.ToArray());
        }

        private void UpdateOrderID()
        {
            OrderIdTextBox.Text = OrderDB.GetNewId().ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateSubjec();
            UpdateOrderID();
        }
    }
}
