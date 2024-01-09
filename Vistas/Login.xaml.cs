using System.Security.Principal;

namespace MoisesSanchezExamen.Vistas;

public partial class Login : ContentPage
{
    private Dictionary<string, string> usuarios = new Dictionary<string, string>
   {
       { "estudiante2024", "uisrael2024" },
       { "examen1", "parcial1" },
       { "NombreEstudiante", "2024" },
   };
    public Login()
	{
		InitializeComponent();
	}

    private async void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;
        if (usuarios.TryGetValue(usuarioIngresado, out string contrasenaCorrecta) && contrasenaIngresada == contrasenaCorrecta)
        {
            //navegacion a la ventana registro
            await Navigation.PushAsync(new Registro(usuarioIngresado));
        }
        else
        {
            await DisplayAlert("ALERTA", "Usuario o Contraseña incorrecto", "Cancelar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDe());
    }
}