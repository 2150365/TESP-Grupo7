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
    public partial class Registo_Diagnostico : Form
    {
        public Registo_Diagnostico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Consulta frm = new Registo_Consulta();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            MessageBox.Show("Diagnosito Guardado com Sucesso");
        }
    }
}
