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
    public partial class Registar_Receita : Form
    {
        public Registar_Receita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Receita Guarda Com Sucesso");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registo_Consulta frm = new Registo_Consulta();
            frm.Show();
        }
    }
}
