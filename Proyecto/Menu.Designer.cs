namespace Proyecto
{
    partial class Menu
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
            this.pb_Certificado = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Certificado)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Certificado
            // 
            this.pb_Certificado.BackColor = System.Drawing.Color.Transparent;
            this.pb_Certificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Certificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Certificado.Image = global::Proyecto.Properties.Resources.certificado;
            this.pb_Certificado.Location = new System.Drawing.Point(12, 12);
            this.pb_Certificado.Name = "pb_Certificado";
            this.pb_Certificado.Size = new System.Drawing.Size(80, 82);
            this.pb_Certificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Certificado.TabIndex = 0;
            this.pb_Certificado.TabStop = false;
            this.pb_Certificado.Click += new System.EventHandler(this.pb_Certificado_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.BackgroundImage = global::Proyecto.Properties.Resources.boton;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.Location = new System.Drawing.Point(1239, 1);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(25, 25);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondoCertificado;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pb_Certificado);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Certificado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pb_Certificado;
        private Button btn_Salir;
    }
}