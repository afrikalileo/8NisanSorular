1)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);



                DateTime dt = new DateTime(year, month, day, hour, minute, 0);


                datetime.Add(dt);

                Console.WriteLine(dt.ToString());



            }
            Console.ReadLine();

        }


    }
}

2)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);




                if (dt.DayOfWeek != DayOfWeek.Saturday || dt.DayOfWeek != DayOfWeek.Sunday)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }
                Console.ReadLine();



            }

        }


    }
}

3)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);




                if (dt.Month == 2)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

4)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);




                if (dt.Hour <= 12)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

5)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();


            int sayac = 1;

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.DayOfWeek == DayOfWeek.Monday)



                {


                    ++sayac;

                    Console.WriteLine("pazartesi sayisi" + " " + sayac);


                }


            }
            Console.ReadLine();


        }


    }
}

6)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<DateTime> datetime = new List<DateTime>();


            int sayac = 1;

            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.Hour >= 17 && dt.Hour <= 18)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

7)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<DateTime> datetime = new List<DateTime>();

            Console.WriteLine("bir yıl giriniz");

            int yil = Convert.ToInt32(Console.ReadLine());




            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.Year == yil)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

8)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<DateTime> datetime = new List<DateTime>();

            Console.WriteLine("bir yıl giriniz");

            int yil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("bir ay girin");

            int ay = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.Year == yil && dt.Month == ay)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

9)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<DateTime> datetime = new List<DateTime>();




            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.Year >= 2010)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

10)

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<DateTime> datetime = new List<DateTime>();




            for (int i = 0; i < 1000; i++)

            {
                int year = random.Next(2010, 2022);
                int month = random.Next(1, 13);
                int day = random.Next(1, 28);
                int hour = random.Next(7, 19);
                int minute = random.Next(0, 60);




                DateTime dt = new DateTime(year, month, day, hour, minute, 0);





                if (dt.Year >= 2010 && dt.Year <= 2015 && dt.Month == 1)



                {

                    datetime.Add(dt);

                    Console.WriteLine(dt.ToString());


                }


            }
            Console.ReadLine();


        }


    }
}

