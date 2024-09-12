namespace Taxis.Models
{
    public class Conductor
    {
        public string Nombre { get; private set; }
        public double NumeroLicencia { get; private set; }
        public bool Estado {  get; private set; }

        public Conductor(string nombre, double numeroLicencia, bool estado)
        {
            Nombre = nombre;
            NumeroLicencia = numeroLicencia;
            Estado = true;
        }
        public bool CambiarEstado()
        {

        }
    }
}
