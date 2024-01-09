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
            DisplayAlert("Error", "Ingrese un monto inicial válido.", "OK");
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, dpFecha.Date.ToString("d"), pkCiudad.SelectedItem?.ToString(), pkPais.SelectedItem?.ToString(), txtMontoInicial.Text, entryPagoMensual.Text));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}