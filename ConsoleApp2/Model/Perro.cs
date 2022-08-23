namespace ConsoleApp.Model
{
    public class Perro : Animal
    {
        public Perro(string name, string ncientifico, string habitat, string especie, bool enpeligro) : base(name, ncientifico, habitat, especie, enpeligro)
        {
        }

        public override string EmitirSonido()
        {
            return "Ladra";
        }
    }
}
