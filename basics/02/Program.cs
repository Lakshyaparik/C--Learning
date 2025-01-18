using System;
class Abc{
    public static void Main(string[] args)
    {
        //type casting

        int a=10;
        double b=a;  //implicit type casting
        // Console.WriteLine(a);
        // Console.WriteLine(b);

        double num1=100;
        int num2=(int)(num1);//explicit typecasting
        //Console.WriteLine(num2);

        //const bool ischeck=true;
        //Console.WriteLine(Convert.ToString(ischeck));

        //userinput

        //Console.WriteLine("Enter your name");
        //string name=Console.ReadLine();

        //Console.WriteLine(name);

        //Console.WriteLine("Enter your age");
        //int age=Convert.ToInt32(Console.ReadLine());

        //math class in c#

        float abc=9.99f;
        //Console.WriteLine(Math.Round(abc));

        float x=-4.55f;
        Console.WriteLine(Math.Abs(x));
    }
}