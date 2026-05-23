namespace Dsw2026Ej11.Collections;
using Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> _alumnos = new List<Alumno>();

    public void Agregar(params Alumno [] alumnos)
    {
        _alumnos.AddRange(alumnos);
    }

    public void DevolverLista()
    {
        Console.WriteLine("\nAlumnos en la lista: ");
        foreach (var Alumno in _alumnos)
        {
            
            Console.WriteLine(Alumno.Nombre);
        }
    }

    public Alumno? Buscar(string nombre)
    {
        return _alumnos.Find(a => a.Nombre == nombre);
    }

    public void Eliminar(Alumno alumno)
    {
        _alumnos.Remove(alumno);

        Console.WriteLine("Alumnos en la lista: ");
        foreach (var Alumno in _alumnos)
        {

            Console.WriteLine(Alumno.Nombre);
        }
    }

    public void EliminarPosicion(int posicion)
    {
        _alumnos.RemoveAt(posicion);
        Console.WriteLine("\nAlumnos en la lista: ");
        foreach (var Alumno in _alumnos)
        {

            Console.WriteLine(Alumno.Nombre);
        }
    }


}
