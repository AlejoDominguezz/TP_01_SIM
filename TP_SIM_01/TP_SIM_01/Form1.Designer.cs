
namespace TP_SIM_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.dgvAleatoriosMixto = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAleatoriosMixto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de xo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de g:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad nros generar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor de k:";
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(170, 43);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(66, 20);
            this.txtXo.TabIndex = 5;
            this.txtXo.TextChanged += new System.EventHandler(this.txtXo_TextChanged);
            this.txtXo.Leave += new System.EventHandler(this.txtXo_Leave);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(170, 81);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(66, 20);
            this.txtK.TabIndex = 6;
            this.txtK.Leave += new System.EventHandler(this.txtK_Leave);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(170, 115);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(66, 20);
            this.txtG.TabIndex = 7;
            this.txtG.Leave += new System.EventHandler(this.txtG_Leave);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(170, 154);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(66, 20);
            this.txtC.TabIndex = 8;
            this.txtC.Leave += new System.EventHandler(this.txtC_Leave);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(226, 192);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(66, 20);
            this.txtN.TabIndex = 9;
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // dgvAleatoriosMixto
            // 
            this.dgvAleatoriosMixto.AllowUserToAddRows = false;
            this.dgvAleatoriosMixto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAleatoriosMixto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.xi,
            this.rnd});
            this.dgvAleatoriosMixto.Location = new System.Drawing.Point(109, 244);
            this.dgvAleatoriosMixto.Name = "dgvAleatoriosMixto";
            this.dgvAleatoriosMixto.Size = new System.Drawing.Size(344, 128);
            this.dgvAleatoriosMixto.TabIndex = 10;
            this.dgvAleatoriosMixto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAleatoriosMixto_CellContentClick);
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // xi
            // 
            this.xi.HeaderText = "xi";
            this.xi.Name = "xi";
            this.xi.ReadOnly = true;
            // 
            // rnd
            // 
            this.rnd.HeaderText = "rnd";
            this.rnd.Name = "rnd";
            this.rnd.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(378, 392);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(291, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(525, 429);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(75, 35);
            this.btnGrafico.TabIndex = 13;
            this.btnGrafico.Text = "Generar Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 476);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvAleatoriosMixto);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAleatoriosMixto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.DataGridView dgvAleatoriosMixto;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGrafico;
    }
}

