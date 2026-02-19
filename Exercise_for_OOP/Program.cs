using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

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

//3.ENCAPSULATION EXERCISES
//======================================

//Exercise 4: BankAccount
//Private Variables:
//- accountNumber
//- balance

//Public Methods:
//- deposit()
//- withdraw()
//- getBalance()

//Conditions:
//- No negative withdrawal
//- No insufficient balance




//4.CONSTRUCTOR EXERCISES
//======================================

//Exercise 6: Mobile Class
//Attributes:
//- brand
//- price
//Constructor:
//- Initialize values
//Method:
//- display()

//using System;

//class Mobile
//{

//    private string brand;
//    private double price;


//    public Mobile(string brand, double price)
//    {
//        this.brand = brand;
//        this.price = price;
//    }


//    public void Display()
//    {
//        Console.WriteLine("Mobile Brand: " + brand);
//        Console.WriteLine("Mobile Price: $" + price);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        Mobile mobile1 = new Mobile("Motorola", 15000);


//        mobile1.Display();
//    }
//}

//Exercise 7: Book Class
//Attributes:
//-title
//- author
//- price

//Constructors:
//-Default constructor
//- Parameterized constructor


//using System;
//using System.Threading.Channels;
//public class Book
//{
//    public string tittle;
//    public string author;
//    public int price;


//    public Book()//Default Constructor
//    {
//        tittle = "Aganipankh";
//        author = "Dr.A.P.J.Abdul Kalam";
//        price = 200;
//    }
//    public Book(string tittle, string author, int price)//Parameterized Constructor
//    {
//        this.tittle=tittle;
//        this.author = author;
//        this.price = price;
//    }
//    public void Display()
//    {
//        Console.WriteLine("tittle :"+tittle);
//        Console.WriteLine("Author :"+author);
//        Console.WriteLine("Price:"+price);
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Book book = new Book();
//        Console.WriteLine("The Book created by Default Constructor");
//        Console.WriteLine("The Book Created by Parameterized Constructor");
//        book.Display();
//        Console.ReadLine();
//    }
//}

//Exercise 8: Person->Student

//Person:
//-name
//- age
//- display()

//Student:
//-rollNumber
//- marks
//using System;


//public class Person
//{
//    public string name;
//    public int age;


//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }


//    public void Display()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Age: " + age);
//    }
//}


//public class Student : Person
//{
//    private int rollNumber;
//    private double marks;


//    public Student(string name, int age, int rollNumber, double marks)
//        : base(name, age)   
//    {
//        this.rollNumber = rollNumber;
//        this.marks = marks;
//    }


//    public void DisplayStudent()
//    {

//        Display();
//        Console.WriteLine("Roll Number: " + rollNumber);
//        Console.WriteLine("Marks: " + marks);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student student1 = new Student("Arjun", 20, 01, 80);

//        Console.WriteLine("Student Details:");
//        student1.DisplayStudent();
//    }
//}

//Exercise 9: Animal->Dog

//Animal:
//-eat()

//Dog:
//-bark()

//using System;
//using System.Security.Cryptography.X509Certificates;
//public class Animal
//{
//    public void Eat()

//    {
//        Console.WriteLine("Animal is Eating");

//    }
//    public class Dog : Animal
//    {
//        public void bark()
//        {
//            Console.WriteLine("Dog is Barking");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Dog dog = new Dog();
//            dog.bark();
//            dog.Eat();
//            Console.ReadLine();
//        }


//    }
//}

//6.POLYMORPHISM EXERCISES
//======================================

//Exercise 10: Method Overloading (Calculator)
//Methods:
//- add(int, int)
//- add(double, double)
//- add(int, int, int)


//using System;
//using System.ComponentModel;
//using System.Threading.Channels;
//public class Calculator
//{
//    public int Add(int a, int b)
//    {
//      return a+ b;
//    }
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//    public int Add(int a , int b , int c)
//    {
//        return a + b + c; 
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Calculator calc = new Calculator();
//        Console.WriteLine("Add(int,int):" + calc.Add(10, 20));
//        Console.WriteLine("Add(double , double):" + calc.Add(15, 30));
//        Console.WriteLine("Add(int , int , int):" + calc.Add(10, 50, 30));
//        Console.WriteLine();

//    }

//}

//Exercise 11: Method Overriding

//Shape:
//-draw()

//Circle:
//-draw()

//Rectangle:
//-draw()

//using System;
//public class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("The drawing Shape");
//    }

//}
//public class Circle:Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("drawing Circle");
//    }
//}
//public class Rectangle:Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing Rectangle");
//    }

//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Shape shape1 = new Circle();
//        Shape shape2 = new Rectangle();

//        shape1.Draw();
//        shape2.Draw();
//    }
//}


//7.ABSTRACTION EXERCISES
//======================================

//Exercise 12: Abstract Class

//Vehicle (Abstract)
//- start()
//- stop()

//Bike:
//- start()
//- stop()

//Car:
//- start()
//- stop()

//using System;
//public abstract class Vehicle
//{
//    public abstract void start();
//    public abstract void stop();
//}
// class Bike:Vehicle
//{
//    public override void  start()
//    {
//        Console.WriteLine("Bike Is Start");
//    }
//    public override void stop()
//    {
//        Console.WriteLine("Bike is stop");
//    }
//}
//class Car:Vehicle
//{
//    public override void start()
//    {
//        Console.WriteLine("Car is Start");
//    }
//    public override void stop()
//    {
//        Console.WriteLine("Car is Stop");
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        Vehicle v1 = new Bike();
//        Vehicle v2 = new Car();
//        v1.start();
//        v1.stop();

//        v2.start();
//        v2.stop();

//    }
//}






