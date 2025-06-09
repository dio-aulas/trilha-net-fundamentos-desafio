namespace DesafioFundamentos;

public class Caminhao : Veiculo
{
    public Caminhao(string placa, decimal valorHora, decimal valorFracaoHora, TimeOnly horaEntrada = default)
    {
        Placa = placa;
        ValorHora = valorHora * 1.2M; // Valor da hora é 1.2 vezes o valor da hora
        ValorFracaoHora = valorFracaoHora * 1.2M; // Valor da fração de hora é 1.2 vezes o valor da fração de hora
        HoraEntrada = horaEntrada;
    }
    public override string DadosVeiculo => $"Caminhão: {Placa}";
    public override string ToString()
    {
        return @$"Caminhao: {Placa}, Valor por Hora: {ValorHora:C}, valor Fracao de Hora: {ValorFracaoHora:C}
                , Entrada: {HoraEntrada}, Saída: {HoraSaida}, Total Devido: {TotalDevido:C}";
    }
}
