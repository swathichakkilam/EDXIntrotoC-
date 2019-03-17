using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            Sum(20, 40);

            int result = Sum2(20, 40);
            Console.WriteLine($"Sum is : {result}");
            Console.WriteLine("Method Overloading passing int type and double type parameters to Sum method");
            int reslt = Sum(20, 40.5);
    Console.WriteLine($"Calling Sum() with two arguments 20 is int and 40.5 is  double explicit typecasting double to int and storing reslt as int, result is: {reslt}");

            Console.WriteLine("Method Overloading passing 3 int type (difference in number of params passed) parameters to Sum method");
            int result3 = Sum(10, 50, 80);
                Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");
            Console.WriteLine("Method Overloading passing double type and double type (two similar datatypes but different from int)parameters to Sum method");
            double dblResult = Sum(20.5, 30.6);
               Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
            
            Console.ReadLine();
        }
        #region
        public static void Sum(int first, int second)

        {
            int Sum = first + second;
            Console.WriteLine($"the Sum of {first} and {second}is : {Sum}");

        }

            // Sum2() method that takes two integer arguments and sums them
            // The method returns an integer value which is why we use int in the signature
            // We also need to use static in the method signature because Main is static
            // and you cannot call a non-static method from a static method
            //Sum2() method not declared with same name as Sum() which is a void method is 
            //because Sum() method and Sum2() have same parameter signature and Method Overloading doesnt happen 
            //due to difference in return types it is solely based on difference in type of parameters passed or number  //parameters passed
           public  static int Sum2(int first, int second)
            {
                int sum = first + second;
                return sum;
            }
        /// <summary>
        /// Sum method being overloaded with two different types of parameters being passed  
        /// and also showing explicit typecast of double to integer valuetype and storing it
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int Sum (int first,double second)
        {
            int res = first + (int)second;
            return res;
        }
        // Sum() method that takes three integer arguments and sums them
        // and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in
        /// <summary>
        /// Method Overloading by passing an extra parameter named third
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
       public  static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        // Sum() method that takes two doubles as arguments
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting two doubles as arguments
        // The compiler knows which method to call based on the arguments data types
      public static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }


        #endregion

    }
}
