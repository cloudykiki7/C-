using System;

class Program

{


    public static void Main(string[] args)
    {
        Console.Write("Enter Radius : ");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle c = new Circle(radius);

        c.Print();



    }

    class Circle
    {


        private double area;
        private double circumference;
        public int radius;


        public Circle(int r)
        {
            radius = r;
            Calculate();
        }

        public void Calculate()
        {
            area = 3.1416 * radius * radius;
            circumference = 2 * 3.1416 * radius;
        }

        public void Print()
        {
            Console.WriteLine($"Area is {area}");
            Console.WriteLine($"Circumference is {circumference}");
        }



    }



}
