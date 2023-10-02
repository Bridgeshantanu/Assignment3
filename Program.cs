namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor
            //Student student = new Student();

            //Person person = new Person("Sarthak", 25);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);



            //interface
            //IShape circle = new Circle(5.0);
            //IShape rectangle = new Rectangle(4.0, 3.0);

            //Console.WriteLine("Circle Area: " + circle.CalculateArea());
            //Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());



            //access modifiers
           
            MyClass myObject = new MyClass();
            myObject.MyField = 42; 
            myObject.MyMethod();   
            Console.WriteLine(myObject.MyField); 

            
            MyClass1 myObject1 = new MyClass1();
            myObject1.AccessPrivateMembers();


            MyDerivedClass derivedObject = new MyDerivedClass();
            derivedObject.AccessProtectedField();
            int value = derivedObject.GetProtectedField();
            Console.WriteLine("Value of myProtectedField: " + value);


            AnotherClass anotherObject = new AnotherClass();
            anotherObject.AccessInternalField();
        }
    }
}