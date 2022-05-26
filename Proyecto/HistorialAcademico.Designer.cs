namespace Proyecto
{
    partial class HistorialAcademico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscarh = new System.Windows.Forms.Button();
            this.txt_curph = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial Academico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURP ";
            // 
            // btn_buscarh
            // 
            this.btn_buscarh.Location = new System.Drawing.Point(12, 621);
            this.btn_buscarh.Name = "btn_buscarh";
            this.btn_buscarh.Size = new System.Drawing.Size(166, 48);
            this.btn_buscarh.TabIndex = 2;
            this.btn_buscarh.Text = "Buscar...";
            this.btn_buscarh.UseVisualStyleBackColor = true;
            this.btn_buscarh.Click += new System.EventHandler(this.btn_buscarh_Click_1);
            // 
            // txt_curph
            // 
            this.txt_curph.Location = new System.Drawing.Point(12, 174);
            this.txt_curph.Name = "txt_curph";
            this.txt_curph.Size = new System.Drawing.Size(166, 23);
            this.txt_curph.TabIndex = 3;
            this.txt_curph.TextChanged += new System.EventHandler(this.txt_curph_TextChanged);
            // 
            // HistorialAcademico
            // 
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.txt_curph);
            this.Controls.Add(this.btn_buscarh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistorialAcademico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_buscarh;
        private TextBox txt_curph;
    }
}