
global using global::System;
namespace ZSK_Währungsrechner
{
    internal class Program
    {
        static void EuroInZSK(int euro)
        {

            int rest = euro;
            int K = rest / 2800;
            rest %= 2800;
            int S = rest / 650;
            rest %= 650;
            int Z = rest / 500;
            rest %= 500;
            int z = rest / 50;
            rest %= 50;
            Console.WriteLine($"{euro} Euro sind in ZSK: {K} Kuh, {S} Schaff, {Z} Ziege, {z} kleine Ziege und {rest}€.");
        }
        static int ZSKInEuro(int K, int S, int Z, int z)
        {

            int euro = (K * 2800) + (S * 650) + (Z * 500) + (z * 50);
            Console.WriteLine($"{K} Kuh, {S} Schaf, {Z} Ziege und {z} kleine Ziege sind {euro} Euro.");
            return euro;
        }
        static void EuroInDAHRS(double euro)
        {
            int d = 8 * 1000;
            int a = (d / 11);
            int h = (a / 5);
            int r = (9 * h + 7 * a);
            int s = (h / 11);
            double rest = euro * 1000;
            int D = ((int)(rest / d));
            rest = rest % d;
            Console.WriteLine(rest);
            int R = ((int)(rest / r));
            rest = rest % r;
            Console.WriteLine(rest);
            int A = ((int)(rest / a));
            rest = rest % a;
            Console.WriteLine(rest);
            int H = ((int)(rest / h));
            rest = rest % h;
            Console.WriteLine(rest);
            int S = ((int)(rest / s));
            rest = (rest % s) / 1000;
            Console.WriteLine($"{euro} Euro sind in DAHRS: {D} Dorsch, {R} Rochen, {A} Aal, {H} Hering, {S} Sprotte und Rest {rest} Euro");
        }
        static double DAHRSInEuro(int D, int R, int A, int H, int S)
        {
            double d = 8;
            double a = d / 11;
            double h = a / 5;
            double r = 9 * h + 7 * a;
            double s = h / 11;
            double euro = (D * d) + (R * r) + (A * a) + (H * h) + (S * s);
            Console.WriteLine($"{D} Dorsch, {R} Rochen, {A} Aal, {H} Hering und {S} Sprotte sind {euro} Euro.");
            return euro;
        }
        static void Main(string[] args)
        {
            bool weiter = true;
            while (weiter)
            {
                Console.WriteLine("Was wollen sie Rechnen:\n1) Euro in ZSK\n2) ZSK in Euro\n3) Euro in DAHRS\n4) DAHRS in Euro\n5)ZSK in DAHRS\n6)DAHRS in ZSK\n7)Beenden");
                string antwort = Console.ReadLine();
                if (antwort != null && antwort.Length == 1)
                {
                    switch (antwort)
                    {
                        case "1":

                            Console.Write("Wieviel Euro wollen Sie umrechenen? :");
                            int euroi = Convert.ToInt32(Console.ReadLine());
                            EuroInZSK(euroi);
                            break;
                        case "2":
                            Console.Write("Wieviel Kuh sollen umgerechnet werden? :");
                            int K = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Schaf sollen umgerechnet werden? :");
                            int S = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Ziege sollen umgerechnet werden? :");
                            int Z = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel kleine Ziege sollen umgerechnet werden? :");
                            int z = Convert.ToInt32(Console.ReadLine());
                            ZSKInEuro(K, S, Z, z);
                            break;
                        case "3":
                            Console.Write("Wieviel Euro wollen Sie in fisch investieren? :");
                            double eurod = Convert.ToDouble(Console.ReadLine());
                            EuroInDAHRS(eurod);
                            break;
                        case "4":
                            Console.Write("Wieviel Dorsch sollen umgerechnet werden? :");
                            int D = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Rochen sollen umgerechnet werden? :");
                            int R = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Aal sollen umgerechnet werden? :");
                            int A = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Hering sollen umgerechnet werden? :");
                            int H = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Sprotte sollen umgerechnet werden? :");
                            S = Convert.ToInt32(Console.ReadLine());
                            DAHRSInEuro(D, R, A, H, S);
                            break;
                        case "5":
                            Console.Write("Wieviel Kuh sollen umgerechnet werden? :");
                            K = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Schaf sollen umgerechnet werden? :");
                            S = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Ziege sollen umgerechnet werden? :");
                            Z = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel kleine Ziege sollen umgerechnet werden? :");
                            z = Convert.ToInt32(Console.ReadLine());
                            EuroInDAHRS(Convert.ToDouble(ZSKInEuro(K, S, Z, z)));
                            break;
                        case "6":
                            Console.Write("Wieviel Dorsch sollen umgerechnet werden? :");
                            D = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Rochen sollen umgerechnet werden? :");
                            R = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Aal sollen umgerechnet werden? :");
                            A = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Hering sollen umgerechnet werden? :");
                            H = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Wieviel Sprotte sollen umgerechnet werden? :");
                            S = Convert.ToInt32(Console.ReadLine());
                            EuroInZSK(Convert.ToInt32(DAHRSInEuro(D, R, A, H, S)));
                            break;
                        case "7":
                            weiter = false;
                            break;
                        default:
                            Console.WriteLine("Eingabe falsch!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Eingabe falsch!");
                }
            }
        }
    }
}