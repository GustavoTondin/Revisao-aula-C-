using System.Globalization;
public class Loja
{
    private List<Veiculo> veiculos;

    public Loja()
    {
        veiculos = new List<Veiculo>(); 
    }
    public void AdicionarVeiculo (Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    public void ListarVeiculos()
    {
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Marca: {veiculo.marca}, Modelo: {veiculo.modelo}, Preco: {veiculo.CalcularPreco().ToString("C2", new CultureInfo("pt-BR"))}");
        }
    }
}