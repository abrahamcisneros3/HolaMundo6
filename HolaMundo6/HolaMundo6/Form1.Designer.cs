namespace HolaMundo6
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
            label1 = new Label();
            label2 = new Label();
            txtContrasenauno = new TextBox();
            txtContrasenados = new TextBox();
            button1 = new Button();
            BtnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 113);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirme la contraseña";
            label2.Click += label2_Click;
            // 
            // txtContrasenauno
            // 
            txtContrasenauno.Location = new Point(255, 42);
            txtContrasenauno.Name = "txtContrasenauno";
            txtContrasenauno.Size = new Size(159, 23);
            txtContrasenauno.TabIndex = 2;
            txtContrasenauno.TextChanged += textBox1_TextChanged;
            // 
            // txtContrasenados
            // 
            txtContrasenados.Location = new Point(255, 110);
            txtContrasenados.Name = "txtContrasenados";
            txtContrasenados.Size = new Size(159, 23);
            txtContrasenados.TabIndex = 3;
            txtContrasenados.TextChanged += txtContrasenados_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnValidar
            // 
            BtnValidar.Location = new Point(339, 206);
            BtnValidar.Name = "BtnValidar";
            BtnValidar.Size = new Size(75, 23);
            BtnValidar.TabIndex = 5;
            BtnValidar.Text = "VALIDAR";
            BtnValidar.UseVisualStyleBackColor = true;
            BtnValidar.Click += BtnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnValidar);
            Controls.Add(button1);
            Controls.Add(txtContrasenados);
            Controls.Add(txtContrasenauno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtContrasenauno;
        private TextBox txtContrasenados;
        private Button button1;
        private Button BtnValidar;
    }
}