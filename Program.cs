using System;

namespace conditionals
{
  class Program
  {
    static void Main(string[] args)
    {
      int age = 17;

      if ((age >= 5) && (age <= 7))
      {
        System.Console.WriteLine("This student should go to Elementary School");
      }
      else if ((age > 7) && (age < 13))
      {
        System.Console.WriteLine("This student should go to Middle School");
      }
      else if ((age > 13) && (age < 19))
      {
        System.Console.WriteLine("This student should go to High School");

      }
      else
      {
        System.Console.WriteLine("This student should go to College");

      }


      if (( age > 14 ) || ( age < 19)) {
          System.Console.WriteLine("You should'nt work.");
      }

      bool canDrive = age >= 16;

      switch (age) {
          case 1:
          case 2:
            System.Console.WriteLine("Go to daycare");
            break;
            case 3:
            case 4:
                System.Console.WriteLine("Go to preschool");
                break;
            case 5:
            System.Console.WriteLine("Go to kindergarten");
            break;
            default:
                System.Console.WriteLine("Go to another school");
      }


      string name = "Derek";
      string name2 = "Derek";

      if (name.Equals(name2, StringComparison.Ordinal)) {
          System.Console.WriteLine("The names are equal");
      }
    }
  }
}
