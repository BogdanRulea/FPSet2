using System.Runtime.InteropServices;

namespace FPSet1
{
    internal class Program
    {
        private static string pb17()
        {

            int n;
            int x;
            int cont0 = 0, cont1 = 0;
            bool ok = true;
            int incuibareMax = int.MinValue;
            int contSecv = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    cont0++;
                    contSecv++;
                }
                else
                {
                    cont1++;
                    if(contSecv > incuibareMax)
                    {
                        incuibareMax = contSecv;
                    }
                    contSecv = 0;
                }

                if(cont1 > cont0)
                {
                    ok = false;
                }
            }

            if(ok==false || cont0 != cont1)
            {
                return "Secventa nu este o secventa de paranteze corecte";
            }

            return String.Concat("Secventa este corecta iar nivelul maxim de incuibare este: ", incuibareMax);
            throw new NotImplementedException();
        }

        private static string pb16()
        {
            int n;
            int x;
            int ok = 0;
            int noSecvente = 1;
            int ult = 0;
            int primul = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult <= x && (ok == 0 || ok == 1)) // verificam daca secventa este crescatoare
                {
                    ok = 1; // secventa crescatoare
                }
                else if (i > 0 && ult >= x && (ok == -1 || ok == 0)) // verificam daca secventa este descrescatoare
                {
                    ok = -1;
                }
                else if (i > 0)
                {
                    noSecvente++;
                    ok = -ok;
                }
                if (i == 0)
                {
                    primul = x;
                }
                ult = x;
            }

            if (noSecvente > 3 || (noSecvente == 3 && ((ok == -1 && primul>ult) || (ok == 1 && primul < ult))))
            {
                return "Secventa nu este o secventa bitonica rotita";
            }
            return "Secventa este o secventa bitonica rotita";
        }

        private static string pb15()
        {
            int n;
            int x;
            int ok = 0;
            int noSecvente = 1;
            int ult = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult <= x && (ok == 0 || ok == 1)) // verificam daca secventa este crescatoare
                {
                    ok = 1; // secventa crescatoare
                }
                else if (i > 0 && ult >= x && (ok == -1 || ok == 0)) // verificam daca secventa este descrescatoare
                {
                    ok = -1;
                }
                else if (i > 0)
                {
                    noSecvente++;
                    ok = -ok;
                }

                ult = x;
            }

            if(noSecvente > 2 || ok == 1)
            {
                return "Secventa nu este o secventa bitonica";
            }
            return "Secventa este o secventa bitonica";
        }

        private static string pb14()
        {
            int n;
            int x;
            int ok = 0; // presupunem ca numerele nu sunt monotone
            int ult = 0;
            int noSecvente = 1;
            int primulNumar = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult <= x && (ok == 0 || ok == 1)) // verificam daca secventa este crescatoare
                {
                    ok = 1; // secventa crescatoare
                }
                else if (i > 0 && ult >= x && (ok == -1 || ok == 0)) // verificam daca secventa este descrescatoare
                {
                    ok = -1;
                }
                else if (i>0)
                {
                    noSecvente++;
                }

                if(i == 0)
                {
                    primulNumar = x;
                }
                ult = x;
            }
            if (noSecvente>2 || (ok==1 && primulNumar < ult) || (ok==-1 && primulNumar > ult))
            {
                return "Secventa nu este monotona rotita";
            }
            return "Secventa este monotona rotita";
        }


        private static string pb13()
        {
            int n;
            int x;
            int ult = 0;
            int noSecvente = 1;
            int primulElement = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                // 6 7 8 1 2 3 7
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult >= x)
                {
                    noSecvente++;
                }
                if(i == 0)
                {
                    primulElement = x;
                }
                ult = x;
            }

            if(noSecvente > 2 || (primulElement<ult && noSecvente>1))
            {
                return "Secventa data nu este o secventa crescatoare rotita";
            }

            return "Secventa data este o secventa crescatoare rotita";
        }

        private static int pb12()
        {
            int n;
            int x;
            int ult = 0;
            int noGrupuriNumere = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());

                if (i > 0 && x == 0 && ult != 0)
                {
                    noGrupuriNumere++;

                }

                ult = x;
            }

            return noGrupuriNumere;
        }

        private static int invers(int a){
            int og = 0;
            while(a != 0)
            {
                og = og * 10 + a % 10;
                a /= 10; 
            }

            return og;
        }
        private static int pb11()
        {
            int n;
            int x;
            int s = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                s += invers(x);
            }

            return s;
        }

        private static int pb10()
        {

            int n;
            int x;
            int ult = 0;
            int noNumereConsEgale = 1;
            int max = int.MinValue;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());

                if(i>0 && ult == x)
                {
                    noNumereConsEgale++;
                    if(i == n - 1)
                    {
                        if (max < noNumereConsEgale)
                        {
                            max = noNumereConsEgale;
                        }
                    }

                } else if(i > 0)
                {
                    if(max < noNumereConsEgale)
                    {
                        max = noNumereConsEgale;   
                    }
                    noNumereConsEgale = 1;
                }

                ult = x;
            }
           
            return max;
        }

        private static string pb9()
        {
            int n;
            int x;
            int ok = 0; // presupunem ca numerele nu sunt monotone
            int ult = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult >= x && (ok == 0 || ok == 1)) // verificam daca secventa este crescatoare
                {
                    ok = 1; // secventa crescatoare
                }
                else if (i > 0 && ult <= x && (ok == -1 || ok == 0)) // verificam daca secventa este descrescatoare
                {
                    ok = -1;
                }
                else if(i > 0)
                {
                    ok = 2;
                }

                ult = x;
            }
            if(ok == 2)
            {
                return "Secventa nu este monotona";
            }
            return "Secventa este monotona";
        }

        private static int pb8()
        {
            int n;
            Console.WriteLine("Scrie numarul n: ");
            n = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 1;
            int k = 1;
            if (n == 0)
                return i;
            if (n == 1)
                return j;

            while (k < n)
            {
                j = i + j;
                i = j - i;
                k++;
            }

            return j;
        }

        private static string pb7()
        {
            int n;
            int x;
            int max = int.MinValue;
            int min = int.MaxValue;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if(x < min)
                {
                    min = x;
                }
                if(x > max)
                {
                    max = x;
                }
            }

            return String.Concat("Minim: ", min, "; Maxim: ", max);
        }

        private static string pb6()
        {
            int n;
            int x;
            bool ok = true; // presupunem ca numerele sunt in ordine crescatoare
            int ult = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (i > 0 && ult >= x)
                {
                    ok = false;
                }

                ult = x;
            }
            if (!ok)
            {
                return "Nu";
            }
            return "Da";
        }

        private static int pb5()
        {
            int n;
            int x;
            int noNumereEgaleCuPoz = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (x == i)
                {
                    noNumereEgaleCuPoz++;
                }
            }

            return noNumereEgaleCuPoz;
        }

        private static int pb4()
        {
            int n, a, x;
            int noNumerePare = 0;
            Console.WriteLine("Scrie numarul a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());
            int poz = -1;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if(x == a)
                {
                    poz = i;
                }
            }

            return poz;

        }

        private static string pb3()
        {
            int n;
            Console.WriteLine("Scrie numarul n: ");
            n = int.Parse(Console.ReadLine());
            int p = 1;
            int s = 0;

            for(int i = 1; i<=n; i++)
            {
                p *= i;
                s += i;
            }

            return String.Concat("Suma: ", s, "; Produsul: ", p);
        }

        private static string pb2()
        {
            int n;
            int x;
            int noNumereNeg = 0;
            int noNumerePoz = 0;
            int noNumereNule = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    noNumereNeg++;
                } else if (x > 0)
                {
                    noNumerePoz++;
                }
                else
                {
                    noNumereNule++;
                }
            }

            return String.Concat("Negative: ", noNumereNeg, "; Pozitive: ", noNumerePoz, "; Egale cu 0: ", noNumereNule);
        }

        private static int pb1()
        {
            int n;
            int x;
            int noNumerePare = 0;
            Console.WriteLine("Scrie numarul de numere: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Scrie numarul {0} din secventa", i);
                x = int.Parse(Console.ReadLine());
                if(x % 2 == 0)
                {
                    noNumerePare++;
                }
            }

            return noNumerePare;
        }
        private static void menu()
        {
            Console.WriteLine("1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.WriteLine("2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n. ");
            Console.WriteLine("4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. " +
                "\nSe considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.");
            Console.WriteLine("5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");
            Console.WriteLine("6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
            Console.WriteLine("7.Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            Console.WriteLine("8.Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");
            Console.WriteLine("10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");
            Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. " +
                "\nConsiderati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            Console.WriteLine("13.O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa " +
                "\nin ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). " +
                "\nDeterminati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. " +
                "\nDeterminati daca o secventa de n numere este o secventa monotona rotita.");
            Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. " +
                "\nDe ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.");
            Console.WriteLine("16.O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). " +
                "\nSe da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. " +
                "\nDeterminati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. " +
                "\nDe exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");
            Console.WriteLine("x. Inchide programul");
        }
        private static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                string choice = "";
                menu();
                Console.WriteLine("\n");
                Console.WriteLine("Scrie numarul optiunii:");
                choice = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Raspuns: {0}", pb1());
                        break;
                    case "2":
                        Console.WriteLine("Raspuns: {0}", pb2());
                        break;
                    case "3":
                        Console.WriteLine("Raspuns: {0}", pb3());
                        break;
                    case "4":
                        Console.WriteLine("Raspuns: {0}", pb4());
                        break;
                    case "5":
                        Console.WriteLine("Raspuns: {0}", pb5());
                        break;
                    case "6":
                        Console.WriteLine("Raspuns: {0}", pb6());
                        break;
                    case "7":
                        Console.WriteLine("Raspuns: {0}", pb7());
                        break;
                    case "8":
                        Console.WriteLine("Raspuns: {0}", pb8());
                        break;
                    case "9":
                        Console.WriteLine("Raspuns: {0}", pb9());
                        break;
                    case "10":
                        Console.WriteLine("Raspuns: {0}", pb10());
                        break;
                    case "11":
                        Console.WriteLine("Raspuns: {0}", pb11());
                        break;
                    case "12":
                        Console.WriteLine("Raspuns: {0}", pb12());
                        break;
                    case "13":
                        Console.WriteLine("Raspuns: {0}", pb13());
                        break;
                    case "14":
                        Console.WriteLine("Raspuns: {0}", pb14());
                        break;
                    case "15":
                        Console.WriteLine("Raspuns: {0}", pb15());
                        break;
                    case "16":
                        Console.WriteLine("Raspuns: {0}", pb16());
                        break;
                    case "17":
                        Console.WriteLine("Raspuns: {0}", pb17());
                        break;
                    case "x":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Comanda inexistenta reincercati!");
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
