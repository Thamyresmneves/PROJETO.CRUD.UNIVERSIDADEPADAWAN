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
          
            DialogResult dialogResult = MessageBox.Show("Essas são as notas disponiveis:");

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
