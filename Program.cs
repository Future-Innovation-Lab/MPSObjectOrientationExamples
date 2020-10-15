using System;
using System.Collections.Generic;

namespace ObjectOrientation
{
    class Program
    {
        public static void DisplayShapes(Shape shape)
        {
             Console.WriteLine(shape.GetArea());

        }

        public static void DisplayPerson(Student person)
        {
               Console.WriteLine(person.StudentNumber);
        }


        static void Main(string[] args)
        {
            // ABSTRACTION

            Shape box = new Square(50);
            DisplayShapes(box);
           
            Shape tri = new Triangle(10,10);
            DisplayShapes(tri);

            // INHERITANCE

            Student tyrese = new Student();
            tyrese.Name = "Tyrese";
            tyrese.Age = 56;
            tyrese.StudentNumber = 12345;
            
            // POLYMORPHISM

            Animal pig = new Pig();
            Animal dog = new Dog();
            Animal tiger = new Tiger();
            Animal rhino = new Rhino();
            List<Animal> kennel = new List<Animal>();
            kennel.Add(dog);
            kennel.Add(pig);
            kennel.Add(tiger);
            kennel.Add(rhino);


// IN CLASS QUESTIONS ->  VARIOUS DIFFERENT LOOPS

/*            for (int index=0;index < kennel.Count;index++)
            {
                var animal = kennel[index];
                animal.MakeSound();
            }

            int index = 0;
            while (index < kennel.Count)
            {
                var animal = kennel[index];
                animal.MakeSound();
                index++;
            }

            foreach(Animal animal in kennel)
            {
                animal.MakeSound();
            }

*/
        }
         
    }
}
