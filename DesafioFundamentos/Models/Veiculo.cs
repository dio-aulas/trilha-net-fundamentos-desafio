namespace DesafioFundamentos;

public abstract class Veiculo
{
    public virtual string Placa { get; set; }
    public virtual decimal ValorHora { get; set; }
    public virtual decimal ValorFracaoHora { get; set; }
    public virtual TimeOnly HoraEntrada { get; set; }
    public virtual TimeOnly HoraSaida { get; set; }
    public virtual decimal TotalDevido => ValorHora +
        (decimal)((HoraSaida - HoraEntrada).TotalHours > 1 ? (HoraSaida - HoraEntrada).TotalHours : 0) * ValorFracaoHora;
    public virtual string DadosVeiculo => "Veículo não especificado";

}
