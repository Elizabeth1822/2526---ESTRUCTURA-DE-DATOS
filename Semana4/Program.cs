using System;

// REGISTRO (struct) para almacenar datos del contacto
struct Contacto
{
    public string Nombre;
    public string Telefono;
    public string Email;
}

// CLASE Agenda que aplica Programación Orientada a Objetos
class Agenda
{
    private Contacto[] contactos; // Vector de contactos
    private int contador;

    // Constructor
    public Agenda(int tamaño)
    {
        contactos = new Contacto[tamaño];
        contador = 0;

        // Contacto precargado
        contactos[contador].Nombre = "Maria Gonzalez";
        contactos[contador].Telefono = "090000009";
        contactos[contador].Email = "ma.gonzalez@uea.com";
        contador++;
    }

    // Método de reportería: mostrar contactos
    public void MostrarContactos()
    {
        Console.WriteLine("LISTA DE CONTACTOS");
        Console.WriteLine("--------------------");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("Nombre: " + contactos[i].Nombre);
            Console.WriteLine("Teléfono: " + contactos[i].Telefono);
            Console.WriteLine("Email: " + contactos[i].Email);
            Console.WriteLine();
        }
    }

    // Método de reportería usando matriz
    public void ReporteMatriz()
    {
        string[,] reporte = new string[contador, 3];

        for (int i = 0; i < contador; i++)
        {
            reporte[i, 0] = contactos[i].Nombre;
            reporte[i, 1] = contactos[i].Telefono;
            reporte[i, 2] = contactos[i].Email;
        }

        Console.WriteLine("REPORTE EN MATRIZ");
        Console.WriteLine("--------------------");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(
                reporte[i, 0] + " | " +
                reporte[i, 1] + " | " +
                reporte[i, 2]
            );
        }
    }
}

// PROGRAMA PRINCIPAL
class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda(5);

        Console.WriteLine("AGENDA TELEFÓNICA\n");

        agenda.MostrarContactos();
        agenda.ReporteMatriz();

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
✅ Resumen del código original:

Solo hay un contacto precargado: Maria Gonzalez.

Se usa struct para almacenar datos del contacto.

La clase Agenda encapsula un vector y un contador.

Métodos MostrarContactos() y ReporteMatriz() permiten visualizar la información.

El Main crea la agenda y ejecuta los métodos.

Si quieres, puedo ahora hacer el documento completo de tu tarea, respetando que solo haya Maria Gonzalez, listo para entregar con anexos, resultados, conclusiones y referencias.

¿Quieres que haga eso?








