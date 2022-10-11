using ConsoleAppEntityFramework.Model;

do
{
    Console.WriteLine("[1] - Agregar Categoria");
    Console.WriteLine("[2] - Listar Categorias");
    Console.WriteLine("[3] - Actualizar Categoria Existente");
    Console.WriteLine("[4] - Buscar Categoria por ID");
    Console.WriteLine("[5] - Buscar Categoria por Nombre");

    Console.WriteLine("\n============================\n");

    Console.WriteLine("[6] - Agregar Producto");
    Console.WriteLine("[7] - Listar Productos");
    Console.WriteLine("[8] - Actualizar Producto Existente");
    Console.WriteLine("[9] - Buscar Producto por ID");
    Console.WriteLine("[10] - Buscar Productos por Nombre de Categoria");

    Console.Write("\nSelecciona una Opcion: ");
    var opcionSeleccionada = Console.ReadLine();

    switch (opcionSeleccionada)
    {
        case "1":
            var x = 1;
            break;
        default:
            break;
    }

} while (true);
