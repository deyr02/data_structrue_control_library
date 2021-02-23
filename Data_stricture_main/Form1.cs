using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_stricture_main
{
    public partial class Form1 : Form
    {
        Boolean stack_button = false;
        Boolean queue_button = false;
        Boolean LinkedList_button = false;
        public Form1()
        {
            InitializeComponent();
            ctl_linkedList1.Visible = false;
            ctl_queue1.Visible = false;
            ctlStack1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_stack_Click(object sender, EventArgs e)
        {
            if(stack_button ==false)
            {
               
                btn_stack.Text = "Cancel";
                stack_button = true;
                btn_linkedlist.Enabled = false;
                btn_Queue.Enabled = false;
                ctlStack1.Visible = true;
                btn_exit.Enabled = false;
            }
            else
            {
                btn_stack.Text = "Stack";
                stack_button = false;
                ctl_queue1.Visible = false;
                btn_linkedlist.Enabled = true;
                btn_Queue.Enabled = true;
                ctlStack1.Visible = false;
                btn_exit.Enabled = true;
            }

        }

        private void btn_linkedlist_Click(object sender, EventArgs e)
        {
            if(LinkedList_button == false)
            {
                btn_linkedlist.Text = "Cancel";
                LinkedList_button = true;
                ctl_linkedList1.Visible = true;
                btn_stack.Enabled = false;
                btn_Queue.Enabled = false;
                btn_exit.Enabled = false;
            }
            else
            {
                btn_linkedlist.Text = "Linked List";
                LinkedList_button = false;
                ctl_linkedList1.Visible = false;
                btn_stack.Enabled = true;
                btn_Queue.Enabled = true;
                btn_exit.Enabled = true;

            }
        }

        private void btn_Queue_Click(object sender, EventArgs e)
        {
            if(queue_button == false)
            {
                btn_Queue.Text = "Cancel";
                queue_button = true;
                ctl_queue1.Visible = true;
                btn_stack.Enabled = false;
                btn_linkedlist.Enabled = false;
                btn_exit.Enabled = false;
            }
            else
            {
                btn_Queue.Text = "Queue";
                queue_button = false;
                ctl_queue1.Visible = false;
                btn_stack.Enabled = true;
                btn_linkedlist.Enabled = true;
                btn_exit.Enabled = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
