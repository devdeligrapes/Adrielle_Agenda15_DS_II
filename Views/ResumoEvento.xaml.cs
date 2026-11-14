namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento()
    {
        InitializeComponent();
    }

    private async void OnNovoCadastroClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}