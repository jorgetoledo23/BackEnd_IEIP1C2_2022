namespace ConsoleApp.Model
{
    public class Trabajador
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public string GenerarVenta()
        {
            return "Trabajador ID: " + Id + ", ha generado una venta el " + DateTime.Now;
        }

        public virtual string ImprimirReporte()
        {
            return "Trabajador ID: " + Id + ", ha generado un Reporte de Ventas el " + DateTime.Now;
        }

    }
}
