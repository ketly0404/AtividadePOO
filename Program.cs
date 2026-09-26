namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculo =
        [
            new Caminhao("Volkswagen", 2021),
            new Carro("Toyota", 2025),
            new Moto("Honda", 2026)
        ];
        foreach (var veiculoAtual in veiculo)
        {
            veiculoAtual.Ligar();
            veiculoAtual.Acelerar();
        }
    }
}