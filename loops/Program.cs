using System;

namespace loops
{
    class Program
    {
        //Litera X

        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");


            if (n % 2 == 0)
            {
                //górna połówka idzie tyle razy co pół n bez środka
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < n - 2 - 2 * i; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //dolna połówka, symetrycznie do górnej
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < n / 2 - i - 1; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < 2 * i; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

            }

            else
            {
                //górna połówka idzie tyle razy co pół n bez środka
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < n - 2 - 2 * i; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //pojedyncza gwiazdka w środku
                for (int i = 0; i < n / 2; i++)
                {
                    Space();
                }
                StarLn();
                //dolna połówka, symetrycznie do górnej
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < n / 2 - i - 1; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }
            }
        }

        //Z lustrzane
        static void LiteraZreverse(int n)
        {

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            //górna część
            for (int j = 0; j < n - 1; j++)
            {
                Star();
            }
            StarLn();

            //Środek
            for (int i = 0; i < n - 2; i++) 
            {

                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                StarLn();

            }

            //dolna część symetrycznie
            for (int j = 0; j < n - 1; j++)
            {
                Star();
            }
            StarLn();

        }

        //Z zwykłe
        static void LiteraZ(int n)
        {

            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            //górna część
            for (int j = 0; j < n - 1; j++)
            {
                Star();
            }
            StarLn();

            //środek
            for (int i = 0; i < n - 2; i++)
            {

                for (int j = 0; j < n - (i+2); j++)
                {
                    Space();
                }
                StarLn();

            }

            //dolna część symetrycznie
            for (int j = 0; j < n - 1; j++)
            {
                Star();
            }
            StarLn();

            }

        //Klepsydra
        static void Klepsydra(int n)
        {

            if (n < 5) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 0)
            {
                //górna część
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                StarLn();

                //środek góra

                for (int i = 0; i < (n - 2) / 2; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < n - 2 - ((i + 1) * 2); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //środek dół

                for (int i = 0; i < (n - 2) / 2; i++)
                {
                    for (int j = 0; j < (n - 2) / 2 - i; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < i * 2; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //dolna część symetrycznie
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                StarLn();
            }

            else 
            {
                //górna część
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                StarLn();

                //środek 

                //środek góra

                for (int i = 0; i < (n - 2) / 2; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < n - 2 - ((i + 1) * 2); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //środek gwiazdka pojedyncza w połowie

                for (int i = 0; i < (n / 2); i++)
                {
                    Space();
                }
                StarLn();


                //środek dół

                for (int i = 0; i < (n - 2) / 2; i++)
                {
                    for (int j = 0; j < (n - 2) / 2 - i; j++)
                    {
                        Space();
                    }
                    Star();

                    for (int j = 0; j < (i*2) + 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }
               
                //dolna część symetrycznie
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                StarLn();
            
        }
            

        }

        //pusty trójkąt
        static void Trójkąt(int n)
        {

            if (n < 5) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 0)
            {
                n = n - 1;
            }

            //ramiona
            // wierzchołek
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //ramiona

            for (int i = 0; i < (n / 2) - 1; i++)
            {
                for (int j = 0; j < (n / 2) - i - 1; j++)
                {
                    Space();
                }
                Star();

                for (int j = 0; j < (i*2) + 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podstawa

            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }
        static void Main(string[] args)
        {
            LiteraX(8);
            Console.WriteLine("------------");
            LiteraZreverse(8);
            Console.WriteLine("------------");
            LiteraZ(8);
            Console.WriteLine("------------");
            Klepsydra(8);
            Console.WriteLine("------------");
            Klepsydra(7);
            Console.WriteLine("------------");
            LiteraX(7);
            Console.WriteLine("------------");
            Trójkąt(8);
        }
    }
}