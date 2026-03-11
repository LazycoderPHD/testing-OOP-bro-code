using testing_OOP_bro_code;


//RunBasicOOPDemo();
RunConstructorDemo();
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

void RunConstructorDemo()
{
    // constructor = A special method to initialize objects
    //                         You can pass arguments to a constructor
    //                         and set up initial values
    Student student1 = new Student();
    Student student2 = new Student();
    Console.WriteLine(student1.name);
    Console.WriteLine(student2.name);
}

