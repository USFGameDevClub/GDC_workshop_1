class Functions
{

    /* 
     * Methods/Functions: 
     *
     * A method is a code block that contains a series of statements. 
     * A program causes the statements to be executed by calling the method and specifying any required method arguments. 
    */

    public static void printCharacterName(string characterName, int age) // Void: Method returns no value
    {                                                                    // Static: Belongs to the type itself rather an object instance
        Console.WriteLine("Your character's name is: " + characterName); // Arguments: information passed to a method that the method can use
        Console.WriteLine("Your character's age is: " + age);
    }
    static int magicCheck(int magStat, int diceRoll) // returns an int value when method is called
    {
        return diceRoll + magStat;
    }

    static void Main(string[] args) // Main method: main entry point for VS when program is run
    {
        /*
         * Variables: Variables are containers for storing data values. 
         * 
         * In C#, there are different types of variables (defined with different keywords), for example:
         * 
         *     int - stores integers (whole numbers), without decimals, such as 123 or -123
         *     double - stores floating point numbers, with decimals, such as 19.99 or -19.99
         *     char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
         *     string - stores text, such as "Hello World". String values are surrounded by double quotes
         *     bool - stores values with two states: true or false
         * 
         * Defining variables:
         * 
         * To define a variable in C#, you must atleast provide the data type and name of your variable
         * 
        */


        int hp = 0;
        int magStat = 5;
        string playerName = "Ritvik";
        bool isDead = false;

        /*
        Control statements: A control statement is a statement that determines whether other statements will be executed
        */

        if (hp == 0) // An if statement decides whether to execute another statement, or decides which of two statements to execute
        {
            Console.WriteLine(playerName + " is dead");
        }
        else
        {
            Console.WriteLine(playerName + " is not dead");
        }

        while (magStat > 0) // while condition in the parentheses is true, code in the block will be run
        {
            Console.WriteLine(playerName + " cast a spell!");
            magStat = magStat - 2;
        }


        for (int i = 0; i < magStat; i++)
        {
            Console.WriteLine(playerName + " cast a spell!");
        }


        printCharacterName("Adam", 21);
        int checkVal = magicCheck(12, 5);

        Console.WriteLine(checkVal);

        Person person1 = new Person("Adam", 21, "Software engineer"); // Instantiating a new object with name 'person1' from Person class

        Console.WriteLine(person1.getName());
        Console.WriteLine(person1.getAge());
        Console.WriteLine(person1.getOccupation());
    }

}
