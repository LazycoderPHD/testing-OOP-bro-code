using testing_OOP_bro_code;


//RunBasicOOPDemo();
void RunBasicOOPDemo()
{
    // Object = An entity that holds data (attributes)
    //                and can perform actions (methods)
    //                It is a reference data type

    class1.Testingcar car1 = new class1.Testingcar();
    class1.Testingcar car2 = new class1.Testingcar();

    Console.WriteLine($"{car1.make} {car1.model}");
    Console.WriteLine($"{car2.make} {car2.model}");

    car1.isRunning = false;

    Console.WriteLine(car1.make);
    Console.WriteLine(car1.model);
    Console.WriteLine(car1.year);
    Console.WriteLine(car1.price);
    Console.WriteLine(car1.isRunning);

    Console.WriteLine(car1.isRunning);

    car1.start();
    Console.WriteLine(car1.isRunning);
    car1.stop();
    Console.WriteLine(car1.isRunning);

    car1.drive();
    car1.brake();
}


//RunConstructorDemo();
void RunConstructorDemo()
{
    // constructor = A special method to initialize objects
    //                         You can pass arguments to a constructor
    //                         and set up initial values
    Student student1 = new Student("Spongebob", 30, 3.2);
    Student student2 = new Student("Patrick", 34, 1.5);
    Student student3 = new Student("Sandy", 36, 4.0);

    Console.WriteLine($"{student1.name}, {student1.age}, {student1.gpa}, {student1.isEnrolled}");
    Console.WriteLine($"\n{student2.name}, {student2.age}, {student2.gpa}, {student2.isEnrolled}");
    Console.WriteLine($"\n{student3.name}, {student3.age}, {student3.gpa}, {student3.isEnrolled}");

    student1.study();
    student2.study();
    student3.study();
}

RunOverloadedConstructorDemo();
void RunOverloadedConstructorDemo()
{
    // overloaded constructors = Allow a class to have multiple constructors
    //                                                 with different parameter lists.
    //                           Enable objects to be initialized in various ways.

    User user1 = new User("Spongebob");
    User user2 = new User("Phat", "phatdao2309@gmail.com");

    Console.WriteLine(user1.username);
    Console.WriteLine(user1.email);
    Console.WriteLine(user1.age);

    Console.WriteLine();

    Console.WriteLine(user2.username);
    Console.WriteLine(user2.email);
    Console.WriteLine(user2.age);
}

