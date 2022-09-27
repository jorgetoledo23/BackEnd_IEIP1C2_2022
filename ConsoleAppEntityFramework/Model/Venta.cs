namespace ConsoleAppEntityFramework.Model
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }


        //Foreign Key
        public string ClienteRut { get; set; }

        //Propiedad Navegacion
        public Cliente Cliente { get; set; }
    }
}
