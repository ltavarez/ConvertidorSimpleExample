namespace ConvertidorSimpleDeMoneda
{
    partial class FrmConvertidor
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
            this.LblMonedaOrigen = new System.Windows.Forms.Label();
            this.LblMonedaDestino = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CbxMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.CbxMonedaDestino = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMonedaOrigen
            // 
            this.LblMonedaOrigen.AutoSize = true;
            this.LblMonedaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaOrigen.Location = new System.Drawing.Point(36, 30);
            this.LblMonedaOrigen.Name = "LblMonedaOrigen";
            this.LblMonedaOrigen.Size = new System.Drawing.Size(144, 17);
            this.LblMonedaOrigen.TabIndex = 0;
            this.LblMonedaOrigen.Text = "Moneda de origen:";
            // 
            // LblMonedaDestino
            // 
            this.LblMonedaDestino.AutoSize = true;
            this.LblMonedaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaDestino.Location = new System.Drawing.Point(29, 69);
            this.LblMonedaDestino.Name = "LblMonedaDestino";
            this.LblMonedaDestino.Size = new System.Drawing.Size(151, 17);
            this.LblMonedaDestino.TabIndex = 1;
            this.LblMonedaDestino.Text = "Moneda de destino:";
            this.LblMonedaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(20, 111);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(160, 17);
            this.LblCantidad.TabIndex = 2;
            this.LblCantidad.Text = "Cantidad a convertir:";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(94, 150);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(86, 17);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "Resultado:";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(186, 150);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(153, 20);
            this.TxtResultado.TabIndex = 5;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(186, 108);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(153, 20);
            this.TxtCantidad.TabIndex = 3;
            // 
            // CbxMonedaOrigen
            // 
            this.CbxMonedaOrigen.FormattingEnabled = true;
            this.CbxMonedaOrigen.Location = new System.Drawing.Point(186, 26);
            this.CbxMonedaOrigen.Name = "CbxMonedaOrigen";
            this.CbxMonedaOrigen.Size = new System.Drawing.Size(153, 21);
            this.CbxMonedaOrigen.TabIndex = 1;
            this.CbxMonedaOrigen.SelectedIndexChanged += new System.EventHandler(this.CbxMonedaOrigen_SelectedIndexChanged);
            // 
            // CbxMonedaDestino
            // 
            this.CbxMonedaDestino.FormattingEnabled = true;
            this.CbxMonedaDestino.Location = new System.Drawing.Point(186, 65);
            this.CbxMonedaDestino.Name = "CbxMonedaDestino";
            this.CbxMonedaDestino.Size = new System.Drawing.Size(153, 21);
            this.CbxMonedaDestino.TabIndex = 2;
            this.CbxMonedaDestino.SelectedIndexChanged += new System.EventHandler(this.CbxMonedaDestino_SelectedIndexChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(186, 202);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(153, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 283);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.CbxMonedaDestino);
            this.Controls.Add(this.CbxMonedaOrigen);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblMonedaDestino);
            this.Controls.Add(this.LblMonedaOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConvertidor";
            this.Text = "Convertidor";
            this.Load += new System.EventHandler(this.FrmConvertidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMonedaOrigen;
        private System.Windows.Forms.Label LblMonedaDestino;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CbxMonedaOrigen;
        private System.Windows.Forms.ComboBox CbxMonedaDestino;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

