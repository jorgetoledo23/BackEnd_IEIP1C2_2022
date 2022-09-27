using ConsoleAppEntityFramework.Model;

/*
Insertar 
 */

var context = new AppDbContext();

var P = new Producto()
{
    Name = "Leche",
    Precio = 123,
    Stock = 123,
    UrlImagen = "www.google.cl"
};

var C = new Cliente()
{
    Rut = "11.111.111-1",
    Nombre = "Juan",
    Apellido = "Perez",
    Telefono = "12345678"
};

// Insert into Productos

context.Add(P);
context.Add(C);

context.SaveChanges();


/*
Leer 
 */

//Select * From Clientes / Productos

var Clientes = context.Clientes.ToList();
var Productos = context.Productos.ToList();


var ClientesOrdenadosASC = context.Clientes.OrderBy(x => x.Nombre).ToList();
var ClientesOrdenadosDESC = context.Clientes.OrderByDescending(x => x.Nombre).ToList();

var ClienteBuscado = context.Clientes.Where(x => x.Nombre.Equals("Juan")).FirstOrDefault(); //TOP 1
var ClienteBuscado2 = context.Clientes.Where(x => x.Nombre.Equals("Juan")).ToList(); //Todos Juan

var ClientesConJ = context.Clientes.Where(x => x.Nombre.StartsWith("j")).ToList();

string rut = "x";
//Cliente con el rut especificado
var ClienteRut = context.Clientes.Where(x => x.Rut.Equals(rut)).FirstOrDefault();

string filtro = "Parlante";
//Todos los productos que contengan la palabra filtro
var ProductosFiltrados = context.Productos
    .Where(p=> p.Name.Contains(filtro)).ToList();

//Todos los productos que contengan la palabra filtro
//y su precio sea menor a 100.000
var ProductosFiltrados2 = context.Productos
    .Where(p => p.Name.Contains(filtro) && p.Precio < 100000).ToList();



/* Actualizar  
 * Update Clientes set Telefono = '12341234' Where Rut = 'x' */

ClienteRut.Telefono = "+56 9 1234 5678";


var clienteModificado = context.Attach(ClienteRut);
clienteModificado.Property(x => x.Telefono).IsModified = true;
context.SaveChanges();


context.Update(ClienteRut);
context.SaveChanges();


/* Eliminar */

context.Remove(ClienteRut);
context.SaveChanges();



