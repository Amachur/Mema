//Vaughn Uriel Balane
using System;
 class Program
{
    static void Main()
    {
        int num;

        Console.Write("IBIGAY MO YUNG MULTIPLICATION TABLE NUMBER MO!!! ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num <= 0)
        {
            Console.WriteLine("Ekh! MALI KA ");

            Console.Write("\n PUTA KA! SINO BA NAMANG MAGMUMULTIPLY KASI SA ZERO, HA?! ");
            Console.Write("\n ULITIN MO NGA!!! ");
            num = Convert.ToInt32(Console.ReadLine());
        }
       
        Console.WriteLine("\n ITO ANG MULTIPLICATION TABLE NG SINABI MO! ");

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("\n");

            for (int j = 1; j <= num; j++)
            {
                Console.Write("{0, 6}", i * j);
            }
        }
        Console.WriteLine("\n GOOD BOY!");
        Console.Read();
    }
}
