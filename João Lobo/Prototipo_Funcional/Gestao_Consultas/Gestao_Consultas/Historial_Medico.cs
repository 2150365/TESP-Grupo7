using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Consultas
{
    public partial class Historial_Medico : Form
    {
        public Historial_Medico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {

                MessageBox.Show("Nenhum Paciente Selecionado");

            }
            else
            {

                MessageBox.Show("Paciente Carregado");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Consulta fm = new Registo_Consulta();
            fm.Show();
        }
    }
}
