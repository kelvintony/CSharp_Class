namespace CSharp_Class
{
    partial class ListBoxControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstData = new System.Windows.Forms.ListBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnItemCount = new System.Windows.Forms.Button();
            this.btnSelectedItem = new System.Windows.Forms.Button();
            this.btnSelectedIndex = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lstData);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRemoveItem);
            this.panel1.Controls.Add(this.btnItemCount);
            this.panel1.Controls.Add(this.btnSelectedItem);
            this.panel1.Controls.Add(this.btnSelectedIndex);
            this.panel1.Controls.Add(this.btnValidate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(56, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 461);
            this.panel1.TabIndex = 0;
            // 
            // lstData
            // 
            this.lstData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 21;
            this.lstData.Location = new System.Drawing.Point(238, 171);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(198, 214);
            this.lstData.TabIndex = 22;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(238, 124);
            this.txtData.Margin = new System.Windows.Forms.Padding(5);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(187, 27);
            this.txtData.TabIndex = 21;
            this.txtData.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtData.Enter += new System.EventHandler(this.txtData_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Data:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Aqua;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(18, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 40);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Aqua;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(18, 298);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(170, 40);
            this.btnRemoveItem.TabIndex = 19;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnItemCount
            // 
            this.btnItemCount.BackColor = System.Drawing.Color.Aqua;
            this.btnItemCount.FlatAppearance.BorderSize = 0;
            this.btnItemCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemCount.Location = new System.Drawing.Point(18, 251);
            this.btnItemCount.Name = "btnItemCount";
            this.btnItemCount.Size = new System.Drawing.Size(170, 40);
            this.btnItemCount.TabIndex = 19;
            this.btnItemCount.Text = "Item Count";
            this.btnItemCount.UseVisualStyleBackColor = false;
            this.btnItemCount.Click += new System.EventHandler(this.btnItemCount_Click);
            // 
            // btnSelectedItem
            // 
            this.btnSelectedItem.BackColor = System.Drawing.Color.Aqua;
            this.btnSelectedItem.FlatAppearance.BorderSize = 0;
            this.btnSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedItem.Location = new System.Drawing.Point(18, 205);
            this.btnSelectedItem.Name = "btnSelectedItem";
            this.btnSelectedItem.Size = new System.Drawing.Size(170, 40);
            this.btnSelectedItem.TabIndex = 19;
            this.btnSelectedItem.Text = "Selected Item";
            this.btnSelectedItem.UseVisualStyleBackColor = false;
            this.btnSelectedItem.Click += new System.EventHandler(this.btnSelectedItem_Click);
            // 
            // btnSelectedIndex
            // 
            this.btnSelectedIndex.BackColor = System.Drawing.Color.Aqua;
            this.btnSelectedIndex.FlatAppearance.BorderSize = 0;
            this.btnSelectedIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedIndex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedIndex.Location = new System.Drawing.Point(18, 158);
            this.btnSelectedIndex.Name = "btnSelectedIndex";
            this.btnSelectedIndex.Size = new System.Drawing.Size(170, 40);
            this.btnSelectedIndex.TabIndex = 19;
            this.btnSelectedIndex.Text = "Selected Index";
            this.btnSelectedIndex.UseVisualStyleBackColor = false;
            this.btnSelectedIndex.Click += new System.EventHandler(this.btnSelectedIndex_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Aqua;
            this.btnValidate.FlatAppearance.BorderSize = 0;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(18, 111);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(170, 40);
            this.btnValidate.TabIndex = 19;
            this.btnValidate.Text = "Add";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(213, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 338);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 65);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "List Box Control";
            // 
            // ListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 514);
            this.Controls.Add(this.panel1);
            this.Name = "ListBoxControl";
            this.Text = "ListBoxControl";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnItemCount;
        private System.Windows.Forms.Button btnSelectedItem;
        private System.Windows.Forms.Button btnSelectedIndex;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstData;
    }
}