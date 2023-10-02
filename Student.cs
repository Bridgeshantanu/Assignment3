using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Student
    {
        public Student()
        {
            Console.WriteLine("ram");
        }
    }


    class Person
    {
        public string Name;
        public int Age;
        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }
    }



    //interface
    interface IShape
    {
        double CalculateArea();
    }

   class Circle : IShape
   {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
   }

    class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }
    }


    //access modifiers
    public class MyClass
    {
        public int MyField; 

        public void MyMethod() 
        {
            
        }
    }

    class MyClass1
    {
        private int myPrivateField;

        private void MyPrivateMethod() 
        {
            Console.WriteLine("Private method called.");
        }

        public void AccessPrivateMembers()
        {
           
            myPrivateField = 45;
            MyPrivateMethod();

            Console.WriteLine($"Private field value: {myPrivateField}");
        }
    }


    class MyBaseClass
    {
        protected int myProtectedField; 
    }

    class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedField()
        {
            myProtectedField = 52; 
        }

        public int GetProtectedField()
        {
            return myProtectedField; 
        }
    }


    internal class MyInternalClass
    {
        internal int MyInternalField; 
    }

    internal class AnotherClass
    {
        public void AccessInternalField()
        {
            MyInternalClass myInternalObject = new MyInternalClass();
            myInternalObject.MyInternalField = 70; 
            Console.WriteLine("Value of MyInternalField: " + myInternalObject.MyInternalField);
        }
    }
}
