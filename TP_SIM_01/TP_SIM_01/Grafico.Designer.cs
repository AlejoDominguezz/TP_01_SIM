
namespace TP_SIM_01
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkInt5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcadeclase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chrtDistribucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Has = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Css = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chrtChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblconclusion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).BeginInit();
            this.SuspendLayout();
            // 
            // checkInt5
            // 
            this.checkInt5.AutoSize = true;
            this.checkInt5.Location = new System.Drawing.Point(276, 13);
            this.checkInt5.Name = "checkInt5";
            this.checkInt5.Size = new System.Drawing.Size(76, 17);
            this.checkInt5.TabIndex = 0;
            this.checkInt5.Text = "Intervalo 5";
            this.checkInt5.UseVisualStyleBackColor = true;
            this.checkInt5.CheckedChanged += new System.EventHandler(this.checkInt5_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.Marcadeclase,
            this.FrecuenciaObservada,
            this.Probabilidad,
            this.FrecuenciaEsperada});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            this.Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // Marcadeclase
            // 
            this.Marcadeclase.HeaderText = "Marca de clase";
            this.Marcadeclase.Name = "Marcadeclase";
            this.Marcadeclase.ReadOnly = true;
            // 
            // FrecuenciaObservada
            // 
            this.FrecuenciaObservada.HeaderText = "Frecuencia Observada";
            this.FrecuenciaObservada.Name = "FrecuenciaObservada";
            this.FrecuenciaObservada.ReadOnly = true;
            // 
            // Probabilidad
            // 
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.Name = "Probabilidad";
            this.Probabilidad.ReadOnly = true;
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "FrecuenciaEsperada";
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            this.FrecuenciaEsperada.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(440, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Intervalo 10";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(358, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Intervalo 8";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(528, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Intervalo 12";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chrtDistribucion
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtDistribucion.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtDistribucion.Legends.Add(legend5);
            this.chrtDistribucion.Location = new System.Drawing.Point(12, 309);
            this.chrtDistribucion.Name = "chrtDistribucion";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrtDistribucion.Series.Add(series5);
            this.chrtDistribucion.Size = new System.Drawing.Size(644, 330);
            this.chrtDistribucion.TabIndex = 6;
            this.chrtDistribucion.Text = "chrtDistribucion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad de intervalos:";
            // 
            // dgvChi
            // 
            this.dgvChi.AllowUserToAddRows = false;
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Des,
            this.Has,
            this.fo,
            this.fe,
            this.c,
            this.Css});
            this.dgvChi.Location = new System.Drawing.Point(695, 65);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.Size = new System.Drawing.Size(646, 231);
            this.dgvChi.TabIndex = 9;
            // 
            // Des
            // 
            this.Des.HeaderText = "Desde";
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            // 
            // Has
            // 
            this.Has.HeaderText = "Hasta";
            this.Has.Name = "Has";
            this.Has.ReadOnly = true;
            // 
            // fo
            // 
            this.fo.HeaderText = "Frecuencia Observada";
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            // 
            // fe
            // 
            this.fe.HeaderText = "Frecuencia Esperada";
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "C()";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // Css
            // 
            this.Css.HeaderText = "C(acu)";
            this.Css.Name = "Css";
            this.Css.ReadOnly = true;
            // 
            // chrtChi
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtChi.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrtChi.Legends.Add(legend6);
            this.chrtChi.Location = new System.Drawing.Point(695, 366);
            this.chrtChi.Name = "chrtChi";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chrtChi.Series.Add(series6);
            this.chrtChi.Size = new System.Drawing.Size(520, 273);
            this.chrtChi.TabIndex = 10;
            this.chrtChi.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor calculado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor tabla:";
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.Location = new System.Drawing.Point(781, 309);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(0, 13);
            this.lblCalculado.TabIndex = 14;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(758, 339);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(0, 13);
            this.lblTabla.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblconclusion
            // 
            this.lblconclusion.AutoSize = true;
            this.lblconclusion.Location = new System.Drawing.Point(889, 309);
            this.lblconclusion.Name = "lblconclusion";
            this.lblconclusion.Size = new System.Drawing.Size(0, 13);
            this.lblconclusion.TabIndex = 18;
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblconclusion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chrtChi);
            this.Controls.Add(this.dgvChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrtDistribucion);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkInt5);
            this.Name = "Grafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkInt5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcadeclase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDistribucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn Has;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Css;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblconclusion;
    }
}