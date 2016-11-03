namespace Calculadora
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
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.bSiete = new System.Windows.Forms.Button();
            this.bMultiplicacion = new System.Windows.Forms.Button();
            this.bNueve = new System.Windows.Forms.Button();
            this.bOcho = new System.Windows.Forms.Button();
            this.bSeis = new System.Windows.Forms.Button();
            this.bResta = new System.Windows.Forms.Button();
            this.bCinco = new System.Windows.Forms.Button();
            this.bCuatro = new System.Windows.Forms.Button();
            this.bSuma = new System.Windows.Forms.Button();
            this.bTres = new System.Windows.Forms.Button();
            this.bDos = new System.Windows.Forms.Button();
            this.bUno = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.bComa = new System.Windows.Forms.Button();
            this.bCero = new System.Windows.Forms.Button();
            this.bMasMenos = new System.Windows.Forms.Button();
            this.bDividir = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultat
            // 
            this.lblResultat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblResultat.Location = new System.Drawing.Point(1, 33);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(259, 66);
            this.lblResultat.TabIndex = 0;
            this.lblResultat.Text = "0";
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblOperacion
            // 
            this.lblOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperacion.Location = new System.Drawing.Point(-2, 13);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(262, 20);
            this.lblOperacion.TabIndex = 1;
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // bSiete
            // 
            this.bSiete.Location = new System.Drawing.Point(12, 216);
            this.bSiete.Name = "bSiete";
            this.bSiete.Size = new System.Drawing.Size(55, 55);
            this.bSiete.TabIndex = 2;
            this.bSiete.TabStop = false;
            this.bSiete.Text = "7";
            this.bSiete.UseVisualStyleBackColor = true;
            this.bSiete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bMultiplicacion
            // 
            this.bMultiplicacion.Location = new System.Drawing.Point(195, 216);
            this.bMultiplicacion.Name = "bMultiplicacion";
            this.bMultiplicacion.Size = new System.Drawing.Size(55, 55);
            this.bMultiplicacion.TabIndex = 3;
            this.bMultiplicacion.TabStop = false;
            this.bMultiplicacion.Text = "X";
            this.bMultiplicacion.UseVisualStyleBackColor = true;
            this.bMultiplicacion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bMultiplicacion_MouseUp);
            // 
            // bNueve
            // 
            this.bNueve.Location = new System.Drawing.Point(134, 216);
            this.bNueve.Name = "bNueve";
            this.bNueve.Size = new System.Drawing.Size(55, 55);
            this.bNueve.TabIndex = 4;
            this.bNueve.TabStop = false;
            this.bNueve.Text = "9";
            this.bNueve.UseVisualStyleBackColor = true;
            this.bNueve.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bOcho
            // 
            this.bOcho.Location = new System.Drawing.Point(73, 216);
            this.bOcho.Name = "bOcho";
            this.bOcho.Size = new System.Drawing.Size(55, 55);
            this.bOcho.TabIndex = 5;
            this.bOcho.TabStop = false;
            this.bOcho.Text = "8";
            this.bOcho.UseVisualStyleBackColor = true;
            this.bOcho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bSeis
            // 
            this.bSeis.Location = new System.Drawing.Point(134, 277);
            this.bSeis.Name = "bSeis";
            this.bSeis.Size = new System.Drawing.Size(55, 55);
            this.bSeis.TabIndex = 6;
            this.bSeis.TabStop = false;
            this.bSeis.Text = "6";
            this.bSeis.UseVisualStyleBackColor = true;
            this.bSeis.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bResta
            // 
            this.bResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bResta.Location = new System.Drawing.Point(195, 277);
            this.bResta.Name = "bResta";
            this.bResta.Size = new System.Drawing.Size(55, 55);
            this.bResta.TabIndex = 7;
            this.bResta.TabStop = false;
            this.bResta.Text = "-";
            this.bResta.UseVisualStyleBackColor = true;
            this.bResta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bResta_MouseUp);
            // 
            // bCinco
            // 
            this.bCinco.Location = new System.Drawing.Point(73, 277);
            this.bCinco.Name = "bCinco";
            this.bCinco.Size = new System.Drawing.Size(55, 55);
            this.bCinco.TabIndex = 8;
            this.bCinco.TabStop = false;
            this.bCinco.Text = "5";
            this.bCinco.UseVisualStyleBackColor = true;
            this.bCinco.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bCuatro
            // 
            this.bCuatro.Location = new System.Drawing.Point(12, 277);
            this.bCuatro.Name = "bCuatro";
            this.bCuatro.Size = new System.Drawing.Size(55, 55);
            this.bCuatro.TabIndex = 9;
            this.bCuatro.TabStop = false;
            this.bCuatro.Text = "4";
            this.bCuatro.UseVisualStyleBackColor = true;
            this.bCuatro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bSuma
            // 
            this.bSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bSuma.Location = new System.Drawing.Point(195, 338);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(55, 55);
            this.bSuma.TabIndex = 10;
            this.bSuma.TabStop = false;
            this.bSuma.Text = "+";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bSuma_MouseUp);
            // 
            // bTres
            // 
            this.bTres.Location = new System.Drawing.Point(134, 338);
            this.bTres.Name = "bTres";
            this.bTres.Size = new System.Drawing.Size(55, 55);
            this.bTres.TabIndex = 11;
            this.bTres.TabStop = false;
            this.bTres.Text = "3";
            this.bTres.UseVisualStyleBackColor = true;
            this.bTres.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bDos
            // 
            this.bDos.Location = new System.Drawing.Point(73, 338);
            this.bDos.Name = "bDos";
            this.bDos.Size = new System.Drawing.Size(55, 55);
            this.bDos.TabIndex = 12;
            this.bDos.TabStop = false;
            this.bDos.Text = "2";
            this.bDos.UseVisualStyleBackColor = true;
            this.bDos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bUno
            // 
            this.bUno.Location = new System.Drawing.Point(12, 338);
            this.bUno.Name = "bUno";
            this.bUno.Size = new System.Drawing.Size(55, 55);
            this.bUno.TabIndex = 13;
            this.bUno.TabStop = false;
            this.bUno.Text = "1";
            this.bUno.UseVisualStyleBackColor = true;
            this.bUno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bIgual
            // 
            this.bIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bIgual.Location = new System.Drawing.Point(195, 399);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(55, 55);
            this.bIgual.TabIndex = 14;
            this.bIgual.TabStop = false;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = true;
            this.bIgual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bIgual_MouseUp);
            // 
            // bComa
            // 
            this.bComa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bComa.Location = new System.Drawing.Point(134, 399);
            this.bComa.Name = "bComa";
            this.bComa.Size = new System.Drawing.Size(55, 55);
            this.bComa.TabIndex = 15;
            this.bComa.TabStop = false;
            this.bComa.Text = ",";
            this.bComa.UseVisualStyleBackColor = true;
            this.bComa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bComa_MouseUp);
            // 
            // bCero
            // 
            this.bCero.Location = new System.Drawing.Point(73, 399);
            this.bCero.Name = "bCero";
            this.bCero.Size = new System.Drawing.Size(55, 55);
            this.bCero.TabIndex = 16;
            this.bCero.TabStop = false;
            this.bCero.Text = "0";
            this.bCero.UseVisualStyleBackColor = true;
            this.bCero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsNumero_MouseUp);
            // 
            // bMasMenos
            // 
            this.bMasMenos.Location = new System.Drawing.Point(12, 399);
            this.bMasMenos.Name = "bMasMenos";
            this.bMasMenos.Size = new System.Drawing.Size(55, 55);
            this.bMasMenos.TabIndex = 17;
            this.bMasMenos.TabStop = false;
            this.bMasMenos.Text = "+/-";
            this.bMasMenos.UseVisualStyleBackColor = true;
            // 
            // bDividir
            // 
            this.bDividir.Location = new System.Drawing.Point(195, 155);
            this.bDividir.Name = "bDividir";
            this.bDividir.Size = new System.Drawing.Size(55, 55);
            this.bDividir.TabIndex = 18;
            this.bDividir.TabStop = false;
            this.bDividir.Text = "/";
            this.bDividir.UseVisualStyleBackColor = true;
            this.bDividir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bDividir_MouseUp);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(134, 155);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(55, 55);
            this.bBorrar.TabIndex = 19;
            this.bBorrar.TabStop = false;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bBorrar_MouseUp);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(73, 155);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(55, 55);
            this.bC.TabIndex = 20;
            this.bC.TabStop = false;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bC_MouseUp);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(12, 155);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(55, 55);
            this.bCE.TabIndex = 21;
            this.bCE.TabStop = false;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bCE_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(263, 466);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bDividir);
            this.Controls.Add(this.bMasMenos);
            this.Controls.Add(this.bCero);
            this.Controls.Add(this.bComa);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bUno);
            this.Controls.Add(this.bDos);
            this.Controls.Add(this.bTres);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.bCuatro);
            this.Controls.Add(this.bCinco);
            this.Controls.Add(this.bResta);
            this.Controls.Add(this.bSeis);
            this.Controls.Add(this.bOcho);
            this.Controls.Add(this.bNueve);
            this.Controls.Add(this.bMultiplicacion);
            this.Controls.Add(this.bSiete);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblResultat);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button bSiete;
        private System.Windows.Forms.Button bMultiplicacion;
        private System.Windows.Forms.Button bNueve;
        private System.Windows.Forms.Button bOcho;
        private System.Windows.Forms.Button bSeis;
        private System.Windows.Forms.Button bResta;
        private System.Windows.Forms.Button bCinco;
        private System.Windows.Forms.Button bCuatro;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Button bTres;
        private System.Windows.Forms.Button bDos;
        private System.Windows.Forms.Button bUno;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button bComa;
        private System.Windows.Forms.Button bCero;
        private System.Windows.Forms.Button bMasMenos;
        private System.Windows.Forms.Button bDividir;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
    }
}

