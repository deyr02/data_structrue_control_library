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
    public partial class ctl_linkedList : UserControl
    {
        ///<Summary> Class: ctl_linkedList
        ///this class interact wtih LinkedListController class to utlize the linked list
        /// the usercontrol Class intialize a list of text boxes which helps the represent Linke List in linked list panel
        ///  As well a queuecontroller object creates 
        ///</Summary>
        ///

        private List<TextBox> block = new List<TextBox>();
        private LinkedListController theLinkedListController;


        ///<Summary> Method: ctl_queue
        ///this is contractor of this class
        /// This method creates a LinkedListController class
        /// set the details for Linked list information empty
        /// customize the panel
        ///</Summary>
        public ctl_linkedList()
        {
            InitializeComponent();
            theLinkedListController = new LinkedListController(this);
            Linked_list_panel.FlowDirection = FlowDirection.LeftToRight;
            Linked_list_panel.WrapContents = false;
            Linked_list_panel.AutoScroll = true;
           

             btn_cancel.Visible = false;
            btn_remove.Visible = false;
            txt_remove.Visible = false;
            lbl_index.Visible = false;
            lbl_size.Text = "Empty List";

        }
        ///<Summary> method : create_Block
        ///the method creates text boxes and change its poperty, add to the Q panel
        ///these text boxes are representing memory bolck in the stack, queue, LinkedList
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
            this.Linked_list_panel.Controls.Add(st);
          
            return st;
        }
        ///<Summary> method : udate_details
        /// This method is being used to update details of the linked list in the interface
        /// first the method checks wether the Linked List is empty or not
        /// if the stack is empty linked list details updates its empty values
        /// else it will display the linked list details
        ///  ///</Summary>
        private void update_details()
        {
           if(theLinkedListController.getSizeoftheList() == 0)
            {
                lbl_size.Text = "Empty List";
            }
            else
            {
                lbl_size.Text = theLinkedListController.getSizeoftheList().ToString();
            }
        }
        ///<Summary> method : Design_queue
        ///This method is used to diplay textboxes in the Linked List panel
        ///As it is hard to change the flow direction of the panel all the time
        ///The funtion will check whether the block (List of Textboxes) is empty or not
        ///if not empty the function will remove all the textboxes from the linkedlist panel first
        ///then get the size of the linked list and loop through the linked list and recreate the text boxes again in the queue panel
        ///
        ///</Summary>
        public void design_LinkList()
        {
            if (block.Count != 0)
            {
                for (int i = 0; i < block.Count; i++)
                {
                    TextBox t = block[i];

                    t.Dispose();
                    block.RemoveAt(i);
                }
            }
            if (theLinkedListController.getSizeoftheList() != 0)
            {
                for (int i = 0; i < theLinkedListController.getSizeoftheList(); i++)
                {
                    int value = theLinkedListController.getSingleValue(i);
                    TextBox s = create_Block(value.ToString());
                    block.Add(s);
                }
            }
        }

        ///<Summary> method : btn_add_click
        ///this function is being used to add value in the linked list
        ///first of all the function validate the user input
        ///the value id valid then the value added in the linked list
        ///create a text box and place it into the  linked list panel
        ///updates the details in the interface
        ///Display the successfull message
        ///
        ///</Summary>
        private void btn_add_Click(object sender, EventArgs e)
        {
            string data = txt_data.Text;
            try
            {
                if (data == "")
                {
                    MessageBox.Show("please Input a number", "Error");
                }
                else if (!(data.All(char.IsDigit) == true))
                {
                    MessageBox.Show("Please input only numbers", "Error");
                }
                else if (Convert.ToInt32(data) > 10000)
                {
                    MessageBox.Show("Please input number between 0 to 1000", "Error");
                }
                else
                {
                   
                    TextBox t = create_Block(data);
                    block.Add(t);
                    theLinkedListController.addToList(Convert.ToInt32(data));
                    update_details();
                    txt_data.Clear();
                    MessageBox.Show("Success: The item of your choice has been added to the list", "Successful");

                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please input number between 0 to 1000", "Error");
            }
        }

        ///<Summary> method : btn_remove_at
        ///this function disable add button, remove button and visiable the input text box remvoe button and cancel button
        ///</Summary>
        private void btn_remove_at_Click(object sender, EventArgs e)
        {
            txt_remove.Visible = true;
            btn_remove.Visible = true;
            btn_cancel.Visible = true;
            lbl_index.Visible = true;
            btn_add.Enabled = false;
            txt_data.Enabled = false;

            btn_remove_at.Enabled = false;
        }
        ///<Summary> method : btn_Cancel button
        ///this function enable add button, remove button and hide the input text box remvoe button and cancel button
        ///</Summary>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_remove.Visible = false;
            btn_remove.Visible = false;
            btn_cancel.Visible = false;
            lbl_index.Visible = false;
            btn_add.Enabled = true;
            txt_data.Enabled = true;
            btn_remove_at.Enabled = true;
        }
        ///<Summary> method : btn_remove_at
        ///this function is being used to remove item from linked list according to user input
        ///first of all the function validate the user input 
        ///if user input is valid then delete the item from the list and display a successfull message
        ///otherwise display an error message
        ///</Summary>
        private void btn_remove_Click(object sender, EventArgs e)
        {
            string data = txt_remove.Text;
            try
            {
                if ((theLinkedListController.getSizeoftheList() == 0) || (block.Count == 0))
                {
                    MessageBox.Show("List is empty", "Error");
                }
                else if (Convert.ToInt32(data) < 0)
                {
                    MessageBox.Show("Please input only positive numbers", "Error");
                }

                else
                {

                    if (data == "")
                    {
                        MessageBox.Show("please Input index number", "Error");
                    }
                    else if (!(data.All(char.IsDigit) == true))
                    {
                        MessageBox.Show("Please input only numbers", "Error");
                    }
                    
                    

                    else
                    {


                        int index = Convert.ToInt32(data);

                       

                        theLinkedListController.RemoveFromList(index);
                        design_LinkList();
                        update_details();
                        txt_remove.Clear();
                        MessageBox.Show("Success: The item of your choice has been deleted from the list", "Successful");
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please input number between 0 to 1000", "Error");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Invalid Index number", "Error");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid Index number", "Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("please input only numbers", "Error");
            }

        }
    }
}
