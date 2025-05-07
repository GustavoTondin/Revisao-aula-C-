public class Moto : Veiculo
{
    public Moto (string marca, string modelo)
        : base(marca,modelo)
    {
    }

    public override double CalcularPreco()
    {
        return base.CalcularPreco() * 0.6;
    }
}