public class Carro : Veiculo
{
    public bool arCondicionado { get; set; }

    public Carro (string marca, string modelo, bool arCondicionado)
        : base(marca,modelo)
    {
        this.arCondicionado = arCondicionado;
    }

    public override double CalcularPreco()
    {
        if (arCondicionado != false)
        {
            return base.CalcularPreco() + 3000;
        }
        else
        {
            return base.CalcularPreco();
        }
    }
}