
namespace MiPrimeraApp
{
    partial class Home
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.chkBanano = new System.Windows.Forms.CheckBox();
            this.chkSandia = new System.Windows.Forms.CheckBox();
            this.chkMandarina = new System.Windows.Forms.CheckBox();
            this.chkPiña = new System.Windows.Forms.CheckBox();
            this.chkManza = new System.Windows.Forms.CheckBox();
            this.btnSaved = new System.Windows.Forms.Button();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.rdoConbolsa = new System.Windows.Forms.RadioButton();
            this.rdoSinBol = new System.Windows.Forms.RadioButton();
            this.lblBolsa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(61, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(252, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutas.Location = new System.Drawing.Point(190, 9);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(137, 39);
            this.lblFrutas.TabIndex = 4;
            this.lblFrutas.Text = "Fruteria";
            // 
            // chkBanano
            // 
            this.chkBanano.AutoSize = true;
            this.chkBanano.Location = new System.Drawing.Point(64, 109);
            this.chkBanano.Name = "chkBanano";
            this.chkBanano.Size = new System.Drawing.Size(63, 17);
            this.chkBanano.TabIndex = 5;
            this.chkBanano.Text = "Banano";
            this.chkBanano.UseVisualStyleBackColor = true;
            // 
            // chkSandia
            // 
            this.chkSandia.AutoSize = true;
            this.chkSandia.Location = new System.Drawing.Point(64, 247);
            this.chkSandia.Name = "chkSandia";
            this.chkSandia.Size = new System.Drawing.Size(59, 17);
            this.chkSandia.TabIndex = 6;
            this.chkSandia.Text = "Sandia";
            this.chkSandia.UseVisualStyleBackColor = true;
            // 
            // chkMandarina
            // 
            this.chkMandarina.AutoSize = true;
            this.chkMandarina.Location = new System.Drawing.Point(64, 213);
            this.chkMandarina.Name = "chkMandarina";
            this.chkMandarina.Size = new System.Drawing.Size(76, 17);
            this.chkMandarina.TabIndex = 7;
            this.chkMandarina.Text = "Mandarina";
            this.chkMandarina.UseVisualStyleBackColor = true;
            // 
            // chkPiña
            // 
            this.chkPiña.AutoSize = true;
            this.chkPiña.Location = new System.Drawing.Point(64, 178);
            this.chkPiña.Name = "chkPiña";
            this.chkPiña.Size = new System.Drawing.Size(47, 17);
            this.chkPiña.TabIndex = 8;
            this.chkPiña.Text = "Piña";
            this.chkPiña.UseVisualStyleBackColor = true;
            // 
            // chkManza
            // 
            this.chkManza.AutoSize = true;
            this.chkManza.Location = new System.Drawing.Point(64, 142);
            this.chkManza.Name = "chkManza";
            this.chkManza.Size = new System.Drawing.Size(70, 17);
            this.chkManza.TabIndex = 9;
            this.chkManza.Text = "Manzana";
            this.chkManza.UseVisualStyleBackColor = true;
            // 
            // btnSaved
            // 
            this.btnSaved.Location = new System.Drawing.Point(159, 300);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(75, 23);
            this.btnSaved.TabIndex = 10;
            this.btnSaved.Text = "Llevar";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(531, 109);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(231, 175);
            this.rtxtResults.TabIndex = 11;
            this.rtxtResults.Text = "";
            // 
            // rdoConbolsa
            // 
            this.rdoConbolsa.AutoSize = true;
            this.rdoConbolsa.Location = new System.Drawing.Point(255, 124);
            this.rdoConbolsa.Name = "rdoConbolsa";
            this.rdoConbolsa.Size = new System.Drawing.Size(66, 17);
            this.rdoConbolsa.TabIndex = 12;
            this.rdoConbolsa.TabStop = true;
            this.rdoConbolsa.Text = "En bolsa";
            this.rdoConbolsa.UseVisualStyleBackColor = true;
            // 
            // rdoSinBol
            // 
            this.rdoSinBol.AutoSize = true;
            this.rdoSinBol.Location = new System.Drawing.Point(255, 148);
            this.rdoSinBol.Name = "rdoSinBol";
            this.rdoSinBol.Size = new System.Drawing.Size(68, 17);
            this.rdoSinBol.TabIndex = 13;
            this.rdoSinBol.TabStop = true;
            this.rdoSinBol.Text = "Sin bolsa";
            this.rdoSinBol.UseVisualStyleBackColor = true;
            // 
            // lblBolsa
            // 
            this.lblBolsa.AutoSize = true;
            this.lblBolsa.Location = new System.Drawing.Point(263, 99);
            this.lblBolsa.Name = "lblBolsa";
            this.lblBolsa.Size = new System.Drawing.Size(36, 13);
            this.lblBolsa.TabIndex = 14;
            this.lblBolsa.Text = "Bolsa:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBolsa);
            this.Controls.Add(this.rdoSinBol);
            this.Controls.Add(this.rdoConbolsa);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.chkManza);
            this.Controls.Add(this.chkPiña);
            this.Controls.Add(this.chkMandarina);
            this.Controls.Add(this.chkSandia);
            this.Controls.Add(this.chkBanano);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFrutas;
        private System.Windows.Forms.CheckBox chkBanano;
        private System.Windows.Forms.CheckBox chkSandia;
        private System.Windows.Forms.CheckBox chkMandarina;
        private System.Windows.Forms.CheckBox chkPiña;
        private System.Windows.Forms.CheckBox chkManza;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.RadioButton rdoConbolsa;
        private System.Windows.Forms.RadioButton rdoSinBol;
        private System.Windows.Forms.Label lblBolsa;
    }
}

