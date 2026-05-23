namespace BibliotecaUni
{
    partial class FormEmprestimo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.labelDevo = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMat = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empréstimo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.dtpDevolucao);
            this.panel2.Controls.Add(this.dtpEmprestimo);
            this.panel2.Controls.Add(this.labelDevo);
            this.panel2.Controls.Add(this.txtIsbn);
            this.panel2.Controls.Add(this.txtMatricula);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelMat);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 373);
            this.panel2.TabIndex = 1;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Location = new System.Drawing.Point(285, 182);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(233, 22);
            this.dtpDevolucao.TabIndex = 28;
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Enabled = false;
            this.dtpEmprestimo.Location = new System.Drawing.Point(285, 74);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(233, 22);
            this.dtpEmprestimo.TabIndex = 27;
            // 
            // labelDevo
            // 
            this.labelDevo.AutoSize = true;
            this.labelDevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevo.Location = new System.Drawing.Point(280, 150);
            this.labelDevo.Name = "labelDevo";
            this.labelDevo.Size = new System.Drawing.Size(222, 29);
            this.labelDevo.TabIndex = 26;
            this.labelDevo.Text = "Data de Devolução:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(12, 182);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(191, 22);
            this.txtIsbn.TabIndex = 24;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(18, 74);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(185, 22);
            this.txtMatricula.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Código do Livro:";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMat.Location = new System.Drawing.Point(280, 42);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(238, 29);
            this.labelMat.TabIndex = 21;
            this.labelMat.Text = "Data de Empréstimo:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(13, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(116, 29);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Matrícula ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 64);
            this.panel3.TabIndex = 1;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(23, 12);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(163, 37);
            this.btnEmprestar.TabIndex = 0;
            this.btnEmprestar.Text = "Emprestar Livro ";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEmprestar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(600, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 64);
            this.panel4.TabIndex = 1;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmprestimo";
            this.Text = "FormEmprestimo";
            this.Load += new System.EventHandler(this.FormEmprestimo_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDevo;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.Panel panel4;
    }
}