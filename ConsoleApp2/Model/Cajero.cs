namespace ConsoleApp.Model
{
    public class Cajero : Trabajador
    {
        public string CerrarCaja()
        {
            return "Trabajador ID: " + Id + ", ha cerrado la Caja 1 a las " 
                + DateTime.Now;
        }
    }
}
