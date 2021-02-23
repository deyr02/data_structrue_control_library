using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_structure_lib
{
    public partial class ctl_queue: UserControl
    {
        ///<Summary> Class: ctl_queue;
        ///this class interact wtih queueController class to utlize the queue
        /// the usercontrol Class intialize a list of text boxes which helps the represent queue in queue panel 
        ///  As well a queuecontroller object creates 
        ///</Summary>
        private List<TextBox> block = new List<TextBox>();
        private QueueController theQueueController;



        ///<Summary> Method: ctl_queue
        ///this is contractor of this class
        /// This method creates a queueController class
        /// set the details for queue information empty
        /// customize queue panel
        ///</Summary>
        public ctl_queue()
        {
            InitializeComponent();
            theQueueController = new QueueController(this);
            lbl_counter.Text = "Empty Queue";
            lbl_Front.Text = "Empty Queue";
            lbl_Rear.Text = "Empty Queue";
            Queue_panel.FlowDirection = FlowDirection.LeftToRight;
            Queue_panel.WrapContents = false;
            Queue_panel.AutoScroll = true;

        }
        ///<Summary> method : create_Block
        ///the method creates text boxes and change its poperty, add to the Queue panel
        ///these text boxes are representing memory bolck in the stack, queue, Queue
        /// create a text boxes 
        /// disabling editing mode of the text box
        /// Resize the text box
        /// set the background color for the  texboxes
        /// chang the font and its size
        /// change alignment
        /// add the text box in the panel
        /// return the text box
        ///</Summary>
        private TextBox create_Block(string textValue)
        {
            TextBox st = new TextBox();

            st.Enabled = false;
            st.Name = "txt";
            st.Multiline = true;
            st.Height = 35;
            st.Width = 100;
            st.BackColor = Color.Black;
            Font myfont = new Font("Times New Roman", 14.0f, FontStyle.Bold);
            st.Font = myfont;
            st.Text = textValue;
            st.TextAlign = HorizontalAlignment.Center;
            block.Add(st);
            this.Queue_panel.Controls.Add(st);
         
            return st;
        }

        ///<Summary> method : udate_details
        /// This method is being used to update details of the Queue in the interface
        /// first the method checks wether the queue is empty or not
        /// if the stack is empty queue details updates its empty values
        /// else it will display the queue details
        ///  ///</Summary>
        private void update_details()
        {
            if (theQueueController.getQueueCounter()== 0)
            {
                lbl_counter.Text = "Empty Queue";
                lbl_Front.Text = "Empty Queue";
                lbl_Rear.Text = "Empty Queue";
            }
            else
            {
                lbl_counter.Text = theQueueController.getQueueCounter().ToString();
                lbl_Front.Text = theQueueController.getFrontValue().ToString();
                lbl_Rear.Text = theQueueController.getRearValue().ToString();
            }
        }
        ///<Summary> method : Design_queue
        ///This method is used to diplay textboxes in the Queue panel
        ///As it is hard to change the flow direction of the panel all the time
        ///The funtion will check whether the block (List of Textboxes) is empty or not
        ///if not empty the function will remove all the textboxes from the queue first
        ///then get the size of the queue and loop through the queue and recreate the text boxes again in the queue panel
        ///
        ///</Summary>
        public void design_queue()
        {
            if (block.Count != 0)
            {
                for(int i =0; i<block.Count; i++)
                {
                    TextBox t = block[i];

                    t.Dispose();
                    block.RemoveAt(i);
                }
            }
            if(theQueueController.getQueueCounter() != 0)
            {
                for (int i = 0; i < theQueueController.getQueueCounter(); i++)
                {
                    int value = theQueueController.getSingleValue(i);
                    TextBox s = create_Block(value.ToString());
                    block.Add(s);
                }
            }
            
           
        }
        ///<Summary> method : btn_enqueue
        ///this function is being used to add values in the queue
        ///first the funtion validate the data
        ///if the value is valid then add it into the queue
        /// bulid the queue in the queue panel
        /// update queue details 
        /// and display successfull message
        /// if not an error message will display
        ///  ///</Summary>
        private void btn_enqueue_Click(object sender, EventArgs e)
        {
            string data = txt_data.Text;
            try
            {
                if (data == "")
                {
                    MessageBox.Show("Please input number between 0 to 1000", "Error");
                }
                else if (!(data.All(char.IsDigit) == true))
                {
                    MessageBox.Show("Please input number between 0 to 1000", "Error");
                }
                else
                {
                    theQueueController.addToQueue(Convert.ToInt32(data));
                   // TextBox t = create_Block(data);
                    design_queue();
                    update_details();
                    txt_data.Clear();
                    MessageBox.Show(" Enqueue  : Your choice of item Enqueued into the Queue successfully", "Success");

                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please input number between 0 to 1000", "Error");
            }
        }
        ///<Summary> method : btn_Dequeue
        ///this function is being used to remove from queue accroding to  to queue algortham
        ///first the function check whether the queue is empty or not
        ///if empty then display a error message
        ///if not delete the front value from queue and display a successfull message
        ///  ///</Summary>
        private void btn_dequeue_Click(object sender, EventArgs e)
        {
            if((theQueueController.getQueueCounter() == 0))
                {
                MessageBox.Show("Queue is empty", "Error");
            }
            else
            {
                theQueueController.RemoveFromQueue();
                design_queue();
              
                update_details();
                MessageBox.Show(" Dequeue  : Your choice of item Dequeued from the Queue successfully", "Success");
            }
        }
    }
}
