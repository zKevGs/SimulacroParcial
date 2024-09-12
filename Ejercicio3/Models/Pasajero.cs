namespace Taxis.Models
{
    public class Pasajero
    {
        public string Nombre { get; private set; }
        public string Direecion { get; private set; }
        public bool Membresia { get; private set; }

        public Pasajero(string nombre, string direecion, bool membresia)
        {
            Nombre = nombre;
            Direecion = direecion;
            Membresia = false;
        }
        public void IniciarViaje()
        {

        }
    }
}
