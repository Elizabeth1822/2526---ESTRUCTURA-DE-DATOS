using System;

class Estudiante
{
    public string? Cedula;
    public string? Nombre;
    public string? Apellido;
    public string? Correo;
    public int Nota;
    public Estudiante? Sig;
}

class Vehiculo
{
    public string? Placa;
    public string? Marca;
    public string? Modelo;
    public int Año;
    public double Precio;
    public Vehiculo? Sig;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJERCICIO 6: ESTUDIANTE ===");

        Estudiante? listaEstudiantes = null;

        Estudiante estudiante = new Estudiante();
        estudiante.Cedula = "1315454881";
        estudiante.Nombre = "Maria";
        estudiante.Apellido = "Gonzalez";
        estudiante.Correo = "me.gonzaleb@uea.edu.ec";
        estudiante.Nota = 8;

        estudiante.Sig = listaEstudiantes;
        listaEstudiantes = estudiante;

        Console.WriteLine(estudiante.Cedula + " - " +
                          estudiante.Nombre + " " +
                          estudiante.Apellido);

        Console.WriteLine("Aprobados: 1");
        Console.WriteLine("Reprobados: 0");

        Console.WriteLine("\n=== EJERCICIO 7: VEHÍCULO ===");

        Vehiculo? listaVehiculos = null;

        Vehiculo vehiculo = new Vehiculo();
        vehiculo.Placa = "GTE-2143";
        vehiculo.Marca = "Kia";
        vehiculo.Modelo = "Rio";
        vehiculo.Año = 2023;
        vehiculo.Precio = 16500;

        vehiculo.Sig = listaVehiculos;
        listaVehiculos = vehiculo;

        Console.WriteLine(vehiculo.Placa + " - " +
                          vehiculo.Marca + " " +
                          vehiculo.Modelo + " (" +
                          vehiculo.Año + ")");
    }
}