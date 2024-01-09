namespace MoisesSanchezExamen.Vistas;

public partial class Registro : ContentPage
{
    private const double costoCurso = 1500;
    private double montoInicial;
	public Registro(string usuarioIngresado)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario conectado: " + usuarioIngresado;
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(txtMontoInicial.Text, out montoInicial))
        {
            double restoPagar = costoCurso - montoInicial;
            double cuotaMensual = (restoPagar / 4) * 1.04; // 4% de aumento por cada cuota

            entryPagoMensual.Text = cuotaMensual.ToString("C");
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto inicial v�lido.", "OK");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        // Aqu� puedes pasar la informaci�n necesaria a la p�gina de Resumen
        Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, entryPagoMensual.Text));
    }
}   