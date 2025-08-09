namespace Ejercicios
{
    partial class Form3
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(37, 36);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(308, 27);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(37, 84);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(308, 27);
            txtNum2.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(37, 135);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(60, 29);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(115, 135);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(60, 29);
            btnRestar.TabIndex = 3;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(209, 135);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(60, 29);
            btnMultiplicar.TabIndex = 4;
            btnMultiplicar.Text = "×";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(285, 135);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(60, 29);
            btnDividir.TabIndex = 5;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(37, 184);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 213);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form3";
            Text = "Ejercicio3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;
    }
}