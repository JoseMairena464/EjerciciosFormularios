namespace Ejercicios
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            txtTemperatura = new TextBox();
            cmbConversion = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTemperatura
            // 
            txtTemperatura.Font = new Font("Segoe UI", 12F);
            txtTemperatura.Location = new Point(331, 21);
            txtTemperatura.Margin = new Padding(3, 4, 3, 4);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(171, 34);
            txtTemperatura.TabIndex = 0;
            // 
            // cmbConversion
            // 
            cmbConversion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConversion.Font = new Font("Segoe UI", 12F);
            cmbConversion.FormattingEnabled = true;
            cmbConversion.Location = new Point(12, 21);
            cmbConversion.Margin = new Padding(3, 4, 3, 4);
            cmbConversion.Name = "cmbConversion";
            cmbConversion.Size = new Size(190, 36);
            cmbConversion.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F);
            btnConvertir.Location = new Point(163, 87);
            btnConvertir.Margin = new Padding(3, 4, 3, 4);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(171, 53);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(218, 27);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(107, 28);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 187);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbConversion);
            Controls.Add(txtTemperatura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTemperatura;
        private ComboBox cmbConversion;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
    }
}