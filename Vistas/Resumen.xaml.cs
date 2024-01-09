namespace MoisesSanchezExamen.Vistas
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string edad, string pagoMensual)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblEdad.Text = edad;
            lblPagoMensual.Text = pagoMensual;
        }
    }
}