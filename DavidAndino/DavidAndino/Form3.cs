using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void PagoTotalAsincronobutton_Click(object sender, System.EventArgs e)
        {

            if (NombreProducto1textBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreProducto1textBox, "Ingrese un Valor");
                return;
            }
            NombreProducto1textBox.Focus();
            errorProvider1.Clear();

            if (CantidadProducto1textBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadProducto1textBox, " Seleccione una Opcion");
                return;
            }
            CantidadProducto1textBox.Focus();
            errorProvider1.Clear();

            if (PrecioProducto1textBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioProducto1textBox, " Seleccione una Opcion");
                return;
            }
            PrecioProducto1textBox.Focus();
            errorProvider1.Clear();

            if (NombreProducto2textBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreProducto2textBox, "Ingrese un Valor");
                return;
            }
            NombreProducto2textBox.Focus();
            errorProvider1.Clear();

            if (CantidadProducto2textBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadProducto2textBox, " Seleccione una Opcion");
                return;
            }
            CantidadProducto2textBox.Focus();
            errorProvider1.Clear();

            if (PrecioProducto2textBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioProducto2textBox, " Seleccione una Opcion");
                return;
            }
            PrecioProducto2textBox.Focus();
            errorProvider1.Clear();

            string Producto1 = NombreProducto1textBox.Text;
            double Cantidad1 = Convert.ToDouble(CantidadProducto1textBox.Text);
            double Precio1 = Convert.ToDouble(PrecioProducto1textBox.Text);

            string Producto2 = NombreProducto2textBox.Text;
            double Cantidad2 = Convert.ToDouble(CantidadProducto2textBox.Text);
            double Precio2 = Convert.ToDouble(PrecioProducto2textBox.Text);

            double subtotal = await SubTotalAsync(Precio1, Cantidad1, Precio2, Cantidad2);
            double total = await TotalAsync(subtotal);

            CalculoTotaltextBox.Text = Convert.ToString(total);

        }

        private async Task<double> SubTotalAsync(double prec1, double cant1, double prec2, double cant2)
        {
            double suma = await Task.Run(() =>
            {
                return (prec1 * cant1) + (prec2 * cant2);
            });

            return suma;

        }

        private async Task<double> TotalAsync(double subt)
        {
            double sumatotal = await Task.Run(() =>
            {
                double descuento = subt * 0.15;
                return subt - descuento;
            });

            return sumatotal;

        }
    }
}
