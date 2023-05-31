namespace Left4Dead2_Audio_File_Duplicator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            abrirSonidoBtn = new Button();
            label1 = new Label();
            txtInicio = new TextBox();
            duplicarBtn = new Button();
            txtFin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNuevoNombre = new TextBox();
            label5 = new Label();
            checkLetras = new CheckBox();
            checkDir = new CheckBox();
            checkEnumeracionAlternativa = new CheckBox();
            SuspendLayout();
            // 
            // abrirSonidoBtn
            // 
            abrirSonidoBtn.Location = new Point(415, 28);
            abrirSonidoBtn.Name = "abrirSonidoBtn";
            abrirSonidoBtn.Size = new Size(153, 51);
            abrirSonidoBtn.TabIndex = 0;
            abrirSonidoBtn.Text = "Seleccionar audio";
            abrirSonidoBtn.UseVisualStyleBackColor = true;
            abrirSonidoBtn.Click += abrirSonidoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 62);
            label1.TabIndex = 1;
            label1.Text = "Audio Duplicator";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(78, 148);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(44, 27);
            txtInicio.TabIndex = 2;
            // 
            // duplicarBtn
            // 
            duplicarBtn.Location = new Point(415, 110);
            duplicarBtn.Name = "duplicarBtn";
            duplicarBtn.Size = new Size(153, 47);
            duplicarBtn.TabIndex = 3;
            duplicarBtn.Text = "Duplicar";
            duplicarBtn.UseVisualStyleBackColor = true;
            duplicarBtn.Click += duplicarBtn_Click;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(256, 148);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(44, 27);
            txtFin.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 148);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(108, 35);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 148);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Hasta:";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(126, 96);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(174, 27);
            txtNuevoNombre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 211);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 10;
            label5.Text = "© Coded by ItzSebas";
            // 
            // checkLetras
            // 
            checkLetras.AutoSize = true;
            checkLetras.Location = new Point(22, 190);
            checkLetras.Name = "checkLetras";
            checkLetras.Size = new Size(170, 24);
            checkLetras.TabIndex = 11;
            checkLetras.Text = "Utilizar letras (a, b, c)";
            checkLetras.UseVisualStyleBackColor = true;
            // 
            // checkDir
            // 
            checkDir.AutoSize = true;
            checkDir.Location = new Point(415, 163);
            checkDir.Name = "checkDir";
            checkDir.Size = new Size(156, 24);
            checkDir.TabIndex = 12;
            checkDir.Text = "Recordar dirección";
            checkDir.UseVisualStyleBackColor = true;
            checkDir.CheckedChanged += checkDir_CheckedChanged;
            // 
            // checkEnumeracionAlternativa
            // 
            checkEnumeracionAlternativa.AutoSize = true;
            checkEnumeracionAlternativa.Location = new Point(200, 190);
            checkEnumeracionAlternativa.Name = "checkEnumeracionAlternativa";
            checkEnumeracionAlternativa.RightToLeft = RightToLeft.No;
            checkEnumeracionAlternativa.Size = new Size(172, 24);
            checkEnumeracionAlternativa.TabIndex = 13;
            checkEnumeracionAlternativa.Text = "Enumeración 01, 02,...";
            checkEnumeracionAlternativa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 235);
            Controls.Add(checkEnumeracionAlternativa);
            Controls.Add(checkDir);
            Controls.Add(checkLetras);
            Controls.Add(label5);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFin);
            Controls.Add(duplicarBtn);
            Controls.Add(txtInicio);
            Controls.Add(label1);
            Controls.Add(abrirSonidoBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Left4Dead2 Audio Duplicator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button abrirSonidoBtn;
        private Label label1;
        private TextBox txtInicio;
        private Button duplicarBtn;
        private TextBox txtFin;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNuevoNombre;
        private Label label5;
        private CheckBox checkLetras;
        private CheckBox checkDir;
        private CheckBox checkEnumeracionAlternativa;
    }
}