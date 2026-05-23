namespace Dsw2026Ej11.Tests;

using Collections;
using Domain;
using System.Security.Cryptography.X509Certificates;

internal class Ejemplos
{

    public static void EjemploList()
    {
        var casoList = new CasoList();

        // Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(1,"guillermo",8.89);
        Alumno a2 = new Alumno(2, "sam", 9.32);
        Alumno a3 = new Alumno(3, "naza", 7.89);

        casoList.Agregar(a1,a2,a3);

        //Listar por consola los alumnos
        casoList.DevolverLista();

        //Buscar por nombre un alumno que exista y mostrar por consola
        casoList.Buscar("guillermo");

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        if (casoList.Buscar("bernabe") is null)
        {
            Console.WriteLine("\nNo existe\n");
        }

        //Eliminar un alumno y listar por consola los alumnos
        casoList.Eliminar(a3);

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        casoList.EliminarPosicion(0);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDictionary = new CasoDictionary();

        Alumno a1 = new Alumno(1, "ana", 8.89);
        Alumno a2 = new Alumno(2, "olivia", 9.32);
        Alumno a3 = new Alumno(3, "martina", 7.89);

        //Agregar 3 alumnos al diccionario

        casoDictionary.Agregar(58340, a1);
        casoDictionary.Agregar(57799, a2);
        casoDictionary.Agregar(59870, a3);

        //Listar por consola los alumnos

        casoDictionary.DevolverDiccionario();

        //Buscar un alumno por clave y mostrar por consola

        Console.WriteLine($"\nAlumno encontrado: {casoDictionary.Buscar(58340)}");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"

        if (casoDictionary.Buscar(54632) is null)
        {
            Console.WriteLine("\nNo existe");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos

        casoDictionary.Eliminar(59870);

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostrar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();

        Console.WriteLine($"\n{casoLinq.GetPrimero()}");
        Console.WriteLine($"\n{casoLinq.GetUltimo()}");
        Console.WriteLine($"\n{casoLinq.getTotalPrecios().ToString("C")}");
        Console.WriteLine($"\n{casoLinq.getPromedioPrecios().ToString("C")}\n");
        Console.WriteLine($"\n{casoLinq.GetListById()}");
        casoLinq.GetLibros();
        Console.WriteLine($"\n{casoLinq.GetMayorPrecio()}");
        Console.WriteLine($"\n{casoLinq.GetMenorPrecio()}\n");
        casoLinq.GetMayorPromedio();
        Console.WriteLine("");
        casoLinq.OrdenarDescendente();
        


    }
}
