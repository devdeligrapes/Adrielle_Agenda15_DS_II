namespace MauiAppEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.CadastroEvento())
        {
            BarBackgroundColor = Color.FromArgb("#992f4d"),
            BarTextColor = Colors.White
        };
    }
}