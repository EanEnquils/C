using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1

            Console.WriteLine("Zadanie 1: ");

            double a, b, C;

            Console.WriteLine("Podaj długość boku prostokąta a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość boku prostokąta b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokąta: ");
            C = a * b;

            Console.WriteLine(C);
            Console.ReadKey();

            //Zadanie 2

            Console.WriteLine("Zadanie 2: ");

            double PI = Math.PI;
            Console.WriteLine("Wartość liczby PI do 6 miejsc po przecinku: {0:F6}", PI);
            Console.ReadKey();

            //Zadanie 3

            Console.WriteLine("Zadanie 3: ");

            double d, e, f, p, S;

            Console.WriteLine("Podaj długość boku trójkąta d: ");
            d = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość boku trójkąta e: ");
            e = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość boku trójkąta f: ");
            f = double.Parse(Console.ReadLine());

           

            if ((d + e) > f & (e + f) > d & (d + f) > b)
            {
                Console.WriteLine("Trójkąt istnieje");
            }

            else

            {
                Console.WriteLine("Trójkąt nie istnieje");
            }

            p = (d + e + f) / 2;

           
            Console.WriteLine("Pole trójkąta: ");
            S = Math.Sqrt(p * (p - d) * (p - e) * (p - f));

            Console.WriteLine(S);
            Console.ReadKey();


            //Zadanie 4 

            Console.WriteLine("Zadanie 4: ");

            double V, r;
           
            Console.WriteLine("Podaj wartość promienia kuli: ");
            r = double.Parse(Console.ReadLine());
            V = (4 * Math.PI * Math.Pow(r, 3)) / 3;

            Console.WriteLine("Objętość kuli: ");
            Console.WriteLine(V);
            Console.ReadKey();


            //Zadanie 5 

            Console.WriteLine("Zadanie 5: ");

            double g, z, t;
            
            Console.WriteLine("Podaj licznik: ");
            g = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj mianownik: ");
            z = double.Parse(Console.ReadLine());
            t = g / z;

            Console.WriteLine("Reszta z dzielenia: ");

            Console.WriteLine(g / z);
            Console.ReadKey();

            //Zadanie 6 

            Console.WriteLine("Zadanie 6: ");

            double Pi = Math.PI, X;
            
            Console.WriteLine("Wartość liczby PI do 5 miejsc po przecinku: {0:F5}", PI);

            X = Math.Sqrt(Math.PI);

            Console.WriteLine("Pierwiastek kwadratowy z liczby pi z dokładnością do dwóch miejsc po przecinku:{0:F2}", X);
            Console.ReadKey();

            //Zadanie 7 

            Console.WriteLine("Zadanie 7: ");

            double x, y, Suma, Różnica, Iloczyn, Iloraz;
            
            Console.WriteLine("Podaj pierwszą liczbę x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę y: ");
            y = double.Parse(Console.ReadLine());
            Suma = x + y;
            Różnica = x - y;
            Iloczyn = x * y;
            Iloraz = x / y;
            Console.WriteLine("Suma: {0:F3}", Suma);
            Console.WriteLine("Różnica: {0:F3}", Różnica);
            Console.WriteLine("Iloczyn: {0:F3}", Iloczyn);
            Console.WriteLine("Iloraz: {0:F3}", Iloraz);
            Console.ReadKey();

            //Zadanie 8 

            Console.WriteLine("Zadanie 8: ");

            double R, L;
            
            Console.WriteLine("Podaj kąt wyrażony w stopniach: ");
            L = double.Parse(Console.ReadLine());
            R = (Math.PI * L) / 180.0;
            Console.WriteLine("Kąt wyrażony w radianach: ");
            Console.WriteLine(R);
            Console.ReadKey();


            //Zadanie 9 

            Console.WriteLine("Zadanie 9: ");

            double h, k, J;
            
            Console.WriteLine("Podaj wysokość stożka: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj radius stożka: ");
            k = double.Parse(Console.ReadLine());




            J = (Math.PI * k * k * h) / 3;
            Console.WriteLine("Objętość stożka: ");
            Console.WriteLine(J);
            Console.ReadKey();

            //Zadanie 10 

            Console.WriteLine("Zadanie 10: ");

            double n, l, P;
           
            Console.WriteLine("Podaj ilość boków wielokąta foremnego: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku: ");
            l = double.Parse(Console.ReadLine());
            P = ((n * l * l) / 4) * (1 / Math.Tan(Math.PI / n));
            Console.WriteLine("Pole powierzchni n-kąta foremnego: ");
            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
