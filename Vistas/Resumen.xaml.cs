namespace MoisesSanchezExamen.Vistas
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad,string pais, string montoInicial, string pagoMensual)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblApellido.Text =  apellido;
            lblEdad.Text =  edad;
            lblFecha.Text = fecha;
            lblCiudad.Text = ciudad;
            lblPais.Text = pais;
            lblMontoInicial.Text = montoInicial;
            lblPagoMensual.Text = pagoMensual;
            
        }
    }
}
