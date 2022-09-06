namespace CSharp_Class
{
    partial class CurrencyConverter
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnInputPounds = new System.Windows.Forms.RadioButton();
            this.rbnInputDollar = new System.Windows.Forms.RadioButton();
            this.rbnInputNaira = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnOutputPounds = new System.Windows.Forms.RadioButton();
            this.rbnOutputDollar = new System.Windows.Forms.RadioButton();
            this.rbnOutputNaira = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(178, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Currency Converter";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(251, 126);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(187, 27);
            this.txtAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnInputPounds);
            this.groupBox2.Controls.Add(this.rbnInputDollar);
            this.groupBox2.Controls.Add(this.rbnInputNaira);
            this.groupBox2.Location = new System.Drawing.Point(123, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Currency";
            // 
            // rbnInputPounds
            // 
            this.rbnInputPounds.AutoSize = true;
            this.rbnInputPounds.Location = new System.Drawing.Point(6, 99);
            this.rbnInputPounds.Name = "rbnInputPounds";
            this.rbnInputPounds.Size = new System.Drawing.Size(86, 25);
            this.rbnInputPounds.TabIndex = 0;
            this.rbnInputPounds.Text = "pounds";
            this.rbnInputPounds.UseVisualStyleBackColor = true;
            // 
            // rbnInputDollar
            // 
            this.rbnInputDollar.AutoSize = true;
            this.rbnInputDollar.Location = new System.Drawing.Point(6, 68);
            this.rbnInputDollar.Name = "rbnInputDollar";
            this.rbnInputDollar.Size = new System.Drawing.Size(71, 25);
            this.rbnInputDollar.TabIndex = 0;
            this.rbnInputDollar.Text = "dollar";
            this.rbnInputDollar.UseVisualStyleBackColor = true;
            // 
            // rbnInputNaira
            // 
            this.rbnInputNaira.AutoSize = true;
            this.rbnInputNaira.Checked = true;
            this.rbnInputNaira.Location = new System.Drawing.Point(6, 37);
            this.rbnInputNaira.Name = "rbnInputNaira";
            this.rbnInputNaira.Size = new System.Drawing.Size(68, 25);
            this.rbnInputNaira.TabIndex = 0;
            this.rbnInputNaira.TabStop = true;
            this.rbnInputNaira.Text = "naira";
            this.rbnInputNaira.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnOutputPounds);
            this.groupBox1.Controls.Add(this.rbnOutputDollar);
            this.groupBox1.Controls.Add(this.rbnOutputNaira);
            this.groupBox1.Location = new System.Drawing.Point(377, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Currency";
            // 
            // rbnOutputPounds
            // 
            this.rbnOutputPounds.AutoSize = true;
            this.rbnOutputPounds.Location = new System.Drawing.Point(6, 99);
            this.rbnOutputPounds.Name = "rbnOutputPounds";
            this.rbnOutputPounds.Size = new System.Drawing.Size(86, 25);
            this.rbnOutputPounds.TabIndex = 0;
            this.rbnOutputPounds.Text = "pounds";
            this.rbnOutputPounds.UseVisualStyleBackColor = true;
            // 
            // rbnOutputDollar
            // 
            this.rbnOutputDollar.AutoSize = true;
            this.rbnOutputDollar.Location = new System.Drawing.Point(6, 68);
            this.rbnOutputDollar.Name = "rbnOutputDollar";
            this.rbnOutputDollar.Size = new System.Drawing.Size(71, 25);
            this.rbnOutputDollar.TabIndex = 0;
            this.rbnOutputDollar.Text = "dollar";
            this.rbnOutputDollar.UseVisualStyleBackColor = true;
            // 
            // rbnOutputNaira
            // 
            this.rbnOutputNaira.AutoSize = true;
            this.rbnOutputNaira.Checked = true;
            this.rbnOutputNaira.Location = new System.Drawing.Point(6, 37);
            this.rbnOutputNaira.Name = "rbnOutputNaira";
            this.rbnOutputNaira.Size = new System.Drawing.Size(68, 25);
            this.rbnOutputNaira.TabIndex = 0;
            this.rbnOutputNaira.TabStop = true;
            this.rbnOutputNaira.Text = "naira";
            this.rbnOutputNaira.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(117, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 1);
            this.panel1.TabIndex = 12;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(231, 376);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(287, 40);
            this.lblOutput.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output:";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Aqua;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Location = new System.Drawing.Point(251, 447);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(172, 43);
            this.btnCompute.TabIndex = 15;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 499);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CurrencyConverter";
            this.Text = "CurrencyConverter";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnInputPounds;
        private System.Windows.Forms.RadioButton rbnInputDollar;
        private System.Windows.Forms.RadioButton rbnInputNaira;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnOutputPounds;
        private System.Windows.Forms.RadioButton rbnOutputDollar;
        private System.Windows.Forms.RadioButton rbnOutputNaira;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompute;
    }
}