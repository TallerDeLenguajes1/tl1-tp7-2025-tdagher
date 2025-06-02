namespace EspacioCalculadora
{
    public class Calculadora
    {
        // Campo privado
        private double dato;

        // Constructor
        public Calculadora()
        {
            dato = 0;
        }

        // Métodos
        public void Sumar(double termino)
        {
            dato += termino;
        }

        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }

        public void Limpiar()
        {
            dato = 0;
        }

        // Propiedad Resultado (solo get)
        public double Resultado
        {
            get { return dato; }
        }
    }
}
