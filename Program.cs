namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Caminhao("Volkswagen", 2021),
            new Carro("Toyota", 2025),
            new Moto("Honda", 2026)
        ];
        foreach (var veiculoAtual in veiculos)
        {
            veiculoAtual.Ligar();
            veiculoAtual.Acelerar();
        }
    }
}