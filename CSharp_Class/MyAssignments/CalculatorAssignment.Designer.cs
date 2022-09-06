namespace CSharp_Class
{
    partial class CalculatorAssignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lstPerformOperation = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnMultiply = new System.Windows.Forms.RadioButton();
            this.rbnSubtract = new System.Windows.Forms.RadioButton();
            this.rbnAdd = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(63, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calculator App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perform Operation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output:";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(184, 44);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(164, 27);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(184, 81);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(164, 27);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Aqua;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Location = new System.Drawing.Point(152, 340);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(172, 43);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lstPerformOperation
            // 
            this.lstPerformOperation.FormattingEnabled = true;
            this.lstPerformOperation.ItemHeight = 21;
            this.lstPerformOperation.Items.AddRange(new object[] {
            "+",
            "X",
            "-",
            "/",
            "sqrt"});
            this.lstPerformOperation.Location = new System.Drawing.Point(184, 133);
            this.lstPerformOperation.Name = "lstPerformOperation";
            this.lstPerformOperation.Size = new System.Drawing.Size(198, 130);
            this.lstPerformOperation.TabIndex = 4;
            this.lstPerformOperation.SelectedIndexChanged += new System.EventHandler(this.lstPerformOperation_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(184, 285);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(287, 40);
            this.lblResult.TabIndex = 5;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(488, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 350);
            this.panel1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Using A Radio box";
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Aqua;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Location = new System.Drawing.Point(583, 340);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(172, 43);
            this.btnSolve.TabIndex = 8;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblResult2
            // 
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult2.Location = new System.Drawing.Point(540, 285);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(287, 40);
            this.lblResult2.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnMultiply);
            this.groupBox2.Controls.Add(this.rbnSubtract);
            this.groupBox2.Controls.Add(this.rbnAdd);
            this.groupBox2.Location = new System.Drawing.Point(555, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Operation";
            // 
            // rbnMultiply
            // 
            this.rbnMultiply.AutoSize = true;
            this.rbnMultiply.Location = new System.Drawing.Point(6, 99);
            this.rbnMultiply.Name = "rbnMultiply";
            this.rbnMultiply.Size = new System.Drawing.Size(88, 25);
            this.rbnMultiply.TabIndex = 0;
            this.rbnMultiply.Text = "multiply";
            this.rbnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbnSubtract
            // 
            this.rbnSubtract.AutoSize = true;
            this.rbnSubtract.Location = new System.Drawing.Point(6, 68);
            this.rbnSubtract.Name = "rbnSubtract";
            this.rbnSubtract.Size = new System.Drawing.Size(95, 25);
            this.rbnSubtract.TabIndex = 0;
            this.rbnSubtract.Text = "subtract";
            this.rbnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbnAdd
            // 
            this.rbnAdd.AutoSize = true;
            this.rbnAdd.Checked = true;
            this.rbnAdd.Location = new System.Drawing.Point(6, 37);
            this.rbnAdd.Name = "rbnAdd";
            this.rbnAdd.Size = new System.Drawing.Size(61, 25);
            this.rbnAdd.TabIndex = 0;
            this.rbnAdd.TabStop = true;
            this.rbnAdd.Text = "add";
            this.rbnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblResult2);
            this.groupBox1.Controls.Add(this.btnSolve);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lstPerformOperation);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.txtSecondNumber);
            this.groupBox1.Controls.Add(this.txtFirstNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator App";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CalculatorAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalculatorAssignment";
            this.Text = "CalculatorAssignment";
            this.Load += new System.EventHandler(this.CalculatorAssignment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ListBox lstPerformOperation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnMultiply;
        private System.Windows.Forms.RadioButton rbnSubtract;
        private System.Windows.Forms.RadioButton rbnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}