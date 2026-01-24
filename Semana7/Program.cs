using System;
using System.Collections.Generic;

class BalanceoExpresion
{
    /// <summary>
    /// Verifica si una expresión matemática tiene paréntesis, llaves y corchetes balanceados.
    /// </summary>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es un símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre, se verifica
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();

                if (!Coinciden(tope, c))
                    return false;
            }
        }

        // Si la pila queda vacía, está balanceada
        return pila.Count == 0;
    }

    /// <summary>
    /// Verifica si un par de símbolos coinciden.
    /// </summary>
    static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
