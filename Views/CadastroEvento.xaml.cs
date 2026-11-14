using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        try
        {
            Evento evento = new Evento
            {
                Nome = txt_nome.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                NumeroParticipantes = Convert.ToInt32(txt_participantes.Text),
                Local = txt_local.Text,
                CustoPorParticipante = Convert.ToDouble(txt_custo.Text)
            };

            await Navigation.PushAsync(new ResumoEvento()
            {
                BindingContext = evento
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}