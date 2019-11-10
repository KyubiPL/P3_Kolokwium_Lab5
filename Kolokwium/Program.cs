using System;


namespace Kolokwium
{
    class Program
    {
        static public float trapez(int a, int b, int h)
        {
            float pole = ((a + b) / 2)*h;
            Console.WriteLine("Pole wynosi: {0}",pole);
            return pole;
        }

        static public void koniec(string tak)
        {
           string[] tablica;
           int dlugosc = tak.Length;

           for (int i = 0; i < dlugosc; i++)
           {
                
           }

        }
        
      /*  static public void szarpana(ref int [,]tab)
        {
            int[] tab1;
            int[] tab2;
            int[] tab3;
            int[] tab4;
            int[] tab5;
            int[][] tac = {  tab1 , tab2, tab3, tab4, tab5 };

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        tac[i][j] = tab[i, j];
                    }                 
                }
                for (int i = 0; i < tac.Length; i++)
                {
                    for (int j = 0; j < tac[].Length; j++)
                    {

                    }
                }
                
            }
    }*/

    static void Main(string[] args)
        {

            Console.WriteLine("Podaj a");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj h");
            int z = Convert.ToInt32(Console.ReadLine());

            trapez(x, y, z);
            
            
            string cos = Console.ReadLine();

            int[,] tabl =
              {
                {1,2,3,0,0},
                {3,2,1,0,0 },
                {2,0,0,0,0 },
                {3,4,0,0,0 },
                {1,2,3,4,0 },
            };

            //szarpana(ref tabl); 
           

        }
    }
}
//grupa C
// napisz funkcje ktora oblicza pole trapezu
//wypisz podany tekst od tylu
//tworzysz aplikacje ktora ma dzoa;ac w suste,oe p lrutuczmoe mosloek o;psco [a,oeco ra,/ a[;olacka ptrzu,ike dame w [pstaco dwi,uwoarpwek tab;ocu prostokatnej mimo ze wiekszosc rzedow jest zakonczona szregiem bezuzytecznych 
// wartosci (zer) aby zaoszczedzic pamiec napisz funkcje ktora przetworzy tablice prostokatna na tablice poszarpana
