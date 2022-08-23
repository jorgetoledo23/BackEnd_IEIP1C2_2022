namespace ConsoleApp.Model
{
    public class Gato : Animal
    {
        public Gato(string name, string ncientifico, string habitat, string especie, bool enpeligro) 
            : base(name, ncientifico, habitat, especie, enpeligro)
        {
        }

        public override string EmitirSonido()
        {
            return "Miau";
        }
    }
}
