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
            Nota nota = new Nota();
            nota.Aluno = cb_aluno.Text;

            List<Materia> listaMateria = new GravarMateria().Busca();
            ListViewItem[] materias = new ListViewItem[listaMateria.Count];
            for (int i = 0; i < listaMateria.Count; i++)
            {
               materias[i] = new ListViewItem(listaMateria[i].Descricao, i);
            }

            List<Nota> listaNotas = new GravarNota().Busca();
            ListViewItem[] notas = new ListViewItem[listaNotas.Count];
            for (int i = 0; i < listaNotas.Count; i++)
            {
                notas[i] = new ListViewItem(listaNotas[i].Valor, i);
            }
            list_view.Items.Clear();
            list_view.Items.AddRange(materias);
            list_view.Items.AddRange(notas);

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
