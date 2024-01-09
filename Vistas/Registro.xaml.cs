namespace MoisesSanchezExamen.Vistas;

public partial class Registro : ContentPage
{
	public Registro(string usuarioIngresado)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario conectado: " + usuarioIngresado;
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}