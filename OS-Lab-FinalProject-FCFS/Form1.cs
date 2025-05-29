using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab_FinalProject_FCFS
{
    public partial class Form1 : Form
    {
        private Queue<Customer> customerQueue = new Queue<Customer>();
        private int lineNumber = 1;
        private Customer currentCustomer = null;
        private int remainingBurst = 0;

        public Form1()
        {
            InitializeComponent();
            dgvQueue.Columns.Add("LineNumber", "Line #");
            dgvQueue.Columns.Add("FullName", "Customer Name");
            dgvQueue.Columns.Add("BurstTime", "Burst Time");
            lblCurrent.Text = "Currently serving: None";
            nudBurstTime.Minimum = 1;
        }

        private void ServeNextCustomer()
        {
            if (currentCustomer != null || customerQueue.Count == 0)
            {
                return;
            }

            currentCustomer = customerQueue.Dequeue();
            remainingBurst = currentCustomer.BurstTime;

            lblCurrent.Text = $"#{currentCustomer.LineNumber} {currentCustomer.FullName}";

            dgvQueue.Rows.RemoveAt(0);
            timerBurst.Interval = 1000;
            timerBurst.Start();
        }


        private void btnResetQueue_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to reset the queue?", "Confirm Reset", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                customerQueue.Clear();
                dgvQueue.Rows.Clear();
                lstServed.Items.Clear();
                lblCurrent.Text = "None";
                lineNumber = 1;
                currentCustomer = null;
                timerBurst.Stop();
            }
        }

        private void btnServeNext_Click(object sender, EventArgs e)
        {
            ServeNextCustomer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            int burst = (int)nudBurstTime.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            Customer newCustomer = new Customer
            {
                LineNumber = lineNumber++,
                FullName = name,
                BurstTime = burst
            };

            customerQueue.Enqueue(newCustomer);
            dgvQueue.Rows.Add(newCustomer.LineNumber, newCustomer.FullName, newCustomer.BurstTime);
            txtCustomerName.Clear();
        }

        private void timerBurst_Tick(object sender, EventArgs e)
        {
            remainingBurst--;

            if (remainingBurst <= 0)
            {
                timerBurst.Stop();

                lstServed.Items.Add($"#{currentCustomer.LineNumber} {currentCustomer.FullName}");

                currentCustomer = null;
                lblCurrent.Text = "None";

                if (customerQueue.Count > 0)
                {
                    ServeNextCustomer(); 
                }
            }
        }
    }
}
