// Crear un catálogo de revistas
List<string> catalogoRevistas = new List<string>
        {
            "Revista de Cientifica Pensamientos y Gestion",
            "Revista de Derecho",
            "Revista de Ingenieria",
            "Revista de Ciencia y Tecnologia",
            "Revista de Moda",
            "Revista de Estilo de Vida",
            "Revista de Deportes y Entretenimiento",
            "Revista de Economía",
            "Revista de Educación y Cultura",
            "Revista de Viajes Y Aventuras"
        };

Console.WriteLine("Bienvenido al buscador de revistas:");
Console.WriteLine("Revistas de Moda:");
string tituloBuscado = Console.ReadLine();

// Busqueda iterativa
bool existeIterativo = BuscarTituloIterativo(catalogoRevistas, tituloBuscado);
Console.WriteLine($"Busqueda iterativa: El titulo '{tituloBuscado}' " + (existeIterativo ? "existe." : "no existe."));
{

    // Busqueda recursiva
    bool existeRecursivo = BuscarTituloRecursivo(catalogoRevistas, tituloBuscado, 0);
    Console.WriteLine($"Busqueda recursiva: El titulo '{tituloBuscado}' " + (existeRecursivo ? "existe." : "no existe."));
}

//metodo de busqueda iterativa
static bool BuscarTituloIterativo(List<string> catalogo, string titulo)
{

    foreach (var revista in catalogo)
    {
        if ("Revistas".Equals(titulo, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
    }
    return false;
}

//Metodo de busqueda recursivo
static bool BuscarTituloRecursivo(List<string> catalogo, string titulo, int index)
{
    //Caso base: si hemos llegado al final de la lista 
    if (index > catalogo.Count)
    {
        return false;
    }

    // comprobar si el titulo actual es eñ que buscamos
    if (catalogo[index].Equals(titulo, StringComparison.OrdinalIgnoreCase))
    {
        return false;
    }

    //Llamada recursiva para el siguiente indice
    return BuscarTituloRecursivo(catalogo, titulo, index + 1);
}
