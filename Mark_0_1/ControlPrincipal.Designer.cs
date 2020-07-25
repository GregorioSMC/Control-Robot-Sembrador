namespace Mark_0_1
{
    partial class ControlPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPrincipal));
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.tkbDireccion = new System.Windows.Forms.TrackBar();
            this.tkbVelocidad = new System.Windows.Forms.TrackBar();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.tmVoz = new System.Windows.Forms.Timer(this.components);
            this.btnVozOn = new System.Windows.Forms.Button();
            this.btnVozOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(28, 94);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(155, 62);
            this.btnAvanzar.TabIndex = 0;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(28, 261);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(155, 62);
            this.btnRetroceder.TabIndex = 1;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(28, 180);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(155, 62);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // tkbDireccion
            // 
            this.tkbDireccion.Location = new System.Drawing.Point(201, 111);
            this.tkbDireccion.Maximum = 2387;
            this.tkbDireccion.Minimum = 1708;
            this.tkbDireccion.Name = "tkbDireccion";
            this.tkbDireccion.Size = new System.Drawing.Size(210, 45);
            this.tkbDireccion.TabIndex = 3;
            this.tkbDireccion.Value = 2048;
            this.tkbDireccion.Scroll += new System.EventHandler(this.tkbDireccion_Scroll);
            // 
            // tkbVelocidad
            // 
            this.tkbVelocidad.Location = new System.Drawing.Point(201, 278);
            this.tkbVelocidad.Maximum = 1023;
            this.tkbVelocidad.Name = "tkbVelocidad";
            this.tkbVelocidad.Size = new System.Drawing.Size(210, 45);
            this.tkbVelocidad.TabIndex = 4;
            this.tkbVelocidad.Scroll += new System.EventHandler(this.tkbVelocidad_Scroll);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(282, 91);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(280, 265);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(54, 13);
            this.lblVelocidad.TabIndex = 6;
            this.lblVelocidad.Text = "Velocidad";
            this.lblVelocidad.Click += new System.EventHandler(this.lblVelocidad_Click);
            // 
            // tmVoz
            // 
            this.tmVoz.Interval = 1000;
            this.tmVoz.Tick += new System.EventHandler(this.tmVoz_Tick);
            // 
            // btnVozOn
            // 
            this.btnVozOn.Location = new System.Drawing.Point(530, 94);
            this.btnVozOn.Name = "btnVozOn";
            this.btnVozOn.Size = new System.Drawing.Size(155, 62);
            this.btnVozOn.TabIndex = 7;
            this.btnVozOn.Text = "Iniciar Voz";
            this.btnVozOn.UseVisualStyleBackColor = true;
            this.btnVozOn.Click += new System.EventHandler(this.btnVozOn_Click);
            // 
            // btnVozOff
            // 
            this.btnVozOff.Location = new System.Drawing.Point(530, 240);
            this.btnVozOff.Name = "btnVozOff";
            this.btnVozOff.Size = new System.Drawing.Size(155, 62);
            this.btnVozOff.TabIndex = 8;
            this.btnVozOff.Text = "Terminar Voz";
            this.btnVozOff.UseVisualStyleBackColor = true;
            this.btnVozOff.Click += new System.EventHandler(this.btnVozOff_Click);
            // 
            // ControlPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVozOff);
            this.Controls.Add(this.btnVozOn);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tkbVelocidad);
            this.Controls.Add(this.tkbDireccion);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnAvanzar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPrincipal";
            this.Text = "Control Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tkbDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar tkbDireccion;
        private System.Windows.Forms.TrackBar tkbVelocidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Timer tmVoz;
        private System.Windows.Forms.Button btnVozOn;
        private System.Windows.Forms.Button btnVozOff;
    }
}

