namespace Data_structure_lib
{
    partial class ctl_linkedList
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
            this.btn_add = new System.Windows.Forms.Button();
            this.Linked_list_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.btn_remove_at = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.stack_counter = new System.Windows.Forms.Label();
            this.top_value = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_remove = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(44, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Linked_list_panel
            // 
            this.Linked_list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Linked_list_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Linked_list_panel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Linked_list_panel.Location = new System.Drawing.Point(44, 364);
            this.Linked_list_panel.Name = "Linked_list_panel";
            this.Linked_list_panel.Size = new System.Drawing.Size(644, 60);
            this.Linked_list_panel.TabIndex = 2;
            this.Linked_list_panel.WrapContents = false;
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(162, 27);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(106, 22);
            this.txt_data.TabIndex = 3;
            // 
            // btn_remove_at
            // 
            this.btn_remove_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_at.Location = new System.Drawing.Point(44, 109);
            this.btn_remove_at.Name = "btn_remove_at";
            this.btn_remove_at.Size = new System.Drawing.Size(93, 23);
            this.btn_remove_at.TabIndex = 4;
            this.btn_remove_at.Text = "Remove At";
            this.btn_remove_at.UseVisualStyleBackColor = true;
            this.btn_remove_at.Click += new System.EventHandler(this.btn_remove_at_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Linked List Size: ";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(102, 51);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(0, 13);
            this.lbl_size.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_size);
            this.panel1.Controls.Add(this.stack_counter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.top_value);
            this.panel1.Location = new System.Drawing.Point(46, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 81);
            this.panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Linked List Details";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Input Data :";
            // 
            // txt_remove
            // 
            this.txt_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remove.Location = new System.Drawing.Point(162, 154);
            this.txt_remove.Name = "txt_remove";
            this.txt_remove.Size = new System.Drawing.Size(106, 22);
            this.txt_remove.TabIndex = 5;
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(44, 190);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(93, 23);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remove ";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(44, 230);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.Location = new System.Drawing.Point(43, 154);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(90, 16);
            this.lbl_index.TabIndex = 32;
            this.lbl_index.Text = "Input Index :";
            // 
            // ctl_linkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txt_remove);
            this.Controls.Add(this.btn_remove_at);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.Linked_list_panel);
            this.Controls.Add(this.btn_add);
            this.Location = new System.Drawing.Point(10, 0);
            this.Name = "ctl_linkedList";
            this.Size = new System.Drawing.Size(712, 473);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.FlowLayoutPanel Linked_list_panel;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Button btn_remove_at;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stack_counter;
        private System.Windows.Forms.Label top_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_remove;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_index;
    }
}
