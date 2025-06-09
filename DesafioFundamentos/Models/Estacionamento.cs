using System.Runtime.InteropServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Informe o tipo do  veículo que deseja estacionar:");
            Console.WriteLine($"1 - {EnmTipoVeiculoExtensions.GetDescription(EnmTipoVeiculo.Carro)}");
            Console.WriteLine($"2 - {EnmTipoVeiculoExtensions.GetDescription(EnmTipoVeiculo.Moto)}");
            Console.WriteLine($"3 - {EnmTipoVeiculoExtensions.GetDescription(EnmTipoVeiculo.Caminhao)}");

            var tipoVeiculo = int.Parse(Console.ReadLine() ?? "0");
            var tipoVeiculoEnum = (EnmTipoVeiculo)tipoVeiculo;

            Console.WriteLine("Digite a placa do veículo:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            var placa = Console.ReadLine().ToUpper() ?? "";

            Console.WriteLine("Informe a Hora de entrada do veículo (formato HH:mm):");
            var horaEntrada = TimeOnly.Parse(Console.ReadLine() ?? "00:00");

            var veiculo = VeiculoFactory.CriarVeiculo(tipoVeiculoEnum, placa, precoInicial, precoPorHora, horaEntrada);
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine() ?? "";

            var veiculo = veiculos.FirstOrDefault(x => x.Placa.ToUpper() == placa.ToUpper());
            if (veiculo != null)
            {
                Console.WriteLine($"Informe a hora de saída do veículo {placa} (formato HH:mm):");
                TimeOnly horaSaida = TimeOnly.Parse(Console.ReadLine() ?? "00:00");

                // Calcula o total devido
                veiculo.HoraSaida = horaSaida;

                // Exibe o valor total devido
                Console.WriteLine(veiculo.ToString());

                // Remove o veículo da lista
                veiculos.Remove(veiculo);
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }

        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                veiculos.ForEach(veiculo =>
                {
                    Console.WriteLine(veiculo.DadosVeiculo);
                });
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
