using System;
using System.Security.Cryptography;
using S4.Overloading;

namespace S4
{
    internal class Program
    {
        static int SumNumbers(int x, int y)
        {
            return x + y;
        }
        //static double SumNumbers(int x, int y)
        //{
        //    return x + y;
        //}
        static int SumNumbers(int x,int y,int z)
        {
            return x + y + z;
        }
        static double SumNumbers(double a,double b)
        {
            return a + b;
        }
        static double SumNumbers(double a,int b)
        {
            return a + b;
        }
        static double SumNumbers(int a,double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            #region Methods OverLoading
            //double A = 10.2, B = 20.3, C = 30;
            //int Result = SumTwoNumbers(A, B);
            //int Result = SumThreeNumbers(A, B, C);
            //double Result = SumNumbers(A, B);
            //int Result = SumNumbers(10, 20, 30);
            //Console.WriteLine(Result);

            //Console.WriteLine(); 
            #endregion

            #region Operator Overloading

            // 5 + 4i
            //Complex C1 = new Complex()
            //{
            //    Real = 10,
            //    Img = 1
            //};
            //Console.WriteLine($"C1 = {C1}");

            //Complex C2 = new Complex()
            //{
            //    Real = 10,
            //    Img = 2
            //};
            //Console.WriteLine($"C2 = {C2}");

            //Complex C3;
            //Console.WriteLine("======================");
            //Console.WriteLine($"C3 = {C3}");

            //C3++;
            //Console.WriteLine("======================");
            //Console.WriteLine($"C3 = {C3}");

            //C3--;
            //Console.WriteLine("======================");
            //Console.WriteLine($"C3 = {C3}");

            //if(C1 > C2)
            //    Console.WriteLine("C1 > C2");
            //else
            //    Console.WriteLine("C1 < C2");

            #endregion

            #region Casting Operator
            //int X = (int)C1;

            //string X = C1;
            //Console.WriteLine(X);

            User userObj = new User()
            {
                Id = 10,
                FullName = "Mostafa Hany",
                Email = "Mostafa@gmail.com",
                Password = "p@ssw0rd",
                SecurityStamp = Guid.NewGuid()
            };
            // Manual Mapping
            UserViewModel userViewModel = (UserViewModel)userObj;
            Console.WriteLine(userViewModel.Id);
            Console.WriteLine(userViewModel.FirstName);
            Console.WriteLine(userViewModel.LastName);
            Console.WriteLine(userViewModel.Email);
            #endregion

        }
    }
}
