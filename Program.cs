using System;

namespace ExplicitInterface1
{
   interface I1
   {
       void InterfaceMethod();
   }

   
   interface I2
   {
       void InterfaceMethod();
   }

   class MyClass : I1, I2
   {
      void I1.InterfaceMethod()
      {
          Console.WriteLine("I1 Interface Method");

      }

      void I2.InterfaceMethod()
      {
          Console.WriteLine("I2 Interface Method");
          
      }
   }

   class Program
   {
       public static void Main(string[] args)
       {
           I1 i1 = new MyClass();
           I2 i2 = new MyClass();

           i1.InterfaceMethod();
           i2.InterfaceMethod();
       }
   }
}
