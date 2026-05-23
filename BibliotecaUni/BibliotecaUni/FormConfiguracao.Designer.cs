namespace BibliotecaUni
{
    partial class FormConfiguracao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTermos = new System.Windows.Forms.TabPage();
            this.tabPrivacidade = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxTermos = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPrivacidade = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabTermos.SuspendLayout();
            this.tabPrivacidade.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTermos);
            this.tabControl1.Controls.Add(this.tabPrivacidade);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // tabTermos
            // 
            this.tabTermos.Controls.Add(this.richTextBoxTermos);
            this.tabTermos.Controls.Add(this.richTextBox1);
            this.tabTermos.Location = new System.Drawing.Point(4, 25);
            this.tabTermos.Name = "tabTermos";
            this.tabTermos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTermos.Size = new System.Drawing.Size(792, 421);
            this.tabTermos.TabIndex = 0;
            this.tabTermos.Text = "Termos de Uso";
            this.tabTermos.UseVisualStyleBackColor = true;
            // 
            // tabPrivacidade
            // 
            this.tabPrivacidade.Controls.Add(this.richTextBoxPrivacidade);
            this.tabPrivacidade.Controls.Add(this.richTextBox2);
            this.tabPrivacidade.Location = new System.Drawing.Point(4, 25);
            this.tabPrivacidade.Name = "tabPrivacidade";
            this.tabPrivacidade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrivacidade.Size = new System.Drawing.Size(792, 421);
            this.tabPrivacidade.TabIndex = 1;
            this.tabPrivacidade.Text = "Privacidade";
            this.tabPrivacidade.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sobre ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(786, 415);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(786, 415);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema BibliotecaUni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desenvolvido para fins acadêmicos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Versão: 1.0.0 (Release Oficial)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano de Desenvolvimento: 2026";
            // 
            // richTextBoxTermos
            // 
            this.richTextBoxTermos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTermos.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxTermos.Name = "richTextBoxTermos";
            this.richTextBoxTermos.Size = new System.Drawing.Size(786, 415);
            this.richTextBoxTermos.TabIndex = 1;
            this.richTextBoxTermos.Text = "";
            // 
            // richTextBoxPrivacidade
            // 
            this.richTextBoxPrivacidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPrivacidade.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxPrivacidade.Name = "richTextBoxPrivacidade";
            this.richTextBoxPrivacidade.Size = new System.Drawing.Size(786, 415);
            this.richTextBoxPrivacidade.TabIndex = 1;
            this.richTextBoxPrivacidade.Text = "";
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormConfiguracao";
            this.Text = "FormConfiguracao";
            this.Load += new System.EventHandler(this.FormConfiguracao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTermos.ResumeLayout(false);
            this.tabPrivacidade.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTermos;
        private System.Windows.Forms.TabPage tabPrivacidade;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxTermos;
        private System.Windows.Forms.RichTextBox richTextBoxPrivacidade;
    }
}