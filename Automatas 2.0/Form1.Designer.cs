namespace Automatas_2._0
{
    partial class Form1
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
            this.automataGB = new System.Windows.Forms.GroupBox();
            this.transactionsBtn = new System.Windows.Forms.Button();
            this.checkedFinal = new System.Windows.Forms.CheckedListBox();
            this.estadoInicial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colOrigen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAlfabeto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inputBtn = new System.Windows.Forms.Button();
            this.alfabetoTb = new System.Windows.Forms.TextBox();
            this.numEstados = new System.Windows.Forms.TextBox();
            this.alfabetoLBL = new System.Windows.Forms.Label();
            this.numEstadosLBL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.automataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // automataGB
            // 
            this.automataGB.Controls.Add(this.transactionsBtn);
            this.automataGB.Controls.Add(this.checkedFinal);
            this.automataGB.Controls.Add(this.estadoInicial);
            this.automataGB.Controls.Add(this.label3);
            this.automataGB.Controls.Add(this.label2);
            this.automataGB.Controls.Add(this.dataGridView1);
            this.automataGB.Controls.Add(this.inputBtn);
            this.automataGB.Controls.Add(this.alfabetoTb);
            this.automataGB.Controls.Add(this.numEstados);
            this.automataGB.Controls.Add(this.alfabetoLBL);
            this.automataGB.Controls.Add(this.numEstadosLBL);
            this.automataGB.Location = new System.Drawing.Point(24, 53);
            this.automataGB.Name = "automataGB";
            this.automataGB.Size = new System.Drawing.Size(554, 342);
            this.automataGB.TabIndex = 0;
            this.automataGB.TabStop = false;
            this.automataGB.Text = "Añadir automata";
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.Location = new System.Drawing.Point(22, 310);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(345, 23);
            this.transactionsBtn.TabIndex = 11;
            this.transactionsBtn.Text = "Anadir Transacciones";
            this.transactionsBtn.UseVisualStyleBackColor = true;
            this.transactionsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedFinal
            // 
            this.checkedFinal.FormattingEnabled = true;
            this.checkedFinal.Location = new System.Drawing.Point(400, 153);
            this.checkedFinal.Name = "checkedFinal";
            this.checkedFinal.Size = new System.Drawing.Size(120, 94);
            this.checkedFinal.TabIndex = 9;
            // 
            // estadoInicial
            // 
            this.estadoInicial.AutoSize = true;
            this.estadoInicial.Location = new System.Drawing.Point(397, 64);
            this.estadoInicial.Name = "estadoInicial";
            this.estadoInicial.Size = new System.Drawing.Size(23, 13);
            this.estadoInicial.TabIndex = 8;
            this.estadoInicial.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estados de aceptacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado inicial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigen,
            this.colAlfabeto,
            this.colDestino});
            this.dataGridView1.Location = new System.Drawing.Point(15, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.Name = "colOrigen";
            // 
            // colAlfabeto
            // 
            this.colAlfabeto.HeaderText = "Alfabeto";
            this.colAlfabeto.Name = "colAlfabeto";
            // 
            // colDestino
            // 
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(148, 109);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(75, 23);
            this.inputBtn.TabIndex = 4;
            this.inputBtn.Text = "Ingresar";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // alfabetoTb
            // 
            this.alfabetoTb.Location = new System.Drawing.Point(15, 112);
            this.alfabetoTb.Name = "alfabetoTb";
            this.alfabetoTb.Size = new System.Drawing.Size(100, 20);
            this.alfabetoTb.TabIndex = 3;
            // 
            // numEstados
            // 
            this.numEstados.Location = new System.Drawing.Point(15, 64);
            this.numEstados.Name = "numEstados";
            this.numEstados.Size = new System.Drawing.Size(100, 20);
            this.numEstados.TabIndex = 2;
            // 
            // alfabetoLBL
            // 
            this.alfabetoLBL.AutoSize = true;
            this.alfabetoLBL.Location = new System.Drawing.Point(12, 87);
            this.alfabetoLBL.Name = "alfabetoLBL";
            this.alfabetoLBL.Size = new System.Drawing.Size(46, 13);
            this.alfabetoLBL.TabIndex = 1;
            this.alfabetoLBL.Text = "Alfabeto";
            // 
            // numEstadosLBL
            // 
            this.numEstadosLBL.AutoSize = true;
            this.numEstadosLBL.Location = new System.Drawing.Point(16, 33);
            this.numEstadosLBL.Name = "numEstadosLBL";
            this.numEstadosLBL.Size = new System.Drawing.Size(99, 13);
            this.numEstadosLBL.TabIndex = 0;
            this.numEstadosLBL.Text = "Numero de estados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.automataGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.automataGB.ResumeLayout(false);
            this.automataGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox automataGB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox alfabetoTb;
        private System.Windows.Forms.TextBox numEstados;
        private System.Windows.Forms.Label alfabetoLBL;
        private System.Windows.Forms.Label numEstadosLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedFinal;
        private System.Windows.Forms.Label estadoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAlfabeto;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDestino;
        private System.Windows.Forms.Button transactionsBtn;
    }
}

