namespace DesafioFundamentos;

public class Moto : Veiculo
{
    public Moto(string placa, decimal valorHora, decimal valorFracaoHora, TimeOnly horaEntrada = default)
    {
        Placa = placa;
        ValorHora = valorHora / 2; // Valor da hora é metade do valor da hora
        ValorFracaoHora = valorFracaoHora / 2; // Valor da fração de hora é metade do valor da fração de hora
        HoraEntrada = horaEntrada;
    }

    public override string DadosVeiculo => $"Moto: {Placa}";
    public override string ToString()
    {
        return @$"Moto: {Placa}, Valor por Hora: {ValorHora:C}, valor Fracao de Hora: {ValorFracaoHora:C}
                , Entrada: {HoraEntrada}, Saída: {HoraSaida}, Total Devido: {TotalDevido:C}";
    }
}
