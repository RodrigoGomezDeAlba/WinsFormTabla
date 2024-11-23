namespace WinFormsTabla
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
            PanelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            LabelNumero = new Label();
            LabelTitulo = new Label();
            label1 = new Label();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = SystemColors.Info;
            PanelPrincipal.Controls.Add(richTextBoxResultados);
            PanelPrincipal.Controls.Add(buttonVer);
            PanelPrincipal.Controls.Add(textBoxNum);
            PanelPrincipal.Controls.Add(LabelNumero);
            PanelPrincipal.Controls.Add(LabelTitulo);
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Location = new Point(1, -2);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(801, 455);
            PanelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(380, 117);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(284, 288);
            richTextBoxResultados.TabIndex = 5;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(87, 229);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(150, 46);
            buttonVer.TabIndex = 4;
            buttonVer.Text = "VerTabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(87, 167);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(200, 39);
            textBoxNum.TabIndex = 3;
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(83, 117);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(216, 32);
            LabelNumero.TabIndex = 2;
            LabelNumero.Text = "Cual tabla quieres?";
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(380, 60);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(284, 29);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "Tabla de Multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 0;
            label1.Text = "Rodrigo Gómez de Alba";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPrincipal);
            Name = "Form1";
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label LabelTitulo;
        private Label label1;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label LabelNumero;
    }
}
