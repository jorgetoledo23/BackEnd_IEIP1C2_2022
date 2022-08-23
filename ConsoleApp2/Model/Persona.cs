namespace ConsoleApp.Model
{
    public class Persona
    {
        //prop + tab
        public string Rut { get; set; }
        public string Name { get; }

        //ctor => Constructor
        public Persona(string name)
        {
            Name = name;
        }

        public Persona(string rut, string name)
        {
            Rut = rut;
            Name = name;
        }

    }
}
