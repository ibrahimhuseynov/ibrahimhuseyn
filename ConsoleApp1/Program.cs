using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lench;
            do
            {
                Console.WriteLine("bir eded daxil edin :");
                lench = Convert.ToInt32(Console.ReadLine());
            } while (lench < 0);
            Book[] books = new Book[lench];
            for (int i = 0; i < lench; i++)
            {
                string name = getstr("name daxil edin :", 30, 1);
                int no = getint("kitabin no daxil edin :", 100, 1);
                int count = getint("kitabin sayini daxil edin :", 100, 1);
                double prince = getdouble("kitabin pricesini daxil edin :", 1000, 1);
                string genre = getstr("kitabin genrini daxil edin :", 10000, 5);
                books[i] = new Book(genre, no, name, prince)
                {
                    Name = name,
                    Count = count,
                };

            }
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("kitabin adi :" + books[i].Name);
                Console.WriteLine("kitabin sayi :" + books[i].Count);
                Console.WriteLine("kitabin generi :" + books[i].Genre);
                Console.WriteLine("kitabin no :" + books[i].No);
                Console.WriteLine("kitabin princesi :" + books[i].Prince);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1.kitablari qiymetine gore fiyatla :");
            Console.WriteLine("2.Kitablar icinde axtaris :");
            Console.WriteLine("3.Butun kitablari goster :");
            Console.WriteLine("0.Proqrami bagla :");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("bir imput daxil edin:");
            int imput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < books.Length; i++)
            {
                switch (imput)
                {

                    case 1:
                        Console.WriteLine("min fiyati daxil edin :");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("max fiyati daxil edin :");
                        int max = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine(" string bir deyer daxil edin :");
                        string ad = Convert.ToString(Console.ReadLine());
                        if (ad == books[i].Name)
                        {
                            Console.WriteLine(books[i].Name);
                        }
                        break;
                    case 3:
                        Console.WriteLine("kitabin adi :" + books[i].Name);

                        Console.WriteLine("-------------------------");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("1.kitablari qiymetine gore fiyatla :");
                        Console.WriteLine("2.Kitablar icinde axtaris :");
                        Console.WriteLine("3.Butun kitablari goster :");
                        Console.WriteLine("0.Proqrami bagla :");
                        break;
                    case 0:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("menyudan bir imput daxil edin :");
                        break;

                }
                Console.ReadLine();
            }
        }
        static string getstr(string name, int max, int min)
        {
            string imput;
            do
            {
                Console.WriteLine(name);
                imput = (Console.ReadLine());
            } while (imput.Length < min || imput.Length > max);
            return imput;
        }
        static int getint(string name, int max, int min)
        {
            int imput;
            do
            {
                Console.WriteLine(name);
                imput = Convert.ToInt32(Console.ReadLine());
            } while (imput < min || imput > max);
            return imput;
        }
        static double getdouble(string name, double max, double min)
        {
            double imput;
            do
            {
                Console.WriteLine(name);
                imput = Convert.ToDouble(Console.ReadLine());
            } while (imput < min || imput > max);
            return imput;
        }
    }
}
