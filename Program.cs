using System;
class Complejo
{
    // Campos
    public double real;
    public double imaginario;
}

public class NumerosComplejos
{
    static void Main()
    {
        // Crear dos objetos de la clase Complejo
        Complejo p;
        Complejo q;
        // Asignar memoria a los objetos
        p = new Complejo();
        q = new Complejo();
        // Cargar los datos del número complejo p
        p.real = 4;
        p.imaginario = 10;
        // Cargar los datos del número complejo q
        q.real = -4;
        q.imaginario = 1;
        // Mostrar los números complejos p y q 
        Console.WriteLine("p = {0} + {1}i", p.real, p.imaginario);
        Console.WriteLine("q = {0} + {1}i", p.real, p.imaginario);
    }
}
