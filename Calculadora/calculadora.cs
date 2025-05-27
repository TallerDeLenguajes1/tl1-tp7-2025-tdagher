namespace EspacioCalculadora
{

    public class Calculadora
    {
        //Variables de la calculadora
        private double termino1, termino2, resultado;
        private int operacionARealizar;


        //inicializar terminos
        public Calculadora(double termino1, double termino2, int operacionARealizar)
        {
            this.termino1 = termino1;
            this.termino2 = termino2;
            this.operacionARealizar = operacionARealizar;
        }

        //METODOS
        void Sumar(double termino1, double termino2)
        {
            resultado = termino1 + termino2;
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