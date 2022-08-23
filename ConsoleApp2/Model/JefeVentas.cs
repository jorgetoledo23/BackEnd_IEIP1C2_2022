namespace ConsoleApp.Model
{
    public class JefeVentas : Trabajador
    {

        public string NCredencial { get; set; }
        public string GenerarReporte2()
        {
            return "Jefe Genera Reporte";
        }

        public override string ImprimirReporte()
        {
            return "Trabajador ID: " + Id + ", " +
                "ha generado un Reporte de Ventas el "
                + DateTime.Now + "y lo Firma!";
        }
    }
}
