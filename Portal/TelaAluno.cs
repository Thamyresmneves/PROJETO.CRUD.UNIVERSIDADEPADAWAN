using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal
{
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Aluno aluno = new Aluno();
            Notas notas = new Notas();
            notas.Aluno = cb_aluno.Text;

            List<Notas> listaNotas = new GravarNota().Busca(notas);

            ListViewItem[] itens = new ListViewItem[listaNotas.Count];
            for (int i = 0; i < listaNotas.Count; i++)
            {
                itens[i] = new ListViewItem(listaNotas[i].Nota, i);
            }
            list_view.Items.Clear();
            list_view.Items.AddRange(itens);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var inicio = new TelaInicio();
            this.Hide();
            inicio.Show(); 
        }

        private void txt_cadastro_TextChanged(object sender, EventArgs e)
        {
            GravarAluno chamadaAluno = new GravarAluno();
            List<Aluno> listaAluno = chamadaAluno.Busca();

            for (int i = 0; i < listaAluno.Count; i++)
            {
                cb_aluno.Items.Add(listaAluno[i].Nome);
            }

        }

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            GravarAluno chamadaAluno = new GravarAluno();
            List<Aluno> listaAluno = chamadaAluno.Busca();

            for (int i = 0; i < listaAluno.Count; i++)
            {
                cb_aluno.Items.Add(listaAluno[i].Nome);
            }
        }
    }
}
