namespace Pie_chart
{
    partial class frmSector
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColvoEl = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            this.chartSector = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateDiag = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.txtColvoEl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідні дані";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btCreateDiag);
            this.groupBox2.Controls.Add(this.chartSector);
            this.groupBox2.Location = new System.Drawing.Point(5, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 393);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Побудова діаграми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість елементів:";
            // 
            // txtColvoEl
            // 
            this.txtColvoEl.Location = new System.Drawing.Point(24, 62);
            this.txtColvoEl.Name = "txtColvoEl";
            this.txtColvoEl.Size = new System.Drawing.Size(245, 22);
            this.txtColvoEl.TabIndex = 1;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(24, 108);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(245, 40);
            this.btGenerate.TabIndex = 2;
            this.btGenerate.Text = "Згенерувати пустий одновимірний масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(315, 21);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(605, 150);
            this.dgvMass.TabIndex = 3;
            // 
            // chartSector
            // 
            this.chartSector.BackColor = System.Drawing.Color.SkyBlue;
            this.chartSector.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartSector.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea3.Name = "ChartArea1";
            this.chartSector.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSector.Legends.Add(legend3);
            this.chartSector.Location = new System.Drawing.Point(24, 36);
            this.chartSector.Name = "chartSector";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Sector";
            this.chartSector.Series.Add(series3);
            this.chartSector.Size = new System.Drawing.Size(709, 338);
            this.chartSector.TabIndex = 0;
            this.chartSector.Text = "chart1";
            // 
            // btCreateDiag
            // 
            this.btCreateDiag.Location = new System.Drawing.Point(755, 63);
            this.btCreateDiag.Name = "btCreateDiag";
            this.btCreateDiag.Size = new System.Drawing.Size(165, 65);
            this.btCreateDiag.TabIndex = 1;
            this.btCreateDiag.Text = "Побудувати секторну діаграму";
            this.btCreateDiag.UseVisualStyleBackColor = true;
            this.btCreateDiag.Click += new System.EventHandler(this.btCreateDiag_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(755, 160);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(165, 65);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSector";
            this.Text = "Секторна діаграма";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox txtColvoEl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCreateDiag;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSector;
    }
}

