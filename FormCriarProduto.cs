using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioMultiplasJanelas
{
    public partial class FormCriarProduto : Form
    {

        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.textBoxFabricante.Text; } }
        public decimal precoCompra { get { return  (decimal)this.InputPrecoCompra.Value; } }
        public decimal precoVenda { get { return (decimal)this.InputPrecoVenda.Value; } }
        public FormCriarProduto()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
