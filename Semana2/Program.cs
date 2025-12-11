using System;

// Clase Círculo
public class Circulo
{
    private double radio;

    public Circulo(double radio) { this.radio = radio; }

    public double Area() { return Math.PI * radio * radio; }
    public double Perimetro() { return 2 * Math.PI * radio; }
}

// Clase Cuadrado
public class Cuadrado
{
    private double lado;

    public Cuadrado(double lado) { this.lado = lado; }

    public double Area() { return lado * lado; }
    public double Perimetro() { return 4 * lado; }
}

// Programa principal
class Program
{
    static void Main()
    {
        Circulo c = new Circulo(5);
        Cuadrado q = new Cuadrado(4);

        Console.WriteLine("Área del círculo: " + c.Area());
        Console.WriteLine("Perímetro del círculo: " + c.Perimetro());
        Console.WriteLine("Área del cuadrado: " + q.Area());
        Console.WriteLine("Perímetro del cuadrado: " + q.Perimetro());
    }
}
