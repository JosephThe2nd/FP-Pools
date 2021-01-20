using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
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
            Problema16();
            //Problema17();
            //Problema18();
            //Problema19();
            //Problema20();
            //Problema21();
            //Problema22();
            //Problema23();
            //Problema24();
            //Problema25();
            //Problema26();
            //Problema27();
            //Problema28();
            //Problema29();
            //Problema30();
            //Problema31();


        }
        /// <summary>
        /// Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        /// </summary>
        private static void Problema16()
        {
            
        }

        /// <summary>
        /// Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
        /// </summary>
        private static void Problema15()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int length = n;
            for (int i = 0; i < length - 1; i++)
                for (int j = i + 1; j < length; j++)
                    if(v[i] == v[j])
                    {
                        for (int k = j + 1; k < length; k++)
                            v[k - 1] = v[k];
                        length--;
                        j--;
                    }
            Console.WriteLine("Vectorul nou format fara elemente care se repeta este:");
            for (int i = 0; i < length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        /// <summary>
        /// Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 
        /// (nu se vor folosi vectori suplimentari - 
        /// operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
        /// </summary>
        private static void Problema14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int nrzero = 0;
            for (int i = 0; i < n - nrzero; i++)
                if (v[i] == 0)
                {
                    v[i] = v[n - 1 - nrzero];
                    v[n - 1 - nrzero] = 0;
                    nrzero++;
                }
            Console.WriteLine("Noul vector este:");
            for (int i = 0; i < n ; i++)
                Console.Write(v[i] + " ");

        }

        /// <summary>
        /// Sortare prin insertie. Implementati algoritmul de sortare <InsertionSort>.
        /// </summary>
        private static void Problema13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 1; i < n - 1; i++)
                for (int j = i; j > 0 && v[j - 1] > v[j]; j--)
                {
                    int aux = v[j - 1];
                    v[j - 1] = v[j];
                    v[j] = aux;
                }
            Console.WriteLine("Vectorul sortat prin insertionsort este:");
            for (int i = 0; i < n-1; i++)
                Console.Write(v[i] + " ");
        }

        /// <summary>
        /// Sortare selectie. Implementati algoritmul de sortare <SelectionSort>. 
        /// </summary>
        private static void Problema12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
                for (int j = i; j < n; j++)
                    if (v[j] < v[i])
                    {
                        int aux = v[j];
                        v[j] = v[i];
                        v[i] = aux;
                    }
            Console.WriteLine("Vectorul sortat prin selection sort este: ");
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        /// <summary>
        /// Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
        /// </summary>
        private static void Problema11()
        {
            
        }

        /// <summary>
        /// Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        /// Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
        /// </summary>
        private static void Problema10()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementul cautat:");
            int k = int.Parse(Console.ReadLine());
            int left = 0;
            int right = n - 1;
            int center;
            while (left < right)
            {
                center = (left + right) / 2;
                if (k <= v[center])
                    right = center;
                else
                    left = center + 1;
            }
            if(left == right)
                Console.WriteLine($"Pozitia elementului {k} este {left}");
            else
            {
                Console.WriteLine($"Pozitia elementului {k} este -1");
            }

        }

        /// <summary>
        /// Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
        /// </summary>
        private static void Problema9()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            int x = v[0];
            Console.WriteLine("Introduceti numarul de pozitii");
            int k = int.Parse(Console.ReadLine());

            for (int i = k; i < n; i++)
            {
                v[i - k] = v[i];
            }
            v[n - k] = x;           //Nu merge fiindca trebuie primele k elemente puse intr-un vector de marime k
            Console.WriteLine($"Vectorul rotit cu {k} pozitii la stanga este:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
        /// </summary>
        private static void Problema8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            int x = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i - 1] = v[i];
            }
            v[n - 1] = x;
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        /// <summary>
        /// Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        /// Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
        /// </summary>
        private static void Problema7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for(int i = 0; i < (n/2)-1; i++)
            {
                x[i] = v[n - i];
            }
            Console.WriteLine("Noul vector este:");
            for (int i = 0; i < n ; i++)
                Console.Write(x[i] + " ");


        }

        /// <summary>
        /// Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. 
        /// Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
        /// </summary>
        private static void Problema6()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia k:");
            int k = int.Parse(Console.ReadLine());

            for (int i = k; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            
            Console.WriteLine("Noul vector este:");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(v[i] + " ");
            }
            



        }

        /// <summary>
        /// Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
        /// Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
        /// </summary>
        private static void Problema5()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea e:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti pozitia k:");
            int k = int.Parse(Console.ReadLine());
            int[] x = new int[n+1];
            for (int i = 0; i < n + 1; i++)
            {
                if (i < k)
                    x[i] = v[i];
                else
                    if (i == k)
                    x[i] = e;
                else
                    x[i] = v[i - 1];
            }
            Console.WriteLine("Noul vector este:");
            for (int i = 0; i < n + 1; i++)
                Console.Write(x[i] + " ");



        }

        /// <summary>
        /// Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        /// </summary>
        private static void Problema4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int max = v[0];
            int min = v[0];
            int nrmax = 0, nrmin = 0;

            for (int i = 0; i < n; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                    nrmax = 1;
                }
                else if (v[i] == max)
                    nrmax++;
                if (min > v[i])
                {
                    min = v[i];
                    nrmin = 1;
                }
                else if (v[i] == min)
                    nrmin++;
            }
            Console.WriteLine($"Cea mai mica valoare este {min} si apare de {nrmin} ori , iar cea mai mare valoare este {max} si apare de {nrmax} ori");

        }

        /// <summary>
        /// Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
        /// Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
        /// </summary>
        private static void Problema3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int i;
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            int min = v[0];
            int max = v[0];
            for (i = 1; i < n; i++)
            {
                if (max < v[i])
                    max = i;

                if (min > v[i])
                    min = i;
            }
            Console.WriteLine($"Pozitia pe care se afla cel mai mic element este {min} iar cel mai mare element {max} ");


        }

        /// <summary>
        /// Se da un vector cu n elemente si o valoare k.
        /// Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
        /// </summary>
        private static void Problema2()
        {   

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];            
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea de cautat");
            int k = int.Parse(Console.ReadLine());
            int pozitie = -1;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    pozitie = i;
                    break;
                }
            }
            Console.WriteLine($"Prima pozitie din vector in care apare {k} este pozitia {pozitie}");

        }

        /// <summary>
        /// Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
        /// </summary>
        private static void Problema1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = v[i] + sum;
            }
            Console.WriteLine($"Suma elemntelor vectorului este {sum}");
        }
    }
}
