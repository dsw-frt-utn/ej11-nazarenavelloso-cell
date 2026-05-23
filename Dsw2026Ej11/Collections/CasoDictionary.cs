namespace Dsw2026Ej11.Collections;
using Domain;
using System.ComponentModel.Design;
using System.Linq.Expressions;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    public void Agregar(int legajo, Alumno Alumno)
    {
        _alumnos.Add(legajo, Alumno);
    }


    public Alumno? Buscar(int legajo) {

        return _alumnos.TryGetValue(legajo, out Alumno alumno) ? alumno : null;

    }

    public void DevolverDiccionario()
    {
        Console.WriteLine("\nAlumnos en el diccionario: ");

        foreach (KeyValuePair<int, Alumno> element in _alumnos)
        {
            Console.WriteLine($"Legajo: {element.Key} - Alumno: {element.Value}");

        }

    }

    public void Eliminar(int legajo)
    {
        _alumnos.TryGetValue(legajo, out Alumno alumno);
        _alumnos.Remove(legajo);

        Console.WriteLine("\nAlumnos en el diccionario: ");

        foreach (KeyValuePair<int, Alumno> element in _alumnos)
        {
            Console.WriteLine($"Legajo: {element.Key} - Alumno: {element.Value}");

        }
    }
}









