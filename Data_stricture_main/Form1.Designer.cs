namespace Data_stricture_main
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_stack = new System.Windows.Forms.Button();
            this.btn_Queue = new System.Windows.Forms.Button();
            this.btn_linkedlist = new System.Windows.Forms.Button();
            this.ctl_queue1 = new Data_structure_lib.ctl_queue();
            this.ctl_linkedList1 = new Data_structure_lib.ctl_linkedList();
            this.ctlStack1 = new Data_structure_lib.ctlStack();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stack
            // 
            this.btn_stack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stack.Location = new System.Drawing.Point(30, 46);
            this.btn_stack.Name = "btn_stack";
            this.btn_stack.Size = new System.Drawing.Size(75, 23);
            this.btn_stack.TabIndex = 1;
            this.btn_stack.Text = "Stack";
            this.btn_stack.UseVisualStyleBackColor = true;
            this.btn_stack.Click += new System.EventHandler(this.btn_stack_Click);
            // 
            // btn_Queue
            // 
            this.btn_Queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Queue.Location = new System.Drawing.Point(30, 94);
            this.btn_Queue.Name = "btn_Queue";
            this.btn_Queue.Size = new System.Drawing.Size(75, 23);
            this.btn_Queue.TabIndex = 2;
            this.btn_Queue.Text = "Queue";
            this.btn_Queue.UseVisualStyleBackColor = true;
            this.btn_Queue.Click += new System.EventHandler(this.btn_Queue_Click);
            // 
            // btn_linkedlist
            // 
            this.btn_linkedlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_linkedlist.Location = new System.Drawing.Point(30, 140);
            this.btn_linkedlist.Name = "btn_linkedlist";
            this.btn_linkedlist.Size = new System.Drawing.Size(75, 23);
            this.btn_linkedlist.TabIndex = 3;
            this.btn_linkedlist.Text = "Linked List";
            this.btn_linkedlist.UseVisualStyleBackColor = true;
            this.btn_linkedlist.Click += new System.EventHandler(this.btn_linkedlist_Click);
            // 
            // ctl_queue1
            // 
            this.ctl_queue1.Location = new System.Drawing.Point(153, 12);
            this.ctl_queue1.Name = "ctl_queue1";
            this.ctl_queue1.Size = new System.Drawing.Size(712, 473);
            this.ctl_queue1.TabIndex = 4;
            // 
            // ctl_linkedList1
            // 
            this.ctl_linkedList1.Location = new System.Drawing.Point(165, -1);
            this.ctl_linkedList1.Name = "ctl_linkedList1";
            this.ctl_linkedList1.Size = new System.Drawing.Size(713, 473);
            this.ctl_linkedList1.TabIndex = 0;
            // 
            // ctlStack1
            // 
            this.ctlStack1.Location = new System.Drawing.Point(153, 12);
            this.ctlStack1.Name = "ctlStack1";
            this.ctlStack1.Size = new System.Drawing.Size(712, 473);
            this.ctlStack1.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(30, 185);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit ";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 501);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.ctlStack1);
            this.Controls.Add(this.ctl_queue1);
            this.Controls.Add(this.btn_linkedlist);
            this.Controls.Add(this.btn_Queue);
            this.Controls.Add(this.btn_stack);
            this.Controls.Add(this.ctl_linkedList1);
            this.Name = "Form1";
            this.Text = "Data Structure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Data_structure_lib.ctl_linkedList ctl_linkedList1;
        private System.Windows.Forms.Button btn_stack;
        private System.Windows.Forms.Button btn_Queue;
        private System.Windows.Forms.Button btn_linkedlist;
        private Data_structure_lib.ctl_queue ctl_queue1;
        private Data_structure_lib.ctlStack ctlStack1;
        private System.Windows.Forms.Button btn_exit;
    }
}

