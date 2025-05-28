namespace EspacioCalculadora
{

    public class Calculadora
    {
        //Variables de la calculadora
        private double dato, resultado;
        private int operacionARealizar;


        //inicializar terminos
        public Calculadora(double dato = 0, int operacionARealizar)
        {
            this.dato = dato;
            this.operacionARealizar = operacionARealizar;
        }

        //METODOS
        void Sumar(double termino)
        {
            dato += termino;
        }
        void Restar(double termino1, double termino2)
        {
            resultado = termino1 - termino2;
        }
        void Multiplicar(double termino1, double termino2)
        {
            resultado = termino1 * termino2;
        }
        void Dividir(double termino1, double termino2)
        {
            resultado = termino1 / termino2;
        }
        void Limpiar(double termino1, double termino2)
        {

        }
        void calcularResultado()
        {
            switch (operacionARealizar)
            {
                case 1:
                    Sumar(termino1, termino2);
                    break;
                case 2:
                    Restar(termino1, termino2);
                    break;
                case 3:
                    Multiplicar(termino1, termino2);
                    break;
                case 4:
                    Dividir(termino1, termino2);
                    break;
                case 5:
                    Limpiar(termino1, termino2);
                    break;

            }
        }
    }
}





// 
// ● void Restar(double termino)
// ● 
// ● 
// ● 