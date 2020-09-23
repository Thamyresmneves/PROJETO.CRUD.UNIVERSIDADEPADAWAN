using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Portal
{
    public partial class CadastraAluno : Form
    {
        public CadastraAluno()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var inicio = new TelaAdm();
            this.Hide();
            inicio.Show();
        }

        private void btn_salvarCadastro_Click(object sender, EventArgs e)
        {
            
            Aluno aluno = new Aluno();
            aluno.Nome = txt_nome.Text;            
            aluno.Sobrenome = txt_sobrenome.Text;
            aluno.Nascimento = Convert.ToDateTime(txt_nascimento.Text);
            aluno.Cpf = txt_cpf.Text;

            List <Aluno> listaAluno = new GravarAluno().Add(aluno);

            ListViewItem[] itens = new ListViewItem[listaAluno.Count];
            for (int i = 0; i < listaAluno.Count; i++)
            {
                itens[i] = new ListViewItem(listaAluno[i].Nome, i);
            }
            txt_apresentaAluno.Items.Clear();
            txt_apresentaAluno.Items.AddRange(itens);

        }

        private void btn_excluiCadastro_Click(object sender, EventArgs e)
        {
            List<Aluno> listaAluno = new GravarAluno().Deleta(txt_cpf.Text);
            ListViewItem[] itens = new ListViewItem[listaAluno.Count];
            for (int i = 0; i< listaAluno.Count;i++)
            {
                itens[i] = new ListViewItem(listaAluno[i].Nome, i );
            }
            txt_apresentaAluno.Items.Clear();
            txt_apresentaAluno.Items.AddRange(itens);

        }

        private void txt_apresentaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show();
        }

        private void txt_cursoo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastraAluno_Load(object sender, EventArgs e)
        {
            GravarCurso curso = new GravarCurso();
            List<Curso> listaCurso = curso.Busca();

            for (int i = 0; i < listaCurso.Count; i++)
            {
                cb_curso.Items.Add(listaCurso[i].NomeCurso);
            }

            

        }
    }
}
