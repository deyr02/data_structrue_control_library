namespace Data_structure_lib
{
    partial class ctl_queue
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_enqueue = new System.Windows.Forms.Button();
            this.btn_dequeue = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.Queue_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stack_counter = new System.Windows.Forms.Label();
            this.top_value = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Front = new System.Windows.Forms.Label();
            this.lbl_Rear = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enqueue
            // 
            this.btn_enqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enqueue.Location = new System.Drawing.Point(60, 98);
            this.btn_enqueue.Name = "btn_enqueue";
            this.btn_enqueue.Size = new System.Drawing.Size(85, 23);
            this.btn_enqueue.TabIndex = 0;
            this.btn_enqueue.Text = "Enqueue";
            this.btn_enqueue.UseVisualStyleBackColor = true;
            this.btn_enqueue.Click += new System.EventHandler(this.btn_enqueue_Click);
            // 
            // btn_dequeue
            // 
            this.btn_dequeue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dequeue.Location = new System.Drawing.Point(60, 145);
            this.btn_dequeue.Name = "btn_dequeue";
            this.btn_dequeue.Size = new System.Drawing.Size(85, 23);
            this.btn_dequeue.TabIndex = 1;
            this.btn_dequeue.Text = "Dequeue";
            this.btn_dequeue.UseVisualStyleBackColor = true;
            this.btn_dequeue.Click += new System.EventHandler(this.btn_dequeue_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(173, 59);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(100, 20);
            this.txt_data.TabIndex = 2;
            // 
            // Queue_panel
            // 
            this.Queue_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Queue_panel.Location = new System.Drawing.Point(60, 260);
            this.Queue_panel.Name = "Queue_panel";
            this.Queue_panel.Size = new System.Drawing.Size(603, 77);
            this.Queue_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lbl_Front);
            this.panel1.Controls.Add(this.lbl_Rear);
            this.panel1.Controls.Add(this.lbl_counter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.stack_counter);
            this.panel1.Controls.Add(this.top_value);
            this.panel1.Location = new System.Drawing.Point(385, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 151);
            this.panel1.TabIndex = 30;
            // 
            // stack_counter
            // 
            this.stack_counter.AutoSize = true;
            this.stack_counter.Location = new System.Drawing.Point(120, 75);
            this.stack_counter.Name = "stack_counter";
            this.stack_counter.Size = new System.Drawing.Size(0, 13);
            this.stack_counter.TabIndex = 31;
            // 
            // top_value
            // 
            this.top_value.AutoSize = true;
            this.top_value.Location = new System.Drawing.Point(120, 49);
            this.top_value.Name = "top_value";
            this.top_value.Size = new System.Drawing.Size(0, 13);
            this.top_value.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Queue Details";
            // 
            // lbl_Front
            // 
            this.lbl_Front.AutoSize = true;
            this.lbl_Front.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Front.Location = new System.Drawing.Point(134, 117);
            this.lbl_Front.Name = "lbl_Front";
            this.lbl_Front.Size = new System.Drawing.Size(0, 16);
            this.lbl_Front.TabIndex = 38;
            // 
            // lbl_Rear
            // 
            this.lbl_Rear.AutoSize = true;
            this.lbl_Rear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rear.Location = new System.Drawing.Point(135, 90);
            this.lbl_Rear.Name = "lbl_Rear";
            this.lbl_Rear.Size = new System.Drawing.Size(0, 16);
            this.lbl_Rear.TabIndex = 37;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.Location = new System.Drawing.Point(135, 63);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(0, 16);
            this.lbl_counter.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Value At Front          :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Value At Rear          :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Queue Counter        :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Input Value";
            // 
            // ctl_queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Queue_panel);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_dequeue);
            this.Controls.Add(this.btn_enqueue);
            this.Name = "ctl_queue";
            this.Size = new System.Drawing.Size(712, 473);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enqueue;
        private System.Windows.Forms.Button btn_dequeue;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.FlowLayoutPanel Queue_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stack_counter;
        private System.Windows.Forms.Label top_value;
        private System.Windows.Forms.Label lbl_Front;
        private System.Windows.Forms.Label lbl_Rear;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
