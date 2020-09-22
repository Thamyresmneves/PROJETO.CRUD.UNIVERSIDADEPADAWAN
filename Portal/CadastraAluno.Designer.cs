namespace Portal
{
    partial class CadastraAluno
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvarCadastro = new System.Windows.Forms.Button();
            this.btn_excluiCadastro = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apresentaAluno = new System.Windows.Forms.ListView();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(183, 74);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(199, 30);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.Text = "Tham";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobrenome.Location = new System.Drawing.Point(183, 131);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(199, 30);
            this.txt_sobrenome.TabIndex = 1;
            this.txt_sobrenome.Text = "yres";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(183, 186);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(199, 30);
            this.txt_cpf.TabIndex = 2;
            this.txt_cpf.Text = "123456";
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nascimento.Location = new System.Drawing.Point(183, 243);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(199, 30);
            this.txt_nascimento.TabIndex = 3;
            this.txt_nascimento.Text = "1997/06/07";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sobrenome";
            // 
            // btn_salvarCadastro
            // 
            this.btn_salvarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarCadastro.Location = new System.Drawing.Point(45, 364);
            this.btn_salvarCadastro.Name = "btn_salvarCadastro";
            this.btn_salvarCadastro.Size = new System.Drawing.Size(128, 51);
            this.btn_salvarCadastro.TabIndex = 11;
            this.btn_salvarCadastro.Text = "salvar";
            this.btn_salvarCadastro.UseVisualStyleBackColor = true;
            this.btn_salvarCadastro.Click += new System.EventHandler(this.btn_salvarCadastro_Click);
            // 
            // btn_excluiCadastro
            // 
            this.btn_excluiCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluiCadastro.Location = new System.Drawing.Point(207, 364);
            this.btn_excluiCadastro.Name = "btn_excluiCadastro";
            this.btn_excluiCadastro.Size = new System.Drawing.Size(130, 51);
            this.btn_excluiCadastro.TabIndex = 12;
            this.btn_excluiCadastro.Text = "excluir";
            this.btn_excluiCadastro.UseVisualStyleBackColor = true;
            this.btn_excluiCadastro.Click += new System.EventHandler(this.btn_excluiCadastro_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(369, 364);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(137, 51);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lista:";
            // 
            // txt_apresentaAluno
            // 
            this.txt_apresentaAluno.HideSelection = false;
            this.txt_apresentaAluno.Location = new System.Drawing.Point(423, 74);
            this.txt_apresentaAluno.Name = "txt_apresentaAluno";
            this.txt_apresentaAluno.Size = new System.Drawing.Size(240, 259);
            this.txt_apresentaAluno.TabIndex = 16;
            this.txt_apresentaAluno.UseCompatibleStateImageBehavior = false;
            this.txt_apresentaAluno.SelectedIndexChanged += new System.EventHandler(this.txt_apresentaAluno_SelectedIndexChanged);
            // 
            // btn_menu
            // 
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(542, 364);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(137, 51);
            this.btn_menu.TabIndex = 17;
            this.btn_menu.Text = "menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 29);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cadastro de Aluno";
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Location = new System.Drawing.Point(183, 305);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(199, 28);
            this.cb_curso.TabIndex = 42;
            // 
            // CadastraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.txt_apresentaAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluiCadastro);
            this.Controls.Add(this.btn_salvarCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Name = "CadastraAluno";
            this.Text = "CadastraAluno";
            this.Load += new System.EventHandler(this.CadastraAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salvarCadastro;
        private System.Windows.Forms.Button btn_excluiCadastro;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView txt_apresentaAluno;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_curso;
    }
}