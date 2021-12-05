using System;
using System.Collections.Generic;

namespace Probleme___setul_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            //P21();
        }

        private static void P21()
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?".
            int x, nr;
            Random rnd = new Random();
            x = rnd.Next(1, 1025);
            Console.WriteLine("Dati un numar cuprins intre 1 si 1024.");
            do
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > x)
                    Console.WriteLine("Numar prea mare. Dati alt numar.");
                if (nr < x)
                    Console.WriteLine("Numar prea mic. Dati alt numar.");
            } while (nr != x);
            Console.WriteLine($"Numarul selectat de calculator este: {x}.");
        }

        private static void P20()
        {
            //Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).
            //O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n sunt mai mari sau egale decat 0.
            //O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
            //O fractie este periodica mixta daca se divide cu 2 si / sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
            int n, m;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);
            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }

        private static void P19()
        {
            //Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
            //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.
            int n, c1, c2 = -10;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            c1 = n % 10;
            while (n != 0)
            {
                if (n % 10 != c1 && c2 == -10)
                {
                    c2 = n % 10;
                }
                else if (n % 10 != c1 && n % 10 != c2)
                {
                    Console.WriteLine("Numarul contine mai mult de 2 cifre distincte.");
                    return;
                }
                n = n / 10;
            }
            Console.WriteLine("Numarul nu contine mai mult de 2 cifre distincte.");
        }

        private static void P18()
        {
            //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int d = 2;  // d va fi, pe rand, fiecare factor prim din descompunere
            int p;      // p va fi puterea lui d in descompunere
            int k = 0;

            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    ++p;
                    n /= d;
                }
                if (k == 0)
                {
                    if (p != 0)
                        Console.Write($"{d} ^ {p}");
                    k++;
                }
                else
                {
                    if (p != 0)
                        Console.Write($" x {d} ^ {p}");
                }
                ++d;
                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
        }

        private static void P17()
        {
            //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.Folositi algoritmul lui Euclid.
            int a, b, r, x, y, ca, cb;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            ca = a;
            cb = b;

            //CMMDC
            if (ca == 0 || cb == 0)
            {
                Console.WriteLine($"Cel mai mare divizor comun este: {ca + cb}");
            }
            else
            {
                r = ca % cb;
                while (r != 0)
                {
                    ca = cb;
                    cb = r;
                    r = ca % cb;
                }
                Console.WriteLine($"Cel mai mare divizor comun este: {cb}");
            }

            //CMMMC
            x = a;
            y = b;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            Console.WriteLine($"Cel mai mic multiplu comun este: {a * b / x}");
        }

        private static void P16()
        {
            //Se dau 5 numere.Sa se afiseze in ordine crescatoare. (nu folositi tablouri)          
            int a, b, c, d, e;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            int minv = int.MaxValue, maxv = int.MinValue;

            if (a < minv)
                minv = a;
            if (b < minv)
                minv = b;
            if (c < minv)
                minv = c;
            if (d < minv)
                minv = d;
            if (e < minv)
                minv = e;

            if (a > maxv)
                maxv = a;
            if (b > maxv)
                maxv = b;
            if (c > maxv)
                maxv = c;
            if (d > maxv)
                maxv = d;
            if (e > maxv)
                maxv = e;

            for (int i = minv; i <= maxv; i++)
            {
                if (i == a || i == b || i == c || i == d || i == e)
                    Console.Write($"{i} ");
            }
        }

        private static void P15()
        {
            //Se dau 3 numere.Sa se afiseze in ordine crescatoare.
            int a, b, c;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if (a <= b && b <= c)
                Console.WriteLine($"{a} {b} {c}");
            else
            if (a <= b && c <= b)
                Console.WriteLine($"{a} {c} {b}");
            else
            if (b <= a && a <= c)
                Console.WriteLine($"{b} {a} {c}");
            else
            if (b <= c && c <= a)
                Console.WriteLine($"{b} {c} {a}");
            else
            if (c <= a && a <= b)
                Console.WriteLine($"{c} {a} {b}");
            else
            if (c <= a && b <= a)
                Console.WriteLine($"{c} {b} {a}");
        }

        private static void P14()
        {
            //Determianti daca un numar n este palindrom.
            //Un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
            int n, cn, og = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            cn = n;
            while (cn != 0)
            {
                og = og * 10 + cn % 10;
                cn = cn / 10;
            }
            if (og == n)
                Console.WriteLine($"Numarul {n} este palindrom.");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom.");
        }

        private static void P13()
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            int y1, y2, aux, k = 0;
            Console.Write("y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            y2 = int.Parse(Console.ReadLine());
            if (y2 < y1)
            {
                aux = y2;
                y2 = y1;
                y1 = aux;
            }
            for (int i = y1 + 1; i < y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    k++;
            }
            if (k == 0)
            {
                Console.WriteLine($"Nu sunt ani bisecti intre {y1} si {y2}.");
            }
            else
            {
                if (k == 1)
                    Console.WriteLine($"Este {k} an bisect intre {y1} si {y2}.");
                else
                    Console.WriteLine($"Sunt {k} ani bisecti intre {y1} si {y2}.");
            }
        }

        private static void P12()
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
            int n, a, b, aux, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            if (b < a)
            {
                aux = a;
                a = b;
                b = aux;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    k++;
            }
            Console.WriteLine($"Sunt {k} numere intregi divizibile cu {n} aflate in intervalul [{a},{b}].");
        }

        private static void P11()
        {
            //Afisati in ordine inversa cifrele unui numar n.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Cifrele numarului {n} in ordine inversa sunt: ");
            while (n != 0)
            {
                Console.Write($"{n % 10} ");
                n = n / 10;
            }
        }

        private static void P10()
        {
            //Test de primalitate: determinati daca un numar n este prim.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            bool ok = true;
            if (n < 2)
                ok = false;
            if (n % 2 == 0 && n != 2)
                ok = false;
            for (int d = 3; d * d <= n; d = d + 2)
                if (n % d == 0)
                    ok = false;
            if (ok)
                Console.WriteLine($"Numarul {n} este prim.");
            else
                Console.WriteLine($"Numarul {n} nu este prim.");
        }

        private static void P9()
        {
            //Afisati toti divizorii numarului n.
            int n, i;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii lui {n} sunt: ");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void P8()
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }

        private static void P7()
        {
            //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
            int a, b, aux;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }

        private static void P6()
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
            int a, b, c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Cele trei numere nu pot reprezenta lungimile laturilor unui triunghi.");
            else
                Console.WriteLine("Cele trei numere pot reprezenta lungimile laturilor unui triunghi.");
        }

        private static void P5()
        {
            //Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
            int n, k, ck, cn, cifra = 0, nrcif = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            cn = n;
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            ck = k;
            while (cn != 0)
            {
                nrcif++;
                cn = cn / 10;
            }
            if (k > nrcif)
            {
                Console.WriteLine($"Numarul {n} nu contine {k} cifre.");
                return;
            }
            cn = n;
            if (k == 1)
            {
                Console.WriteLine($"Prima cifra de la sfarsitul numarului {n} este {n % 10}.");
                return;
            }
            else
            {
                while (ck != 0)
                {
                    cifra = cn % 10;
                    cn = cn / 10;
                    ck--;
                }
                Console.WriteLine($"A {k} cifra de la sfarsitul numarului {n} este {cifra}.");
            }
        }

        private static void P4()
        {
            //Detreminati daca un an y este an bisect.
            int y;
            Console.Write("y=");
            y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                Console.WriteLine($"Anul {y} este an bisect.");
            else
                Console.WriteLine($"Anul {y} nu este an bisect.");
        }

        private static void P3()
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare.
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine($"{n} se divide cu {k}");
            else
                Console.WriteLine($"{n} nu se divide cu {k}");
        }

        private static void P2()
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare.
            //Tratati toate cazurile posibile.
            double a, b, c, x1, x2, d;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0)
                Console.WriteLine("Ecuatia nu are solutii reale.");
            else
            {
                if (d == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"Solutia ecuatiei este {x1}.");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / 2 * a;
                    x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"Solutiile ecuatiei sunt {x1} si {x2}.");
                }
            }
        }

        private static void P1()
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
            float a, b, x;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            x = (-b / a);
            Console.WriteLine($"x este egal cu {x}");
        }
    }
}
