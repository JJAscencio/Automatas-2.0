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
            this.button1 = new System.Windows.Forms.Button();
            this.automataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // automataGB
            // 
            this.automataGB.Controls.Add(this.button1);
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
            this.automataGB.Location = new System.Drawing.Point(32, 65);
            this.automataGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automataGB.Name = "automataGB";
            this.automataGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automataGB.Size = new System.Drawing.Size(701, 554);
            this.automataGB.TabIndex = 0;
            this.automataGB.TabStop = false;
            this.automataGB.Text = "Añadir automata";
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.Location = new System.Drawing.Point(29, 382);
            this.transactionsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(460, 28);
            this.transactionsBtn.TabIndex = 11;
            this.transactionsBtn.Text = "Anadir Transacciones";
            this.transactionsBtn.UseVisualStyleBackColor = true;
            this.transactionsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedFinal
            // 
            this.checkedFinal.FormattingEnabled = true;
            this.checkedFinal.Location = new System.Drawing.Point(533, 188);
            this.checkedFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedFinal.Name = "checkedFinal";
            this.checkedFinal.Size = new System.Drawing.Size(159, 106);
            this.checkedFinal.TabIndex = 9;
            // 
            // estadoInicial
            // 
            this.estadoInicial.AutoSize = true;
            this.estadoInicial.Location = new System.Drawing.Point(529, 79);
            this.estadoInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoInicial.Name = "estadoInicial";
            this.estadoInicial.Size = new System.Drawing.Size(30, 17);
            this.estadoInicial.TabIndex = 8;
            this.estadoInicial.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estados de aceptacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 185);
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
            this.inputBtn.Location = new System.Drawing.Point(197, 134);
            this.inputBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(100, 28);
            this.inputBtn.TabIndex = 4;
            this.inputBtn.Text = "Ingresar";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // alfabetoTb
            // 
            this.alfabetoTb.Location = new System.Drawing.Point(20, 138);
            this.alfabetoTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alfabetoTb.Name = "alfabetoTb";
            this.alfabetoTb.Size = new System.Drawing.Size(132, 22);
            this.alfabetoTb.TabIndex = 3;
            // 
            // numEstados
            // 
            this.numEstados.Location = new System.Drawing.Point(20, 79);
            this.numEstados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numEstados.Name = "numEstados";
            this.numEstados.Size = new System.Drawing.Size(132, 22);
            this.numEstados.TabIndex = 2;
            // 
            // alfabetoLBL
            // 
            this.alfabetoLBL.AutoSize = true;
            this.alfabetoLBL.Location = new System.Drawing.Point(16, 107);
            this.alfabetoLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alfabetoLBL.Name = "alfabetoLBL";
            this.alfabetoLBL.Size = new System.Drawing.Size(60, 17);
            this.alfabetoLBL.TabIndex = 1;
            this.alfabetoLBL.Text = "Alfabeto";
            // 
            // numEstadosLBL
            // 
            this.numEstadosLBL.AutoSize = true;
            this.numEstadosLBL.Location = new System.Drawing.Point(21, 41);
            this.numEstadosLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numEstadosLBL.Name = "numEstadosLBL";
            this.numEstadosLBL.Size = new System.Drawing.Size(132, 17);
            this.numEstadosLBL.TabIndex = 0;
            this.numEstadosLBL.Text = "Numero de estados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 683);
            this.Controls.Add(this.automataGB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.automataGB.ResumeLayout(false);
            this.automataGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckedListBox checkedFinal;
        private System.Windows.Forms.Label estadoInicial;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAlfabeto;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDestino;
        private System.Windows.Forms.Button transactionsBtn;
        private System.Windows.Forms.Button button1;
    }
}

