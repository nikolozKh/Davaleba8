
using Davaleba8;

Person person = new Person("nika",new DateTime(2009, 9, 16), "ragaca@gmail.com", "paroli12");

person.print();

Console.WriteLine();
Console.WriteLine();

Dog dog = new Dog("Sharik", "Labrador", 5);
dog.Print();

dog.Name = "Max";
dog.Breed = "Bulldog";
dog.Age = 6;

dog.Print();


Console.WriteLine();

Rectangle rectangle = new Rectangle(5, 10);
rectangle.Print();