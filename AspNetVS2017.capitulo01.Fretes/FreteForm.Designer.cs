namespace AspNetVS2017.capitulo01.Fretes
{
    partial class FreteForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.valortextBox = new System.Windows.Forms.TextBox();
            this.fretetextBox = new System.Windows.Forms.TextBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.ufcomboBox = new System.Windows.Forms.ComboBox();
            this.calcularbutton = new System.Windows.Forms.Button();
            this.limparbutton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 13);
            label1.TabIndex = 0;
            label1.Text = "&Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total:";
            // 
            // clientetextBox
            // 
            this.clientetextBox.Location = new System.Drawing.Point(60, 22);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.Size = new System.Drawing.Size(243, 20);
            this.clientetextBox.TabIndex = 1;
            this.clientetextBox.TextChanged += new System.EventHandler(this.clientetextBox_TextChanged);
            // 
            // valortextBox
            // 
            this.valortextBox.Location = new System.Drawing.Point(60, 60);
            this.valortextBox.Name = "valortextBox";
            this.valortextBox.Size = new System.Drawing.Size(133, 20);
            this.valortextBox.TabIndex = 3;
            // 
            // fretetextBox
            // 
            this.fretetextBox.Location = new System.Drawing.Point(60, 136);
            this.fretetextBox.Name = "fretetextBox";
            this.fretetextBox.ReadOnly = true;
            this.fretetextBox.Size = new System.Drawing.Size(133, 20);
            this.fretetextBox.TabIndex = 7;
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(60, 174);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.ReadOnly = true;
            this.totaltextBox.Size = new System.Drawing.Size(133, 20);
            this.totaltextBox.TabIndex = 9;
            // 
            // ufcomboBox
            // 
            this.ufcomboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ufcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ufcomboBox.FormattingEnabled = true;
            this.ufcomboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.ufcomboBox.Location = new System.Drawing.Point(60, 98);
            this.ufcomboBox.Name = "ufcomboBox";
            this.ufcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ufcomboBox.TabIndex = 5;
            // 
            // calcularbutton
            // 
            this.calcularbutton.Location = new System.Drawing.Point(228, 257);
            this.calcularbutton.Name = "calcularbutton";
            this.calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.calcularbutton.TabIndex = 10;
            this.calcularbutton.Text = "C&alcular";
            this.calcularbutton.UseVisualStyleBackColor = true;
            this.calcularbutton.Click += new System.EventHandler(this.calcularbutton_Click);
            // 
            // limparbutton
            // 
            this.limparbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparbutton.Location = new System.Drawing.Point(228, 286);
            this.limparbutton.Name = "limparbutton";
            this.limparbutton.Size = new System.Drawing.Size(75, 23);
            this.limparbutton.TabIndex = 11;
            this.limparbutton.Text = "&Limpar";
            this.limparbutton.UseVisualStyleBackColor = true;
            // 
            // FreteForm
            // 
            this.AcceptButton = this.calcularbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparbutton;
            this.ClientSize = new System.Drawing.Size(319, 323);
            this.Controls.Add(this.limparbutton);
            this.Controls.Add(this.calcularbutton);
            this.Controls.Add(this.ufcomboBox);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.fretetextBox);
            this.Controls.Add(this.valortextBox);
            this.Controls.Add(this.clientetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Name = "FreteForm";
            this.Text = "Frete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientetextBox;
        private System.Windows.Forms.TextBox valortextBox;
        private System.Windows.Forms.TextBox fretetextBox;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.ComboBox ufcomboBox;
        private System.Windows.Forms.Button calcularbutton;
        private System.Windows.Forms.Button limparbutton;
    }
}

