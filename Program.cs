using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1. View all Students’ Records");
            Console.WriteLine("2. View a Student’s Records by ID");
            Console.WriteLine("3. Show the Highest Final Grade");
            Console.WriteLine();
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine();
            

            int[,] array2D = new int[,] {   { 12345,80,70,90,90,90},
                                            { 23456,95,85,95,60,95},
                                            { 34567,90,95,75,50,85},
                                            { 45678,85,90,95,40,80} };

            int a;
            int rowLength = array2D.GetLength(0);
            int colLength = array2D.GetLength(1);

            a = Convert.ToInt32(Console.ReadLine());

            if  (a == 1)
            {
                Console.WriteLine("StudentID  Attendance Lab1  Lab2  Lab3  CaseStudy");
                Console.WriteLine("==================================================");
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(string.Format("{0} ", array2D[i, j]));
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
            }


            if (a==2)
            {
                
                Console.WriteLine("Please enter StudentID:");
                
                int stud;
                stud = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("StudentID  Attendance Lab1  Lab2  Lab3  CaseStudy");
                Console.WriteLine("==================================================");

                if (stud == 12345)
                
                {
                    for (int i = 0; i < colLength; i++)
                    {
                        Console.Write(string.Format("{0} ", array2D[0, i]));
                    }
                }
                if (stud == 23456)
                
                {
                    for (int i = 0; i < colLength; i++)
                    {
                        Console.Write(string.Format("{0} ", array2D[1, i]));
                    }
                }
                if (stud == 34567)
                
                {
                    for (int i = 0; i < colLength; i++)
                    {
                        Console.Write(string.Format("{0} ", array2D[2, i]));
                    }
                }
                if (stud == 45678)
            
                {
                    for (int i = 0; i < colLength; i++)
                    {
                        Console.Write(string.Format("{0} ", array2D[3, i]));
                    }
                }
            }

            int gr1,gr2,gr3,gr4;
            gr1 = (array2D[0, 1] + array2D[0, 2] + array2D[0, 3] + array2D[0, 4] + array2D[0, 5])/5;            
            gr2 = Convert.ToInt32((array2D[1, 1] + array2D[1, 2] + array2D[1, 3] + array2D[1, 4] + array2D[1, 5])/5);
            gr3 = Convert.ToInt32((array2D[2, 1] + array2D[2, 2] + array2D[2, 3] + array2D[2, 4] + array2D[2, 5])/5);
            gr4 = Convert.ToInt32((array2D[3, 1] + array2D[3, 2] + array2D[3, 3] + array2D[3, 4] + array2D[3, 5])/5);

            var grades = new[] { gr1, gr2, gr3, gr4 };
            int maxV = grades.Max();

            if (a==3)
            {
                Console.WriteLine("Maximum grade: {0}", maxV);
            }




            Console.ReadLine();
        }
    }
}
