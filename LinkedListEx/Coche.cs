namespace LinkedListEx;

public class Coche
{
    public int Ruedas;
    public string Color;

    public Coche(int ruedas, string color)
    {
        Ruedas = ruedas;
        Color = color;
    }

    public override string ToString() => $"Coche - Ruedas: {Ruedas}, Color: {Color}";
}