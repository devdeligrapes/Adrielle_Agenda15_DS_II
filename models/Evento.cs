using System.Globalization;

namespace MauiAppEventos.Models;

public class Evento
{
    private static readonly CultureInfo PtBr = new("pt-BR");

    public string Nome { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; } = string.Empty;
    public double CustoPorParticipante { get; set; }

    public TimeSpan Duracao => DataTermino.Subtract(DataInicio);
    public int DuracaoEmDias => Duracao.Days;
    public double CustoTotal => NumeroParticipantes * CustoPorParticipante;

    public string DuracaoTexto => $"{Duracao.Days} dia(s) ({Duracao.TotalHours:0} horas)";
    public string CustoPorParticipanteTexto => CustoPorParticipante.ToString("C", PtBr);
    public string CustoTotalTexto => CustoTotal.ToString("C", PtBr);
}