namespace DesafioFundamentos;

public class VeiculoFactory
{
    public static Veiculo CriarVeiculo(EnmTipoVeiculo tipoVeiculo, string placa, decimal valorHora, decimal valorFracaoHora, TimeOnly horaEntrada = default)
    {
        switch (tipoVeiculo)
        {
            case EnmTipoVeiculo.Carro:
                return new Carro(placa, valorHora, valorFracaoHora, horaEntrada);
            case EnmTipoVeiculo.Moto:
                return new Moto(placa, valorHora, valorFracaoHora, horaEntrada);
            case EnmTipoVeiculo.Caminhao:
                return new Caminhao(placa, valorHora, valorFracaoHora, horaEntrada);
            default:
                throw new ArgumentException("Tipo de veículo inválido.");
        }
    }
}
