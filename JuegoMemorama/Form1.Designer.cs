namespace JuegoMemorama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(18, 14);
            this.PanelJuego.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(1317, 989);
            this.PanelJuego.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReiniciar.Location = new System.Drawing.Point(1483, 852);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(332, 71);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reset Game";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Font = new System.Drawing.Font("Cambria", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.ForeColor = System.Drawing.Color.White;
            this.lblReset.Location = new System.Drawing.Point(1530, 773);
            this.lblReset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(186, 61);
            this.lblReset.TabIndex = 2;
            this.lblReset.Text = "Moves:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Cambria", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(1713, 773);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(57, 61);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Cambria", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblResult.Location = new System.Drawing.Point(1435, 65);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 61);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.PanelJuego);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feria del Conocimiento - Pruebas Unitarias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblResult;
    }
}

