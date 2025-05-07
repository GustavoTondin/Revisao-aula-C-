public class Veiculo 
{
    public string marca { get; set; }

    public string modelo { get; set; }

    public virtual double CalcularPreco()
    {
        return 20000;
    }

    public Veiculo (string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }
}