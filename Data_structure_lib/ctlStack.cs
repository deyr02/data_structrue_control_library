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
    public partial class ctlStack : UserControl
    {

      
        private Stack_Controller theController;
        private List<TextBox> block = new List<TextBox>();
        public ctlStack()
        {
            InitializeComponent();
            //create new controller class
            // intiailzie the label values
            //make flow panel direction  bottom up
            // diable wrap contents in the flow lebel
            //disabling the Wrap Contents
            //Enabling the auto scrolling
            theController = new Stack_Controller(this);
            top_value.Text = "Empty Stack";
            stack_counter.Text = "Empty Stack";
            Stack_panell.FlowDirection = FlowDirection.BottomUp;
            Stack_panell.WrapContents = false;
            Stack_panell.AutoScroll = true;
        }
        ///<Summary> method : create_Block
        ///the method creates text boxes and change its poperty, add to the panel
        ///these text boxes are representing memory bolck in the stack, queue, linked list
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
            block.Add(st);
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
            this.Stack_panell.Controls.Add(st);
            return st;
        }
        ///<Summary> method : udate Stack details
        /// This method is being used to update details of the stack in the interface
        /// first the method checks wether the stack is empty or not
        /// if the stack is empty stack details updates its empty values
        /// else it will display the stack details
        ///  ///</Summary>
        private void update_Stack_details()
        {
           if (theController.getStackCounter() == 0)
            {
                top_value.Text = "Empty Stack";
                stack_counter.Text = "Empty Stack";
            }
            else
            {

                top_value.Text = theController.getStackTop().ToString();
                stack_counter.Text = theController.getStackCounter().ToString();
             
            }
        }
       
        /// <summary> Method: btn_add_click
        /// This method is being used to add value to the stack and add the text boxes in the stack panel which is
        /// visually represented in the form
        /// the function also check for valid value
        /// the the value is not valid then, an error message will apper
        /// if the value is valid the the function will add the value in the stack
        ///     display information in the stack details
        ///     create a text boxes and adds in the stack panel
        ///     finally display successfully mesage 
        /// 
        /// </summary>
       
        private void btn_add_Click(object sender, EventArgs e)
        {
           
            string data = txt_Data.Text;
          try
            {
                if (data == "")
                {
                    MessageBox.Show("please Input a number", "Error");
                }
                else if (!(data.All(char.IsDigit) == true))
                {
                    MessageBox.Show("Please input number between 0 to 1000", "Error");
                }
                else
                {
                    theController.addToStack(Convert.ToInt32(data));
                    update_Stack_details();
                    TextBox t = create_Block(data);
                    txt_Data.Clear();
                    MessageBox.Show(" Push  : Your choice of item Pushed into the stack successfully", "Success");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please input number between 0 to 1000", "Error");
            }
        }
        /// <summary> Method: btn_add_click
        /// This method is being used to pop item from the stack and remove text boxes from the stack which visually 
        /// repeseten in the form
        /// the function the  stack size first
        /// if stack is not empty
        ///     remove the top item from the stack
        ///     updates information about stack in the details panel
        ///     remove the text box fromm the stack
        ///     Disply a successfull message
        /// if stak is empty
        ///     display an error message
       /// </summary>

        private void btn_pop_Click(object sender, EventArgs e)
        {
            int c = theController.getStackCounter();
            if (c != 0)
            {
                theController.RemoveFromStack();
                update_Stack_details();
                TextBox x = block[c - 1];
                x.Dispose();
                block.RemoveAt(c - 1);
                MessageBox.Show("Pop  : Your choice of item Poped from the stack successfully", "Success");
            }
            else
            {
                MessageBox.Show("Sorry, Stack is empty", "Error");
            }
        }
    }
}
