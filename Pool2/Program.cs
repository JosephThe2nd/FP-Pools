using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema1();
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

        }
        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor.
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void Problema17()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x, sum = 0, max = 0;
            for (int i = 0; i < n && sum >= 0; i++)
            {
                x = int.Parse(Console.ReadLine());

            }
        }

        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica 
        /// prin rotiri succesive (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
        /// </summary>
        private static void Problema16()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        private static void Problema15()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b;
            b = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n - 1; i++)
            {
                a = b;
                b = int.Parse(Console.ReadLine());

                if (a > b)
                    break;
            }
            i++;
            if (i != n)
            {
                for (; i < n - 1; i++)
                {
                    a = b;
                    b = int.Parse(Console.ReadLine());
                    if (a < b)
                        break;
                }
                i++;
            }
            if(i==n)
            {
                Console.WriteLine("Secventa este una bitonica");
            }
            else
                Console.WriteLine("Secventa nu este una bitonica");

        }

        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void Problema14()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b;
            b = int.Parse(Console.ReadLine());
            int nr = b;
            bool crescatoare = true;
            bool down = false;
            bool descrescatoare = true;
            bool up = false;
            for (int i = 0; i < n - 1 && (crescatoare || descrescatoare); i++)
            {
                a = b;
                b = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    if (down)
                        crescatoare = false;
                    down = true;
                }
                if(a < b)
                {
                    if (up)
                        descrescatoare = false;
                    up = true;
                }

            }
            if (b > nr && down)
                crescatoare = false;

            if (b < nr && up)
                descrescatoare = false;
            if(crescatoare||descrescatoare)
                Console.WriteLine($"Secventa este o secventa monotona rotita");
            else
                Console.WriteLine($"Secventa este o secventa monotona rotita");
        }

        /// <summary>
        /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata 
        /// intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void Problema13()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b;
            b = int.Parse(Console.ReadLine());
            int nr = b;
            bool crescatoare = true, down = false;
            for (int j = 0; j < n - 1 && crescatoare; j++)
            {
                a = b;
                b  = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    if (down)
                        crescatoare = false;
                    down = true;
                }
            }
            if (b > nr && down)
                crescatoare = false;

            if(crescatoare)
                Console.WriteLine("Secventa este o secventa crescatoare rotita");
            else
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita");

        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void Problema12()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b;
            int i;
            bool ok = false;
            int nrS = 0;
            b = int.Parse(Console.ReadLine());
            a = b;
            for (i = 1; i < n; i++)
            {
                a = b;
                b = int.Parse(Console.ReadLine());

                if (a == 0 && b != 0)
                    ok = true;

                if (a != 0 && b == 0 && ok == true)
                    nrS++;

                if (a > b)
                    ok = false;

            }
            if (ok == true)
                nrS++;
            Console.WriteLine($"In secventa sunt {nrS} grupuri de numere consecutive diferite de zero.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
        /// </summary>
        private static void Problema11()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int m, aux, sum = 0, x;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                aux = x;
                m = 0;
                while (aux != 0)
                {
                    m = m * 10 + aux % 10;
                    aux /= 10;
                }
                sum += m;
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este {sum}.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void Problema10()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int nr = x, maxnow = 1, max = 1;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == nr)
                    maxnow++;
                else
                {
                    if (maxnow > max)
                        max = maxnow;
                    maxnow = 1;
                    nr = x;
                }
                if (maxnow > max)
                    max = maxnow;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {max}.");
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona.
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void Problema9()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b;
            if (n > 1)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                int i;
                bool crescator = true;
                for (i = 2; i < n && a == b; i++)
                {
                    a = b;
                    b = int.Parse(Console.ReadLine());
                }
                if (i == n)
                    Console.WriteLine("Toate elementele din secventa sunt egale.");
                else
                {
                    if (a > b)
                        crescator = false;
                    if (crescator == true)
                    {
                        for (; i < n && a <= b; i++)
                        {
                            a = b;
                            b = int.Parse(Console.ReadLine()); 
                        }
                        if (i == n)
                            Console.WriteLine("Secventa de numere este monoton crescatoare.");
                        else
                            Console.WriteLine("Secventa de numere nu este monotona.");

                    }
                    else
                    {
                        for (; i < n && a >= b; i++)
                        {
                            a = b;
                            b = int.Parse(Console.ReadLine());
                        }
                        if(i == n)
                            Console.WriteLine("Secventa de numere este monoton descrescatoare.");
                        else
                            Console.WriteLine("Secventa de numere nu este monotona.");
                    }
                }
            }
            else
                Console.WriteLine("Secventa trebuie sa contina mai mult de 1 element.");
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void Problema8()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                int a = 0, b = 1;
                int c = 0;
                if (n == 1 || n == 2)
                {
                    Console.WriteLine("Termenul este 1");
                }
                else
                {

                    for (int i = 3; i <= n; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }

                    Console.WriteLine($"Al {n}-lea numar din sirul Fibonacci este {c}.");
                }
            }
            else
                Console.WriteLine("Numarul n trebuie sa fie mai mare ca 0.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        private static void Problema7()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int min = x;
            int max = x;
            for (int i = 1; i < n; i++)
            {
                if (x < min)
                    min = x;
                else if (x > max)
                    max = x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Cel mai mare numar din secventa este {max} iar cel mai mic numar din secventa este {min}.");

        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        private static void Problema6()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a, b, i;
            a = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    break;
                a = b;
            }
            if(i==n)
                Console.WriteLine($"Secventa de {n} numere este in ordine crescatoare");
            else
                Console.WriteLine($"Secventa de {n} numere nu este in ordine crescatoare");
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
        /// Se considera ca primul element din secventa este pe pozitia 0.
        /// </summary>
        private static void Problema5()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int s = 0, x;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i)
                    s++;
            }
            Console.WriteLine($"In secventa exista {s} numere egale cu pozitia pe care apar in secventa.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void Problema4()
        {
            Console.WriteLine($"Introduceti un numar intreg n ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul careia ii cautati pozitia ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti secventa de {n} numere");
            int x, pozitie = -1;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                    pozitie = i;
            }
            Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitie} in secventa.");
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void Problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0, p = 1;
            for (int i = 1; i <= n; i++)
            {
                s += i;
                p *= i;

            }
            Console.WriteLine($"Suma tuturor elementelor de la 1 la {n} este {s} iar produsul elementelor este {p}.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void Problema2()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int pozitive = 0, zero = 0, negative = 0, x;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    negative++;
                else if (x == 0)
                    zero++;
                else
                    pozitive++;
            }
            Console.WriteLine($"Secventa are {negative} numere negative, {zero} numere egale cu 0 si {pozitive} numere pozitive.");
        }
        

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
        /// </summary>
        private static void Problema1()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente , fiecare pe cate o linie:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    sum++;
            }
            Console.WriteLine($"Vectorul are {sum} numere pare.");
        }
    }
}
