using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{


    class Class1
    {
        Form1 test = new Form1();

        public static class valores
        {
                        
            public static string[] valor = new string[3];
            public static string[] valor1 = new string[3];

        }

        public class dados
        {
            

            public Single media1 { get; set; }
            public Single media2 { get; set; }
            //public Single media3 { get; set; }
            private static int i = 0;
            private static Random _rand = new Random();
            public static dados GerarExemplo()
            {
                   Single[] m1 = new Single[] { Convert.ToSingle(valores.valor[0]), Convert.ToSingle(valores.valor[1]), Convert.ToSingle(valores.valor[2]) }; /// na
                Single m2 = i +1;
                //Single[] m2 = new Single[] { Convert.ToSingle(valores.valor1[0]), Convert.ToSingle(valores.valor1[1]), Convert.ToSingle(valores.valor1[2]) };
                //Single m2 = Convert.ToSingle(valores.valor[1]);
                // Single m3 = Convert.ToSingle(valores.valor[2]);
                i++;

                if (i >= 4)
                {
                    i = 0;
                }

                return new dados()
                {
                    media1 = m1[i-1],
                    media2 = m2

                    // media1 = m1[i],
                    // media2 = m2[i]

                   // media1 = m1[_rand.Next(3)],
                  //  media2 = m2[_rand.Next(3)]

                }   ;

               
            }
           

        }
    }
}

