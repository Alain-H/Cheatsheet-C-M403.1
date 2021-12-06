using System;
using System.Linq;

namespace CheatSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In C#, there are different types of variables (defined with different keywords), for example:

            int - stores integers (whole numbers), without decimals, such as 123 or -123
            double - stores floating point numbers, with decimals, such as 19.99 or -19.99
            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            string - stores text, such as "Hello World". String values are surrounded by double quotes
            bool - stores values with two states: true or false

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
            
            Schreibarten von einer Ausgabe in der Konsole:

            int x = 0;

            Console.WriteLine($"{x}");
            Console.WriteLine(""+x);
            Console.WriteLine("{0}",x);
            
            //__________________________________________________________________________________________________________________________

            Math:
            Math.Pow(x.y);    = Power of x; x mit Potenz y; z.b x=5, y=2 = 25
            Math.Abs(x);      = Die Absolute Funktion nimmt einen Wert an und gibt ihn in Positiv zurück.
            Math.Sign(x);     = Signum Funktion nimmt einnen Wert an und gibt entweder -1, 0 oder 1 zurück. Wenn der Wert (x) negativ
                                ist, bekommt man als Rückgabewert -1 zurück. Wenn der Wert positiv ist, bekommt man eine 1.
                                bei einem Wert von 0 ist auch der Rückgabewert 0.
            Math.sqrt(x)      = Die "Squerroot" Funktion gibt einem die Quadratwurzel einer eingegebener Zahl zurück.
            Math.Round(x,y)   = Diese Methode benutzt man zum Runden auf eine gegeben Nachkommastelle.
                                Der erste Parameter ist die Zahl und der zweiter Parameter ist die gewünschte Nachkommastelle.
            Math.Ceiling(x);  = Die " Dacj" Funktion rundet eine gebene Zahl auf die letzte Ganzzahl ab.
            Math.Floor(x)     = Die "Boden" Funktin rundet eine gebene Zahl aud die letzte Ganzzahl ab.
            */

                         //<--------Hier löschen um die Aufgaben in Farbe zu sehen!!!
            while (true)
            {   
                //_______________________________________________________________________________________________________________________
                // Try Catch!!
                try
                    //___________________________________________________________________________________________________________________
                {   // bsp für if
                    Console.Write("j/J für weiter n/N für Abbruch!: ");
                    string ant = Console.ReadLine();
                    if (ant == "n" || ant == "N")
                    {
                        Console.WriteLine("Abbruch!!");
                        break;
                    }
                    if (ant == "j" || ant == "J")
                    {
                        Console.Write("Geben Sie die 1. Zahl ein: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Geben Sie die 2. Zahl ein: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Wählen Sie:");
                        Console.WriteLine("Addition______________________(1)");
                        Console.WriteLine("Subtraktion___________________(2)");
                        Console.WriteLine("Multiplikation________________(3)");
                        Console.WriteLine("Division______________________(4)");
                        Console.Write("Modulo__________________________(5): ");

                        int ausw = Convert.ToInt32(Console.ReadLine());
                        //______________________________________________________________________________________________________________
                        // bsp für switch cases
                        switch (ausw)
                        {
                            case 1:
                                Console.WriteLine($"Zahl a: {a} + Zahl b: {b} = {a + b}");
                                break;
                            case 2:
                                Console.WriteLine($"Zahl a: {a} - Zahl b: {b} = {a - b} ");
                                break;
                            case 3:
                                Console.WriteLine($"Zahl a: {a} * Zahl b: {b} = {a * b}");
                                break;
                            case 4:
                                Console.WriteLine($"Zahl a: {a} / Zahl b: {b} = {a / b}");
                                break;
                            case 5:
                                Console.WriteLine($"Zahl a: {a} % Zahl b: {b} = {a % b}");
                                break;
                            default:
                                break;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //____________________________________________________________________________________________________________________________
            // bsp für While (true)
            while (true)
            {
                try
                {
                    Console.Write("j/J für weiter n/N für Abbruch!: ");
                    string ant = Console.ReadLine();
                    if (ant == "n" || ant == "N")
                    {
                        Console.WriteLine("Abbruch!!");
                        break; // hier ist der break für die While(true) Schleife falls N/n betätigt wird!!
                    }
                    if (ant == "j" || ant == "J")
                    {
                      //Dann den auszuführenden Code hineinschreiben!!! wie oben!!
                    }

                    Console.ReadKey();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //______________________________________________________________________________________________________________________________
            // bsp für For Schleife:

            int x = 15;
            for(int i=2;i<=x;i+=2)
            {
                if (i<x)
                {

                    Console.WriteLine(""+i);
                }
                
            }
            
            //_______________________________________________________________________________________________________________________________
            // While SChleife

            int x = 0;

            Console.WriteLine("Anfang!!");// Gehört nicht dazu, ist nur Kontrolle!!
            while (x<=10)
            {
                Console.WriteLine(+x+"");

                x++;
            }
            Console.WriteLine("Ende!!!");// Gehört nicht dazu, ist nur Kontrolle!!

            //_______________________________________________________________________________________________________________________________
            //Bsp : Do-While 
            int i = 0;

            do
            {
                Console.WriteLine("i={0}", i);
                i++;
            } while (i <= 5);

            //______________________________________________________________________________________________________________________________
            //Arrays : mit for Schleife ausgeschrieben.

            string[] products = new string[4];

            products[0] = "Nutella";
            products[1] = "Kracker";
            products[2] = "Brot";
            products[3] = "Spaghetti";

            for (int i = 0; i< products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
            
            //______________________________________________________________________________________________________________________________
            // Arrays mit foreach Schleife ausgeschrieben.

            string[] product = new string[4];

            product[0] = "Nutella";
            product[1] = "Kracker";
            product[2] = "Banana";
            product[3] = "Sesam";

            foreach (string i in product) //string kann auch mit var ersetzt werden, var übernimmt die Speicherart automatisch
            {                            // der var i nimmt in jedem Schleifendurchlauf, den Wert des Arrayinhalts und gibt ihn mit dem cw heraus. 
                Console.WriteLine(i);   
            }
           
            //________________________________________________________________________________________________________________________________
            //Array : ausgeschriben mit Linq!! (nicht prüfungserlaubt!!)

            int[] mynumbers = { 5, 6, 7, 8 };


            Console.WriteLine(mynumbers.Max());  
            Console.WriteLine(mynumbers.Min());
            Console.WriteLine(mynumbers.Sum());

            //________________________________________________________________________________________________________________________________
            //2d Arrays
            
            string[,] products = new string[2, 3];
            products[0, 0] = "Senf";
            products[1, 0] = "Lebensmittel";

            products[0, 1] = "Smartphone";
            products[1, 1] = "Elektronik";

            products[0, 2] = "Schokolade";
            products[1, 2] = "Lebnsmittel";

            Console.WriteLine(products[0, 0] + "\t\t" +products[1, 0]);
            Console.WriteLine(products[0, 1]+ "\t" + products[1, 1]);
            Console.WriteLine(products[0, 2] + "\t" + products[1, 2]);

           //________________________________________________________________________________________________________________________________
           //Kombinierte Aufgabe!! (String Komas und Leerzeichen auslesen und Datum/DayTime)
            while (true)
            {
                try
                {   
                    
                    Console.WriteLine("Bitte geben Sie an, ob sie mit j/J weiter oder mit n/N abbrechen möchteN?");
                    string ent = Console.ReadLine();
                    if(ent == "n" || ent == "N")
                    {
                        Console.WriteLine("Abbruch!!");
                        break;
                    }
                    if(ent== "j" || ent == "J")
                    {
                    
                        Console.WriteLine("Wählen Sie die Option, welche sie haben möchten:");
                        Console.WriteLine("Kommas und Lerzeichen auszählen____________________(1)");
                        Console.WriteLine("Datum und Tag Rausgeben______________________________(2):");

                        int wahl = Convert.ToInt32(Console.ReadLine());
                        
                        switch (wahl)
                        {
                            case 1:
                                Console.WriteLine("Geben Sie bitte einen String ein.: ");
                                string eing = Console.ReadLine();
                                int countl = 0, countk = 0;
                                for(int k =0;k<=eing.Length-1;k++)
                                {
                                    if(eing [k]==' ')//Leerzeichen
                                    {
                                        countl++;
                                    }
                                    if(eing [k]== ',')//Komma
                                    {
                                        countk++;
                                    }
                                    
                                }

                                Console.WriteLine($"Sie haben {countl} Leerzeichen und {countk} Kommas in Ihrem String!!");
                                break;
                            case 2:
                                DateTime t = DateTime.Now;
                                Console.WriteLine($"\n Datum und Tag von Heute: {t.ToLongDateString()}");
                                break;
                            default:
                                Console.WriteLine("Falsche Eingabe!!!");
                                break;
                        }


                    
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //________________________________________________________________________________________________________________________________
            
            // 10 Zahlen eingeben zwischen 20-50. Davon den Max, Min und den Durchschnitt berechnen.
            
            double max = 0, min = 0, d = 0;
            int count = 1;
            for(int i = 0; i<=9;i++)
            {
                try
                {
                    Console.Write($"Geben Sie die {count++} Zahl ein welche zwischen 20 und 50 liegt ein: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    if(x>=20 && x<=50)
                        if(i==1)
                        {
                        max = x;
                        min = x;
                        }
                        if(x > max)
                        {
                        max = x;
                        }
                        if(x<min)
                        {
                        min = x;
                        }
                        d += x;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Max= {max}, Min = {min} Durchschnitt = {d/10}");
            

            //________________________________________________________________________________________________________________________________
            // Alle gerade Zahl und ungeraden Zahlen auslesen.
            
            for(int k = 0; k<=10;k++)
            {
                
                if (k%2==0)
                {
                    Console.WriteLine("{0}",k);
                    
                }
            }
            


            */
            Console.ReadKey();
        }

    }

}


                
               
