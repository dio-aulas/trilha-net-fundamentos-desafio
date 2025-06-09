using System.ComponentModel;

namespace DesafioFundamentos;

public enum EnmTipoVeiculo
{
    [Description("Carro")]
    Carro = 1,
    [Description("Moto")]
    Moto,
    [Description("Caminhão")]
    Caminhao
}
public static class EnmTipoVeiculoExtensions
{
    public static string GetDescription(this EnmTipoVeiculo tipoVeiculo)
    {
        var fieldInfo = tipoVeiculo.GetType().GetField(tipoVeiculo.ToString());
        var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : tipoVeiculo.ToString();
    }
}