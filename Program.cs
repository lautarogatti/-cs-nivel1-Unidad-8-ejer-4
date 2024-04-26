using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.*/
            int n, r = 0;

            Console.WriteLine("Ingrese un Numero");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(n, ref r);

            Console.WriteLine("r = " + r);
        }

        static void positivoNegativoCero(int n, ref int r){
            if (n > 0){
                r = 1;
            } else if (n == 0){
                r = 0;
            } else {
                r = -1;
            }
        }
    }
}
