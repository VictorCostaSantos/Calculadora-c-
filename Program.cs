using System;

namespace Calculadora
{
    public class Program
    {

         static int oi, ai ;
        public static void Main(string[] args)
        {
            
            Console.WriteLine("<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3\n");
           while(oi == 0)
            {
                Console.WriteLine("Olá, eu sou sua calculadora pessoal e quero te ajudar.\n");
                Console.WriteLine("escolha uma das opções : \n");

                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - subtração");
                Console.WriteLine("3 -Multiplicação");
                Console.WriteLine("4 -Divisão");
                Console.WriteLine("5 - Encerrar\n");

                Console.WriteLine("<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3<3");



                ai = int.Parse(Console.ReadLine());
                switch (ai)
                {

                    case 1:
                        Console.WriteLine("primeiro numero");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        int b = int.Parse(Console.ReadLine());

                        var c = Soma(a, b);

                        Console.WriteLine("O resultado é: "+a+" + "+ b +" = " +c);

                       

                        break;
                    case 2:

                        Console.WriteLine("Subtracao");

                        Console.WriteLine("primeiro numero");
                        int d = int.Parse(Console.ReadLine());

                        Console.WriteLine("Segundo numero");
                        int e = int.Parse(Console.ReadLine());

                        var f = Sub(d, e);
                        Console.WriteLine("O resultado é : " + d +" - "+ e + " = " + f);

                        break;
                    case 3:

                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("primeiro numero");
                        int g = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        int h = int.Parse(Console.ReadLine());

                        var i = Mult(g, h);

                        Console.WriteLine("O resultado é: " + g +" * "+ h + " = " + i);
                        break;
                    case 4:
                        Console.WriteLine("primeiro numeros");
                        float j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo numero");
                        float k = int.Parse(Console.ReadLine());

                        var l = DIV(j, k);

                        Console.WriteLine("O resultado é: " + j +" / "+ k + " = " + l);

                        break;
                    case 5:
                        oi = 1;
                        Console.Clear();
                        break;
                        
                }
                int Soma(int a, int b)
                { return a + b; }
                static int Sub(int a, int b)
                { return a - b; }
                static int Mult(int a, int b)
                { return a * b; }
                static float DIV(float a, float b)
                { return a / b; }




            }
                
        }

       
        

      
    }

  
}
