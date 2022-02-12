using System;

namespace Rectangle
{
    class Program
    {

                /*    
                 Hljóðs bið ek allar helgar kindir,
                 meiri ok minni mögu Heimdallar;
                 viltu at ek, Valföðr, vel fyr telja
                 forn spjöll fíra, þau er fremst um man.
                                                      */
        static void Main(string[]args)
        {

            int en;                                       //değişkenler
            int boy;

            Console.WriteLine("En gir:");
            en = Convert.ToInt16(Console.ReadLine());     //kullanıcıdan veri çekme
            Console.WriteLine("------------------"); 

            Console.WriteLine("Boy gir:");
            boy = Convert.ToInt16(Console.ReadLine());    //kullanıcıdan veri çekme
            Console.WriteLine("------------------");



            for (int i = 1; i <= boy; i++)
            {

                for (int j = 1; j <= en; j++)

                {
                    if (i == 1 || i == boy)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        if (j == 1 || j == en)
                        { 
                            Console.Write("*");
                        }


                        else

                        { 
                            Console.Write(" ");   //şeklin içini doldurmak için burası kullanılır
                        }
                    }

                }
                Console.WriteLine(" "); 


            }
        }
    }
}
