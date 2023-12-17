using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using School.db;
using School.Models;
using School.Sources;

namespace School
{
    public partial class NewOrderForm : Form
    {
        public OrderDB currentOrder = null;
        public NewOrderForm()
        {
            InitializeComponent();
        }
        private void UpdateSubject()
        {
            BindingList<ServiceSource> subjects = new BindingList<ServiceSource>();
            foreach(SubjectModel subject in SubjectDB.GetAll())
            {
                subjects.Add(new ServiceSource(
                      subject, this   
                ));
            }
            servicesGridView.DataSource = subjects;
            //subjectsComboBox.Items.Clear();
            //subjectsComboBox.Items.AddRange(subjects.ToArray());
        }

        private int UpdateOrderID()
        {
            int result = OrderDB.GetNewId();
            OrderIdTextBox.Text = OrderDB.GetNewId().ToString();
            return result;
        }

        public void UpdateOrderTotal()
        {
            costResultTextBox.Text = currentOrder.price.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ResetOrder();
        }

        private void ResetOrder()
        {
            UpdateSubject();
            UpdateOrderID();
            currentOrder = new OrderDB(
                id: UpdateOrderID(),
                dataCreate: DateTime.Now,
                removed: false
            );
        }
    }
}
