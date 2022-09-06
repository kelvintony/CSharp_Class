namespace CSharp_Class
{
    partial class DataVisualisation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSavings = new System.Windows.Forms.DataGridView();
            this.chartSavings = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPlotGraph = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSavings)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(467, 36);
            this.label8.TabIndex = 11;
            this.label8.Text = "Graph Plotting - Savings Record";
            // 
            // dgvSavings
            // 
            this.dgvSavings.AllowUserToDeleteRows = false;
            this.dgvSavings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSavings.BackgroundColor = System.Drawing.Color.White;
            this.dgvSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSavings.Location = new System.Drawing.Point(18, 59);
            this.dgvSavings.Name = "dgvSavings";
            this.dgvSavings.Size = new System.Drawing.Size(317, 372);
            this.dgvSavings.TabIndex = 12;
            this.dgvSavings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSavings_CellContentClick);
            // 
            // chartSavings
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSavings.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSavings.Legends.Add(legend1);
            this.chartSavings.Location = new System.Drawing.Point(369, 48);
            this.chartSavings.Name = "chartSavings";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSavings.Series.Add(series1);
            this.chartSavings.Size = new System.Drawing.Size(441, 409);
            this.chartSavings.TabIndex = 13;
            this.chartSavings.Text = "chart1";
            // 
            // btnPlotGraph
            // 
            this.btnPlotGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.btnPlotGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlotGraph.FlatAppearance.BorderSize = 0;
            this.btnPlotGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(242)))));
            this.btnPlotGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlotGraph.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlotGraph.ForeColor = System.Drawing.Color.White;
            this.btnPlotGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlotGraph.Location = new System.Drawing.Point(52, 455);
            this.btnPlotGraph.Name = "btnPlotGraph";
            this.btnPlotGraph.Size = new System.Drawing.Size(250, 40);
            this.btnPlotGraph.TabIndex = 14;
            this.btnPlotGraph.Text = "Plot Graph";
            this.btnPlotGraph.UseVisualStyleBackColor = false;
            this.btnPlotGraph.Click += new System.EventHandler(this.btnPlotGraph_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Month";
            this.Column2.Name = "Column2";
            // 
            // DataVisualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 507);
            this.Controls.Add(this.btnPlotGraph);
            this.Controls.Add(this.chartSavings);
            this.Controls.Add(this.dgvSavings);
            this.Controls.Add(this.label8);
            this.Name = "DataVisualisation";
            this.Text = "DataVisualisation";
            this.Load += new System.EventHandler(this.DataVisualisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSavings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvSavings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSavings;
        private System.Windows.Forms.Button btnPlotGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}