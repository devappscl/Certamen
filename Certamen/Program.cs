using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //VARIABLES
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);
            Console.WriteLine("--------------------------------------------------------------");

            //CARGAR VARIABLE A
            bool flag = true;


            //WHILE PARA CONSULTAR EN CASO DE NO SER UN NÚMERO
            while (flag)
            {

                //MANEJAR EXCEPCIONES
                try
                {

                    //PREGUNTA NUMERO CONSOLA
                    Console.WriteLine("INGRESE NUMERO  N1: ");
                    //PARSEA LA VARIABLE NUMERO EN ENTERO, EN CASO DE QUE SEA STRING SE GENERA LA EXCEPCIÓN
                    n1 = int.Parse(Console.ReadLine());
                    // SALE DEL CICLO
                    flag = false;


                }
                catch (Exception ex)
                {
                      flag = true;
                    Console.Clear();
                    Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);
                    Console.WriteLine("Error: Ingrese sólo números.");

                }

            }

            Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);

            //CARGAR VARIABLE B
            bool flag1 = true;


            //WHILE PARA CONSULTAR EN CASO DE NO SER UN NÚMERO
            while (flag1)
            {

                //MANEJAR EXCEPCIONES
                try
                {

                    //PREGUNTA NUMERO CONSOLA
                    Console.WriteLine("INGRESE NUMERO  N2: ");
                    //PARSEA LA VARIABLE NUMERO EN ENTERO, EN CASO DE QUE SEA STRING SE GENERA LA EXCEPCIÓN
                    n2 = int.Parse(Console.ReadLine());
                    // SALE DEL CICLO
                    flag1 = false;


                }
                catch (Exception ex)
                {
                     flag1 = true;
                    Console.Clear();
                    Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);
                    Console.WriteLine("Error: Ingrese sólo números.");

                }

            }

            Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);

            //CARGAR VARIABLE C
            bool flag2 = true;


            //WHILE PARA CONSULTAR EN CASO DE NO SER UN NÚMERO
            while (flag2)
            {

                //MANEJAR EXCEPCIONES
                try
                {

                    //PREGUNTA NUMERO CONSOLA
                    Console.WriteLine("INGRESE NUMERO  N3: ");
                    //PARSEA LA VARIABLE NUMERO EN ENTERO, EN CASO DE QUE SEA STRING SE GENERA LA EXCEPCIÓN
                    n3 = int.Parse(Console.ReadLine());
                    // SALE DEL CICLO
                    flag2 = false;


                }
                catch (Exception ex)
                {
                     flag2 = true;
                    Console.Clear();
                    Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);
                    Console.WriteLine("Error: Ingrese sólo números.");

                }

            }

            Console.WriteLine("N1 = {0} | N2 = {1} | N3 = {2}", n1, n2, n3);


            //ORDENAR DE MAYOR A MENOR
            Console.WriteLine("ORDENAR DE MENOR A MAYOR: ");

            int[] arr = new int[] { n1, n2, n3};

            Array.Sort(arr);

            int a = arr[0];
            int b = arr[1];
            int c = arr[2];

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);



            //OPERACIONES
            Console.WriteLine("OPERACIONES");
            Console.WriteLine("DIFERENCIA ENTRE C y A = {0}", c - a);
            Console.WriteLine("DIFERENCIA ENTRE B y A = {0}", b - a);
            Console.WriteLine("DIFERENCIA ENTRE B y C = {0}", b - c);


            //MOSTRAR PARES DEL A AL C

            Console.WriteLine("MOSTRAR NUMEROS PARES DEL A AL C");

            for (int i = a; i <= c; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                 
            }


            //MOSTRAR IMPARES DEL C AL A

            Console.WriteLine("MOSTRAR NUMEROS IMPARES DEL C AL A");

            for (int i = c; i >= a; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            //MOSTRAR MES SI LA DIFERENCUA DEL C AL A ES MENOR A 12

            int mes = c - a;
            Console.WriteLine("LA DIFERENCIA ES " + mes);
            Console.WriteLine("MOSTRAR MES DEL AÑO SI LA DIFERENCIA ENTRE C Y A ES MENOR O IGUAL A 12");
            switch (mes)
            {
                case 1: Console.WriteLine("ENERO");break;
                case 2: Console.WriteLine("FEBRERO"); break;
                case 3: Console.WriteLine("MARZO"); break;
                case 4: Console.WriteLine("ABRIL"); break;
                case 5: Console.WriteLine("MAYO"); break;
                case 6: Console.WriteLine("JUNIO"); break;
                case 7: Console.WriteLine("JULIO"); break;
                case 8: Console.WriteLine("AGOSTO"); break;
                case 9: Console.WriteLine("SEPTIEMBRE"); break;
                case 10: Console.WriteLine("OCTUBRE"); break;
                case 11: Console.WriteLine("NOVIEMBRE"); break;
                case 12: Console.WriteLine("DICIEMBRE"); break;
            }

            //MOSTRAR MES SI LA DIFERENCUA DEL B AL A ES MENOR A 7

            int dia = b - a;
            Console.WriteLine("LA DIFERENCIA ES " + dia);
            Console.WriteLine("MOSTRAR DIA DE LA SEMANA SI LA DIFERENCIA ENTRE B Y A ES MENOR O IGUAL A 7");
            switch (dia)
            {
                case 1: Console.WriteLine("LUNES"); break;
                case 2: Console.WriteLine("MARTES"); break;
                case 3: Console.WriteLine("MIERCOLES"); break;
                case 4: Console.WriteLine("JUEVES"); break;
                case 5: Console.WriteLine("VIERNES"); break;
                case 6: Console.WriteLine("SABADO"); break;
                case 7: Console.WriteLine("DOMINGO"); break;
            }


            Console.ReadKey();  


        }


    }
}
