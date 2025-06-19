using ejercicio1.Models;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        Form2 formCargar = new Form2();
        Form3 formMostrar = new Form3();
        Lote lote = new Lote();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            formCargar.tbValor.Clear();
            if (formCargar.ShowDialog() == DialogResult.OK)
            {
                lote.AsignarNumeroLote(Convert.ToInt32(formCargar.tbValor.Text));
            }
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            formCargar.tbValor.Clear();
            if (formCargar.ShowDialog() == DialogResult.OK)
            {
                lote.RegistrarMedida(Convert.ToDouble(formCargar.tbValor.Text));
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            formMostrar.lbMedidas.Items.Clear();
            for (int n = 0; n < lote.VerCantidad(); n++)
            {
                formMostrar.lbMedidas.Items.Add(lote.VerMedida(n));
            }
            formMostrar.ShowDialog();
        }
    }
}
