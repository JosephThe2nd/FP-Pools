using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            //Problema6();
            //Problema7();
            //Problema8();
            //Problema9();
            //Problema10();
            //Problema11();
            //Problema12();
            //Problema13();
            //Problema14();
            //Problema15();
            //Problema16();
            //Problema17();
            //Problema18();x
            //Problema19();
            //Problema20();x
            Problema21();




        }
        /// <summary>
        /// Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>
        private static void Problema21()
        {
            
        }

        /// <summary>
        ///  Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
        ///  O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        ///  O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
        ///  O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        /// </summary>
        private static void Problema20()
        {
            
        }

        /// <summary>
        /// Determinati daca un numar e format doar cu 2 cifre care se pot repeta. 
        /// De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
        /// </summary>
        private static void Problema19()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = false;
            int n1 = n;
            int a = n1 % 10, b = 0;
            n1 /= 10;

            while (n1 != 0 && ok == false)
            {
                if (n1 % 10 != a)
                {
                    b = n1 % 10;
                    ok = true;
                }
                n1 /= 10;
            }

            while (n1 != 0 && ok == true)
            {
                if (n1 % 10 != a && n1 % 10 != b)
                    ok = false;
                n1 /= 10;
            }

            if (ok)
                Console.WriteLine($"Numarul {n} este format din 2 cifre care se pot repeta");
            else
                Console.WriteLine($"Numarul {n} nu este format din 2 cifre care se pot repeta");

        }

        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        private static void Problema18()
        {
            int n = int.Parse(Console.ReadLine());

            
        }

        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.
        /// </summary>
        private static void Problema17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int auxa = a;
            int auxb = b;
            int rest;
            while (auxb != 0)
            {
                rest = auxa % auxb;
                auxa = auxb;
                auxb = rest;     
            }
            int cmmc = (a * b) / auxa;
            Console.WriteLine($"C.m.m.d.c. dintre a si b este {auxa} iar c.m.m.c dintre a si b este {cmmc}.");
        }

        /// <summary>
        /// Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void Problema16()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            if (a > b)
                (a, b) = (b, a); 
            if (a > c)
                (a, c) = (c, a);
            if (a > d)
                (a, d) = (d, a);
            if (a > e)
                (a, e) = (e, a);

            if (b > c)
                (b, c) = (c, b);
            if (b > d)
                (b, d) = (d, b);
            if (b > e)
                (b, e) = (e, b);

            if (c > d)
                (c, d) = (d, c);
            if (c > e)
                (c, e) = (e, c);

            if (d > e)
                (d, e) = (e, d);
            Console.WriteLine($"Numerele ordonate crescator sunt: {a} {b} {c} {d} {e}");

        }

        /// <summary>
        ///Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        /// </summary>
        private static void Problema15()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.Write($"Numerele in ordine crescatoare sunt:");

            if (a >= b && a >= c)
            {
                if (b >= c)
                
                    Console.Write($"{c} {b} {a}");
                
                else
                    Console.Write($"{b} {c} {a}");
            }
            if(b >= a && b >= c)
            {
                if(a >= c)
                    Console.Write($"{c} {a} {b}");
                else
                    Console.Write($"{a} {c} {b}");
            }
            if (c >= a && c >= b)
            {
                if (a >= b)
                    Console.Write($"{b} {a} {c}");
                else
                    Console.Write($"{a} {b} {c}");
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        /// </summary>
        private static void Problema14()
        {
            int n = int.Parse(Console.ReadLine());
            int palindrom = 0;
            int aux = n;
            while (n != 0)
            {
                palindrom = palindrom * 10 + n % 10;
                n /= 10;
            }

            if (palindrom == aux)
                Console.WriteLine($"Numarul {aux} este palindrom.");
            else
                Console.WriteLine($"Numarul {aux} nu este palindrom.");
        }

        /// <summary>
        /// Determianti cati ani bisecti sunt intre anii y1 si y2
        /// </summary>
        private static void Problema13()
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = y1+1; i < y2; i++)
                if (i % 4 == 0)
                    nr++;
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti");
                
        }

        /// <summary>
        /// Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void Problema12()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divizorii numarului {n} din intervalul [{a},{b}] sunt: ");
            for (int i = a; i <= b; i++)
            {
                if (n % i == 0)
                    Console.Write($"{i} ");
            }
        }

        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void Problema11()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Oglinditul numarului {n} este: ");
            while(n != 0) 
            {
                Console.Write($"{n % 10}");
                n /= 10;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void Problema10()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrim = true;
            if (n < 2 || n > 2 && n % 2 == 0)
                isPrim = false;
            for (int i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    isPrim = false;               
            if (isPrim) 
                Console.WriteLine($"Numarul {n} este prim ");
            else
                Console.WriteLine($"Numarul {n} nu este prim ");
            
        }

        /// <summary>
        /// Afisati toti divizorii numarului n. 
        /// </summary>
        private static void Problema9()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii numarului {n} sunt: ");
            for(int i = 1; i<=n ; i++)
            {
                if(n % i == 0)
                    Console.Write($"{i}, ");
            }

        }

        /// <summary>
        /// (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        /// </summary>
        private static void Problema8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Variabila a este acum {a} si b este {b}");
        }

        /// <summary>
        /// (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        /// Se cere sa se inverseze valorile lor.
        /// </summary>
        private static void Problema7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"variabila a este acum {a} si b este {b}");
        }

        /// <summary>
        /// Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        /// </summary>
        private static void Problema6()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (c + b) > a)
                Console.WriteLine($"Numerele a = {a}, b = {b} si c = {c} pot fi lungimile laturilor unui triunghi.");
            else
                Console.WriteLine($"Numerele a = {a}, b = {b} si c = {c} nu pot fi lungimile laturilor unui triunghi.");

        }

        /// <summary>
        /// Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
        /// </summary>
        private static void Problema5()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int cifra = 0;
            while (k > 0)
            {
                cifra = n % 10;
                n = n / 10;
                k--;
            }
            Console.WriteLine(cifra);
        }

        /// <summary>
        /// Detreminati daca un an y este an bisect.
        /// </summary>
        private static void Problema4()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 4 == 0) 
                Console.WriteLine($"Anul {n} este an bisect");
            else
                Console.WriteLine($"Anul {n} nu este an bisect");
        }

        /// <summary>
        /// Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        /// </summary>
        private static void Problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());           
            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
                
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        /// Tratati toate cazurile posibile.
        /// </summary>
        private static void Problema2()
        {
        
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (delta > 0)
                Console.WriteLine($"Radacina x1 este {(-b + Math.Sqrt(delta)) / 2 * a} si x2 este {(-b - Math.Sqrt(delta)) / 2 * a}.");
            else if (delta ==0)
                Console.WriteLine($"Radacina x este unica si este  {(-b)/ 2 * a}.");
            else
                Console.WriteLine("Radacina nu este numar real");
        }

        /// <summary>
        /// Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void Problema1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = 0;

            if (a > 0 && b > 0)
            {
                x = -b / a;
            }
            Console.WriteLine($"x = {x}");       
        }
    }
}
