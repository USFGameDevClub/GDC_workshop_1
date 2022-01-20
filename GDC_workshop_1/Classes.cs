/*
 * A class is like a blueprint of a specific object
 * They contain some properties, fields, events, methods, etc. 
 * A class defines the kinds of data and the functionality their objects will have.
 */
class Person
{
    private string _name;
    private int _age;
    private string _occupation;

    /*
     * Constructor:
     * Whenever a class is created, its constructor is called. 
     * A class may have multiple constructors that take different arguments. 
     * Constructors enable the programmer to set default values, 
     * limit instantiation, and write code that is flexible and easy to read
     */
    public Person(string name, int age, string occupation)  // pass in variables that you want to be instantiated as arguments
    {
        this._name = name;
        this._age = age;
        this._occupation = occupation;
    }

    public void Sleep()
    {
        Console.WriteLine(this._name + " is sleeping");
    }

    public string getName()
    {
        return this._name;
    }

    public int getAge()
    {
        return this._age;
    }

    public string getOccupation()
    {
        return this._occupation;
    }

    public void setName(string name)
    {
        this._name = name;
    }

    public void setAge(int age)
    {
        this._age=age;
    }

    public void setOccupation(string occupation)
    {
        this._occupation=occupation;
    }
}

// Paste code from the main function below into the main function in Functions.cs to test
/*
class main
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Adam", 21, "Software engineer");

        Console.WriteLine(person1.getName());
        Console.WriteLine(person1.getAge());
        Console.WriteLine(person1.getOccupation());

        person1.setName("Ritvik");
        Console.WriteLine(person1.getName());
        person1.setOccupation("Student");
        Console.WriteLine(person1.getOccupation());
        person1.Sleep();
    }
}
    
*/