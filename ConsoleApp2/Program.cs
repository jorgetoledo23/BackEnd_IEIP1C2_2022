using ConsoleApp.Model;

/*
Console.WriteLine("Hello, World!");

//Clase - Objeto - Instancia

Persona Juanito;
Persona Pedrito;

//Generar Instancia
Juanito = new Persona("Juan");
Pedrito = new Persona("1.111.111-1"); */

/*

//Herencia clase Abstracta 

Gato Garfield = new Gato("Garfield", "Gato", "Domestico", "Gato Romano", false);
Console.WriteLine("Garfield dice " + Garfield.EmitirSonido());

Perro Guffy = new Perro("Guffy", "Perro", "Domestico", "Labrador", false);
Console.WriteLine("Guffy dice " + Guffy.EmitirSonido());

*/


/* Apartado Trabajadores */

Trabajador T1 = new Trabajador()
{
    Id = 1,
    Name = "Camilo",
    Apellido = "Cesto",
    Telefono = "+569 1234 5678"
};

Cajero C1 = new Cajero()
{
    Id = 2,
    Name = "Javier",
    Apellido = "Hernandez",
    Telefono = "+569 4321 9876"
};

C1.GenerarVenta();
C1.CerrarCaja();
C1.ImprimirReporte();

T1.GenerarVenta();
T1.ImprimirReporte();
//T1.CerrarCaja(); //Error 

JefeVentas Jefe = new JefeVentas()
{
    Id = 2,
    Name = "Alexis",
    Apellido = "Sanchez",
    Telefono = "+569 5678 1234"
};

Console.WriteLine(Jefe.ImprimirReporte());
Console.WriteLine(T1.ImprimirReporte());

