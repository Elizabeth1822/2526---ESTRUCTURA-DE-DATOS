using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaEjercicios
{
    static void Main()
    {
        // ===== EJERCICIO 3 =====
        Console.WriteLine("\n--- EJERCICIO 3: Notas por asignatura ---");
        Dictionary<string, double> notas = new Dictionary<string, double>
        {
            {"Matemáticas", 9.5},
            {"Física", 8.0},
            {"Química", 7.5},
            {"Historia", 9.0},
            {"Lengua", 8.5}
        };
        foreach (var kvp in notas)
            Console.WriteLine($"En {kvp.Key} has sacado {kvp.Value}");

        // ===== EJERCICIO 4 =====
        Console.WriteLine("\n--- EJERCICIO 4: Lotería primitiva ---");
        List<int> numeros = new List<int> { 23, 5, 42, 17, 9, 30 };
        numeros.Sort();
        Console.WriteLine("Números ganadores: " + string.Join(", ", numeros));

        // ===== EJERCICIO 5 =====
        Console.WriteLine("\n--- EJERCICIO 5: Lista inversa ---");
        var lista = Enumerable.Range(1, 10).Reverse();
        Console.WriteLine(string.Join(", ", lista));

        // ===== EJERCICIO 8 =====
        Console.WriteLine("\n--- EJERCICIO 8: Palíndromo ---");
        string palabra = "radar";
        char[] invertida = palabra.ToCharArray();
        Array.Reverse(invertida);
        Console.WriteLine(palabra == new string(invertida)
            ? $"La palabra '{palabra}' es palíndromo"
            : $"La palabra '{palabra}' no es palíndromo");

        // ===== EJERCICIO 10 =====
        Console.WriteLine("\n--- EJERCICIO 10: Precios mínimo y máximo ---");
        int[] valores = { 50, 75, 46, 22, 80, 65, 8 };
        Console.WriteLine($"Menor precio: {valores.Min()}");
        Console.WriteLine($"Mayor precio: {valores.Max()}");
    }
}
