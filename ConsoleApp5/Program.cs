using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lesson2 if_else 
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ab();
            abc();
            //maxx();
            //minn();
            //three_max();
            //three_min();
            //three_descend();
            //three_ascendd();
            //evenn();
            //divfive();
            //divtwothree();
            //divdivdiv();
        }

        //1. Լուծել a * x + b = 0 գծային հավասարումը կամայական a և b թվերի համար։
        static void ab()
        {

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a != 0 && b != 0)

            {

                double x = (0 - b) / a;
                Console.Write("x =   {0}", x);

            }

            else
            {
                Console.Write("No solution");
            }

            Console.ReadLine();

        }

        //2. Լուծել a x x + b * x + c = 0 քառակուսային հավասարումը կամայական a, b և c թվերի համար։
        static void abc()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d == 0)

            {
                double x = (-b + Math.Sqrt(d)) / (2 * a);
                Console.Write("  d =   {0}", +d);
                Console.Write("Roots are equal x =   {0}", +x);

            }

            else if (d > 0)

            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.Write("  d = {0}", +d);
                Console.Write("  x1 = {0}", +x1);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.Write("  x2 = {0}", +x2);

            }

            else
            {
                Console.Write("roots are complex values. no solution");
            }
            Console.ReadLine();

        }

        //3. Գտնել երկու թվերից մեծագույնը։
        static void maxx()

        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)

            {
                Console.Write("max = a = {0}", a);

            }

            else
            {
                Console.Write("max = b = {0}", b);
            }

            Console.ReadLine();
        }

        // 4. Գտնել երկու թվերից փոքրագույնը։
        static void minn()

        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)

            {
                Console.Write("min = a = {0}", a);

            }

            else
            {
                Console.Write("min = b = {0}", b);
            }

            Console.ReadLine();
        }

        //5. Գտնել երեք թվերից մեծագույնը։
        static void three_max()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)

            {
                Console.Write("max = a = {0}", a);

            }

            else if (b > c && b > a)

            {
                Console.Write("max = b = {0}", b);
            }

            else

            {
                Console.Write("max = c = {0}", c);


            }

            Console.ReadLine();

        }


        //6. Գտնել երեք թվերից փոքրագույնը։

        static void three_min()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)

            {
                Console.Write("min = a = {0}", a);

            }

            else if (b < c && b < a)

            {
                Console.Write("min = b = {0}", b);
            }

            else

            {
                Console.Write("min = c = {0}", c);



            }

            Console.ReadLine();

        }


        //7. Արտածել a, b և c կամայական թվերը նվազման կարգով։
        static void three_descend()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c)

            {
                Console.Write(" descend = {0}, {1}, {2}", a, b, c);

            }

            else if (b > c && c > a)

            {
                Console.Write(" descend = {1}, {2}, {0}", a, b, c);
            }

            else if (c > a && a > b)

            {
                Console.Write(" descend = {2}, {0}, {1}", a, b, c);


            }

            else if (b > a && a > c)

            {
                Console.Write(" descend = {1}, {0}, {2}", a, b, c);


            }
            Console.ReadLine();

        }



        //8. Արտածել a, b և c կամայական թվերը աճման կարգով։
        static void three_ascendd()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && b < c)

            {
                Console.Write(" ascendd = {0}, {1}, {2}", a, b, c);

            }

            else if (b < c && c < a)

            {
                Console.Write(" ascendd = {1}, {2}, {0}", a, b, c);
            }

            else if (c < a && a < b)

            {
                Console.Write(" ascendd = {2}, {0}, {1}", a, b, c);


            }

            else if (a < b && c < b)

            {
                Console.Write(" ascendd = {0}, {2}, {1}", a, b, c);


                Console.ReadLine();

            }

        }



        //9. Պարզել ներմուծված թիվը զու՞յգ է, թե՞ կենտ։
        static void evenn()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;
            if (a % 2 == 0)
            {
                Console.Write(" a is even number");
            }

            else
            {
                Console.Write(" a is not even number ");
            }

            Console.ReadLine();

        }
        //10.Պարզել ներմուծված թիվը արդյոք բաժանվու՞մ է առանց մնացորդի 5-ի վրա։
        static void divfive()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;
            if (a % 5 == 0)
            {
                Console.Write(" a is deviding on 5");
            }

            else
            {
                Console.Write(" a not deviding on 5 ");
            }

            Console.ReadLine();
        }
        //11. Ներմուծված թիվը բազմապատկել 2-ով, եթե այն զու՞յգ է և առանց մնացորդի բաժանվու՞մ է 3-ի վրա։

        static void divtwothree()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;
            if (a % 3 == 0 && a % 2 == 0)
            {
                int b = a * 2;
                Console.Write(b);
            }

            else
            {
                Console.Write("{0} not dividing on 2 and 3", a);
            }

            Console.ReadLine();
        }

        //12. Ներմուծված թիվը բազմապատկել 2-ով, եթե այն կենտ է կամ առանց մնացորդի բաժանվում է 3-ի վրա։

        static void divdivdiv()
        {

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine()); ;
            if (a % 3 == 0 || a % 2 != 0)
            {
                int b = a * 2;
                Console.Write(b);
            }

            else
            {
                Console.Write("error", a);
            }

            Console.ReadLine();
        }


    }




}








