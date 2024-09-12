namespace Tiendita.Models
{
    public class Clientes
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public string Codigo { get; private set; }

        public Clientes(string nombre, double telefono, string codigo) 
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;
        }

        public void MostrarCliente()
        {
            Console.WriteLine($"Cliente {Nombre} de Codigo: {Codigo} y de Telefono: {Telefono}");
        }
    }
}
