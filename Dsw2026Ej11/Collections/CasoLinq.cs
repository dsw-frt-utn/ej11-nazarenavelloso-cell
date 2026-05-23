namespace Dsw2026Ej11.Collections;
using Domain;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{

    List<Libro> _libros = Libro.CrearLista();

        public Libro? GetPrimero(){

        return (from libro in _libros

            where libro.Id ==1
            select libro).FirstOrDefault();
        }

    public Libro? GetUltimo()
    {

        return (from libro in Libro.CrearLista()

                where libro.Id == 30
                select libro).LastOrDefault();
    }

    public decimal getTotalPrecios()
    {
        return _libros.Sum(lib => lib.Precio);
 
    }

    public decimal getPromedioPrecios()
    {
        return _libros.Average(lib => lib.Precio);
    }

    public List<Libro> GetListById()
    {
        List<Libro> librosFiltrados = _libros.Where(lib => lib.Id > 15).ToList();

        foreach(var libro in librosFiltrados)
        {
            Console.WriteLine(libro.Titulo);
        }

        return null;
    }

    public List<string> GetLibros()
    {

        var librosLista = _libros
         .Select(lib => $"{lib.Titulo} - {lib.Precio:C}")
         .ToList();

        foreach (var libro in librosLista)
        {
            Console.WriteLine(libro);
        }

        return librosLista;
    }

    public Libro GetMayorPrecio()
    {
        return _libros.OrderByDescending(l => l.Precio).FirstOrDefault();
    }

    public Libro GetMenorPrecio()
    {
        return _libros.OrderBy(l => l.Precio).FirstOrDefault();
    }


    public List <Libro> GetMayorPromedio()
    {
        var promedio = getPromedioPrecios();

        List<Libro> librosMayores = _libros.Where(lib => lib.Precio > promedio).ToList();


        foreach (var libro in librosMayores)
        {
            Console.WriteLine(libro);
        }

        return librosMayores;

    }

    public List <Libro> OrdenarDescendente()
    {
        List<Libro> librosOrdenados = _libros
       .OrderByDescending(libro => libro.Titulo)
       .ToList();

        foreach (var libro in librosOrdenados)
        {
            Console.WriteLine(libro);
        }

        return librosOrdenados;

    }

}


