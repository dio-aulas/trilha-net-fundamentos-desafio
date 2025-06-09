namespace DesafioFundamentos;

public class Carro : Veiculo
{
    public Carro(string placa, decimal valorHora, decimal valorFracaoHora, TimeOnly horaEntrada = default)
    {
        Placa = placa;
        ValorHora = valorHora;
        ValorFracaoHora = valorFracaoHora;
        HoraEntrada = horaEntrada;
    }
    public override string ToString()
    {
        return @$"Carro: {Placa}, Valor por Hora: {ValorHora:C}, valor Fracao de Hora: {ValorFracaoHora:C}
                , Entrada: {HoraEntrada}, Saída: {HoraSaida}, Total Devido: {TotalDevido:C}";
    }

    public override string DadosVeiculo => $"Carro: {Placa}";
}
