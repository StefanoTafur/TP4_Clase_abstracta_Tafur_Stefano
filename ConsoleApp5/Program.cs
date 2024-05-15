// base Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
    public abstract void animaltype();
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
    public override void animaltype()
    {
        Console.WriteLine("The pig is mammal");
    }
}
class Dog : Animal 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: wow wow");
    }
    public override void animaltype()
    {
        Console.WriteLine("The dog is mammal");
    }
}
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: miau miau");
    }

    public override void animaltype()
    {
        Console.WriteLine("The cat is a mammal");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.animaltype();
        myPig.sleep();  // Call the regular method

        Dog myDog = new Dog();
        myDog.animalSound();
        myDog.animaltype();
        myDog.sleep();


        Cat myCat = new Cat();
        myCat.animalSound();
        myCat.animaltype();
        myCat.sleep();
    }
}