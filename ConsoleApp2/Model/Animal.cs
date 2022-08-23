namespace ConsoleApp.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string NombreCientifico { get; set; }
        public string Habitat { get; set; }
        public string Especie { get; set; }
        public bool enPeligroExtincion { get; set; }

        public Animal(string name, 
            string ncientifico, 
            string habitat, string especie, bool enpeligro)
        {
            Name = name;
            NombreCientifico = ncientifico;
            Habitat = habitat;
            Especie = especie;
            enPeligroExtincion = enpeligro;
        }

        public abstract string EmitirSonido();

    }
}
