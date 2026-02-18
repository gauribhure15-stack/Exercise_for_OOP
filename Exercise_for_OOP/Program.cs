using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

//2.BASIC OOP EXERCISES
//    Exercise 1: Student Class
//Attributes:
//-name
//- rollNo
//- marks
//Method:
//-displayDetails()

//using System;

//public class Student
//{

//    string name;
//    int rollNo;
//    double marks;


//    public Student(string name, int rollNo, double marks)
//    {
//        this.name = name;
//        this.rollNo = rollNo;
//        this.marks = marks;
//    }


//    public void DisplayDetails()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Roll No: " + rollNo);
//        Console.WriteLine("Marks: " + marks);
//    }


//   public static void Main(string[] args)
//    {
//        Student s1 = new Student("Ananya", 10, 90);
//        s1.DisplayDetails();

//        Console.ReadLine(); 
//    }
//}

//Exercise 2: Rectangle Class
//Attributes:
//-length
//- width
//Methods:
//-calculateArea()
//- calculatePerimeter()

//using System;

//public class Rectangle
//{

//    double length;
//    double width;


//    public Rectangle(double length, double width)
//    {
//        this.length = length;
//        this.width = width;
//    }


//    public double CalculateArea()
//    {
//        return length * width;
//    }


//    public double CalculatePerimeter()
//    {
//        return 2 * (length + width);
//    }


//   public  static void Main(string[] args)
//    {
//        Rectangle rect = new Rectangle(20, 10);

//        Console.WriteLine("Length: 20");
//        Console.WriteLine("Width: 10");
//        Console.WriteLine("Area: " + rect.CalculateArea());
//        Console.WriteLine("Perimeter: " + rect.CalculatePerimeter());

//        Console.ReadLine(); 
//    }
//}
//Exercise 3: Car Class
//Attributes:
//-brand
//- model
//- year
//Methods:
//-startCar()
//- stopCar()

//using System;

//public class Car
//{
    
//    string brand;
//    string model;
//    int year;

    
//    public Car(string brand, string model, int year)
//    {
//        this.brand = brand;
//        this.model = model;
//        this.year = year;
//    }

    
//    public void StartCar()
//    {
//        Console.WriteLine(brand + " " + model + " is starting...");
//    }

    
//    public void StopCar()
//    {
//        Console.WriteLine(brand + " " + model + " is stopping...");
//    }

    
//    public static void Main(string[] args)
//    {
//        Car car = new Car("Toyota", "Corolla", 2022);

//        Console.WriteLine("Car Details:");
//        Console.WriteLine("Brand: Toyota");
//        Console.WriteLine("Model: Corolla");
//        Console.WriteLine("Year: 2022");

//        car.StartCar();
//        car.StopCar();

//        Console.ReadLine(); 
//    }
//}

