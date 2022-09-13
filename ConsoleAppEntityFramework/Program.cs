using ConsoleAppEntityFramework.Model;

do
{
    Console.WriteLine("[1] - Insertar New Product");
    Console.WriteLine("[2] - Ver Products");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Producto P = new Producto()
            {
                Name = "Logitech G915 TKL Carbon",
                Stock = 20,
                Precio = 189990,
                UrlImagen = "https://publicapi.solotodo.com/products/82384/picture/?width=375&height=375"
            };

            using(var context = new AppDbContext())
            {
                context.Add(P); // Insert into Productos values ()
                context.SaveChanges();
            }

            Console.WriteLine("Producto Agregado! Presiona Enter para Continuar...");
            Console.ReadLine();
            break;

        case "2":

            using (var context = new AppDbContext())
            {
                foreach (var product in context.Productos.ToList()) // Select * From Productos
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, " +
                        $"Stock: {product.Stock}, UrlImagen: {product.UrlImagen}");
                }
            }
            Console.WriteLine("Productos listados! Presiona Enter para Continuar...");
            Console.ReadLine();

            break;
    }



} while (true);

