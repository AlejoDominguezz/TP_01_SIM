
namespace TP_SIM_01
{
    partial class Form2
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
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvMultiplicativo = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicativo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(115, 59);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(65, 13);
            this.lblX0.TabIndex = 0;
            this.lblX0.Text = "Valor de X0:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(117, 93);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(44, 13);
            this.lblK.TabIndex = 1;
            this.lblK.Text = "Valor K:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(116, 128);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(45, 13);
            this.lblG.TabIndex = 2;
            this.lblG.Text = "Valor G:";
            this.lblG.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(115, 162);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad nros:";
            // 
            // dgvMultiplicativo
            // 
            this.dgvMultiplicativo.AllowUserToAddRows = false;
            this.dgvMultiplicativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultiplicativo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.xi,
            this.RND});
            this.dgvMultiplicativo.Location = new System.Drawing.Point(106, 203);
            this.dgvMultiplicativo.Name = "dgvMultiplicativo";
            this.dgvMultiplicativo.Size = new System.Drawing.Size(344, 150);
            this.dgvMultiplicativo.TabIndex = 4;
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
            // RND
            // 
            this.RND.HeaderText = "RND";
            this.RND.Name = "RND";
            this.RND.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(375, 162);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(195, 56);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(53, 20);
            this.txtX0.TabIndex = 6;
            this.txtX0.Leave += new System.EventHandler(this.txtX0_Leave);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(195, 90);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(53, 20);
            this.txtK.TabIndex = 7;
            this.txtK.Leave += new System.EventHandler(this.txtK_Leave);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(195, 125);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(53, 20);
            this.txtG.TabIndex = 8;
            this.txtG.Leave += new System.EventHandler(this.txtG_Leave);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(196, 159);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(53, 20);
            this.txtN.TabIndex = 9;
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(375, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar Grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvMultiplicativo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblX0);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultiplicativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvMultiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}