using System;

// REGISTRO (struct)
struct Contacto
{
    public string Nombre;
    public string Telefono;
    public string Email;
}

// CLASE PRINCIPAL (POO)
class Agenda
{
    private Contacto[] contactos; // VECTOR
    private int contador;

    // CONSTRUCTOR
    public Agenda(int tamaño)
    {
        contactos = new Contacto[tamaño];
        contador = 0;

        // DATOS PRECARGADOS
        contactos[contador].Nombre = "Maria Gonzalez";
        contactos[contador].Telefono = "090000009";
        contactos[contador].Email = "ma.gonzalez@uea.com";
        contador++;
    }

    // REPORTERÍA: MOSTRAR CONTACTOS
    public void MostrarContactos()
    {
        Console.WriteLine("\nLISTA DE CONTACTOS");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Nombre: " + contactos[i].Nombre);
            Console.WriteLine("Teléfono: " + contactos[i].Telefono);
            Console.WriteLine("Email: " + contactos[i].Email);
        }
    }

    // MATRIZ PARA REPORTE
    public void ReporteMatriz()
    {
        string[,] reporte = new string[contador, 3];

        for (int i = 0; i < contador; i++)
        {
            reporte[i, 0] = contactos[i].Nombre;
            reporte[i, 1] = contactos[i].Telefono;
            reporte[i, 2] = contactos[i].Email;
        }

        Console.WriteLine("\nREPORTE EN MATRIZ");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"{reporte[i, 0]} | {reporte[i, 1]} | {reporte[i, 2]}");
        }
    }
}

// PROGRAMA PRINCIPAL
class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda(5);

        Console.WriteLine("AGENDA TELEFÓNICA");
        agenda.MostrarContactos();
        agenda.ReporteMatriz();

        Console.ReadKey();
    }
}


// CLASE PRINCIPAL (POO)
class Agenda
{
    private Contacto[] contactos; // VECTOR
    private int contador;

    // CONSTRUCTOR
    public Agenda(int tamaño)
    {
        contactos = new Contacto[tamaño];
        contador = 0;

        // DATOS PRECARGADOS
        contactos[contador].Nombre = "Maria Gonzalez";
        contactos[contador].Telefono = "090000009";
        contactos[contador].Email = "ma.gonzalez@uea.com";
        contador++;
    }

    // REPORTERÍA: MOSTRAR CONTACTOS
    public void MostrarContactos()
    {
        Console.WriteLine("\nLISTA DE CONTACTOS");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Nombre: " + contactos[i].Nombre);
            Console.WriteLine("Teléfono: " + contactos[i].Telefono);
            Console.WriteLine("Email: " + contactos[i].Email);
        }
    }

    // MATRIZ PARA REPORTE
    public void ReporteMatriz()
    {
        string[,] reporte = new string[contador, 3];

        for (int i = 0; i < contador; i++)
        {
            reporte[i, 0] = contactos[i].Nombre;
            reporte[i, 1] = contactos[i].Telefono;
            reporte[i, 2] = contactos[i].Email;
        }

        Console.WriteLine("\nREPORTE EN MATRIZ");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"{reporte[i, 0]} | {reporte[i, 1]} | {reporte[i, 2]}");
        }
    }
}

// PROGRAMA PRINCIPAL
class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda(5);

        Console.WriteLine("AGENDA TELEFÓNICA");
        agenda.MostrarContactos();
        agenda.ReporteMatriz();

        Console.ReadKey();
    }
}