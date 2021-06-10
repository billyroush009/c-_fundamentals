using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello World!
            Console.WriteLine("Hello World!");


            //@@@@@@@@@@@@@@@
            //Variables
            string characterName = "Bill";
            int characterAge = 29;

            Console.WriteLine("***String and Int Variable Demo:*** \n");
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge + "\n");

            characterName = "Billus";
            Console.WriteLine("Variable \"characterName\" after change: " + characterName + "\n");

            //empty ReadLine() can be used as a line-break and waiting for user to hit enter
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@
            //Data Types

            string phrase = "Billus' Academy";
            char grade = 'A';
            int age = 29;
            double gpa = 3.3;
            bool isMale = true;

            //printing out sample data types to console
            Console.WriteLine("Printing a string: " + phrase);
            Console.WriteLine("Printing a char: " + grade);
            Console.WriteLine("Printing an int: " + age);
            Console.WriteLine("Printing a double: " + gpa);
            Console.WriteLine("Printing a bool: " + isMale);

            Console.ReadLine();



            //@@@@@@@@@@@@@@@@@@@@
            //Working with strings

            Console.WriteLine("*Working with strings*: \n");

            string s_phrase = "Academy";
            Console.WriteLine("String variable: " + s_phrase);
            Console.WriteLine("String length: " + s_phrase.Length);
            Console.WriteLine("String in all uppercase: " + s_phrase.ToUpper());
            Console.WriteLine("String in all lowercase: " + s_phrase.ToLower());
            Console.WriteLine("If " + s_phrase + " contains \"adem\": " + s_phrase.Contains("adem"));
            Console.WriteLine("First character in string \"" + s_phrase + "\": " + s_phrase[0]);
            Console.WriteLine("Starting index of \"adem\" in " + s_phrase + ": " + s_phrase.IndexOf("adem"));
            Console.WriteLine("Substring of " + s_phrase + " from index 4 to 6: " + s_phrase.Substring(4,2));

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@
            //Working with numbers

            Console.WriteLine("*Working with numbers*: ");

            Console.WriteLine("5 / 2 = " + (5/2)); //integer result, no decimal
            Console.WriteLine("5 % 2 = " + (5%2)); //remainder
            Console.WriteLine("5.0 / 2.0 = " + (5.0/2.0)); //using decimals, result has remainder
            Console.WriteLine("5 / 2.0 = " + (5/2.0)); //if any part of the operation has a decimal, the result will be converted to a double/float

            int num = 6;
            Console.WriteLine("int num = " + num);
            num++; //incrementing
            Console.WriteLine("num++ = " + num);
            num = 6;
            num--; //decrementing
            Console.WriteLine("num-- = " + num);

            //math method examples
            Console.WriteLine("Math.Abs() of -40: " + Math.Abs(-40));
            Console.WriteLine("Math.Pow() 2^5: " + Math.Pow(2, 5));
            Console.WriteLine("Math.Sqrt() of 36: " + Math.Sqrt(36));
            Console.WriteLine("Math.Max() of set with values 4 and 90: " + Math.Max(4, 90));
            Console.WriteLine("Math.Min() of set with values 4 and 90: " + Math.Min(4, 90));
            Console.WriteLine("Math.Round() of 4.3: " + Math.Round(4.3));
            Console.WriteLine("Math.Round() of 4.6: " + Math.Round(4.6));

            Console.ReadLine();



            //@@@@@@@@@@@@@@@@@@@@@@@
            //User Input

            Console.WriteLine("*Working with user input*: ");

            Console.Write("Enter your name: "); //Console.Write() does not carry over to a new line
            string userName = Console.ReadLine(); //setting variable equal to user input
            userName = char.ToUpper(userName[0]).ToString() + userName.Substring(1, (userName.Length-1)); //capitalizing first letter of name, not very simple!
            Console.WriteLine("Hello " + userName);

            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ". You are " + userAge + " years old");

            Console.ReadLine();

          

            //@@@@@@@@@@@@@@@@@@@@@@@@
            //Building a Calculator
            Console.WriteLine("*Simple Calculator Example*: Will add 1st + 2nd input");

            //int c_num = Convert.ToInt32("45"); //"Convert" used to change string to integer

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); //readline defaults values to string, need to be converted for numeric input, using double to support decimals

            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2)); //displaying result
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@
            //Mad Lib Example
            Console.WriteLine("*Mad Lib Example*: Inputs will be placed into a pre-written story");

            string ml_adj, ml_pluralnoun, ml_celeb; //madlib string variables, assigned to user input below

            Console.Write("Enter an adjective: ");
            ml_adj = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            ml_pluralnoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            ml_celeb = Console.ReadLine();

            //printing out madlib one line at a time
            Console.WriteLine("\nRoses are " + ml_adj);
            Console.WriteLine(ml_pluralnoun + " are blue");
            Console.WriteLine("I love " + ml_celeb);

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Arrays

            int[] luckyNumbers = { 4, 7, 15, 16, 23, 42 }; //statically assigned array of integers
            string[] friends = new string[5]; //empty string array that will hold 5 values
            friends[0] = "Jim";
            friends[1] = "Bob";

            Console.WriteLine(luckyNumbers[0]); //displays first element of the array

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Methods
            Console.WriteLine("*Methods*: Running custom method \"SayHi()\"");

            SayHi("Bill", 29); //calling method w/ static string and integer
            Console.ReadLine();



            //@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Return Statements
            Console.WriteLine("*Return Statements*: custom cubing method");
            Console.Write("Enter an integer to be cubed: ");
            int cube_num = Convert.ToInt32(Console.ReadLine()); //user input for number to be cubed
            Console.WriteLine(cube_num + " ^ 3 = " + cube(cube_num));

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@
            //If statements
            Console.WriteLine("*If Statements*\n");

            isMale = false;
            bool isTall = false;

            //if example block, utilizing "and" (&&) with "negation" (!) operators
            if (isMale && isTall) {
                Console.WriteLine("You are a tall male");
            }else if (isMale && !isTall) {
                Console.WriteLine("You are a male that is not tall");
            }else if (!isMale && isTall){
                Console.WriteLine("You are tall and not male");
            }else{
                Console.WriteLine("You are not a tall male");
            }

            //using GetMax for further "if" example
            Console.WriteLine("Biggest number in set (20, 10, 15): " + GetMax(20,10,15)); //calling GetMax function in output message
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Better calculator

            Console.WriteLine("*Calculator w/ Operator*: +-*/\n");

            //assigning variables values from user input
            Console.Write("Enter first number: ");
            double calc_num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator(+-/*): ");
            string calc_op = Console.ReadLine();
            Console.Write("Enter second number: ");
            double calc_num2 = Convert.ToDouble(Console.ReadLine());

            //if statement to do correct operation based on user input, else checks for invalid
            if (calc_op == "+"){
                Console.WriteLine(calc_num1 + " + " + calc_num2 + " = " + (calc_num1+calc_num2));
            }else if (calc_op == "-"){
                Console.WriteLine(calc_num1 + " - " + calc_num2 + " = " + (calc_num1-calc_num2));
            }else if (calc_op == "*"){
                Console.WriteLine(calc_num1 + " * " + calc_num2 + " = " + (calc_num1*calc_num2));
            }else if (calc_op == "/"){
                Console.WriteLine(calc_num1 + " / " + calc_num2 + " = " + (calc_num1/calc_num2));
            }else{
                Console.WriteLine("Invalid Operator (+-*/)");
            }

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Switch Statements

            Console.WriteLine("*Switch Statements*");

            Console.WriteLine("GetDay(0): " + GetDay(0));
            Console.WriteLine("GetDay(4): " + GetDay(4));
            Console.WriteLine("GetDay(66): " + GetDay(66));

            Console.ReadLine();
       

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //While Loops

            Console.WriteLine("*While Loops*");

            int while_index = 1;
            //loops and iterates "while_index" variable while it is less than 5
            while(while_index <= 5){
                Console.WriteLine("Index: " + while_index);
                while_index++;
            }

            Console.WriteLine("\nDo-While Loop: Runs before condition is checked");
            //do-while loop demo, loop runs minimum of one time even if condition is false, checked after loop
            do {
                Console.WriteLine("Condition: while(Index <= 5)");
                Console.WriteLine("Index: " + while_index);
                while_index++;
            } while (while_index <= 5);

            Console.ReadLine();
  

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Guessing Game

            Console.WriteLine("*Guessing Game*: Guess the word! (spoiler alert: it's \"rhino\")");
            string secretWord = "rhino";
            string guess = "";
            int guess_count = 0; //number of guesses, user loses if they fail 3 times

            //guessing dp-while loop
            do{
                //gives user 3 guesses, if they guess three times and never match, game over
                if(guess_count == 3){
                    break; //user has guessed 3 times, they lose!
                }
                Console.Write("Enter your guess(" + (3-guess_count) + " guesses remaining): ");
                guess = Console.ReadLine(); //filling guess var w/ user input
                guess_count++;
            }while (guess != secretWord);

            //displays result from game
            if(guess == secretWord){
                Console.WriteLine("You guessed " + guess + "! You win, GJ!");
            } else {
                Console.WriteLine("Out of guesses, you lose!");
            }

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //For Loops
            Console.WriteLine("*For Loops*: ");

            int[] some_numbers = { 4 , 9 , 12, 6, 19, 2 };

            //basic for loop, iterates through integer array displaying each element
            for(int i = 0; i < some_numbers.Length; i++){
                Console.WriteLine(some_numbers[i]);
            }

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Building an exponent function
            Console.WriteLine("*Building an (integer-only) Exponent Function*: Enter a base number and power to raise to...");

            Console.Write("Enter a base number: ");
            int base_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power to be raised to: ");
            int exponent_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(base_number + " ^ " + exponent_number + " = " + GetPow(base_number, exponent_number)); //displaying end result
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //2d Arrays
            Console.WriteLine("*2d Arrays*: ");

            //declaring and populating 2d integer array statically
            int[,] numberGrid = { 
                {1, 2},
                {3, 4},
                {5, 6},
            };

            //Console.WriteLine(numberGrid[0, 0]); //referencing first value in first array element of 2d array

            for(int i = 0; i < numberGrid.GetLength(0); i++){
                for(int j = 0; j < numberGrid.GetLength(1); j++){
                    //Console.WriteLine(numberGrid.GetLength(0)); //GetLength(0) for rows
                    //Console.WriteLine(numberGrid.GetLength(1)); //GetLength(1) for columns
                    Console.WriteLine("Coordinate(" + i + ", " + j + "): " + numberGrid[i, j]);
                }
            }
            Console.ReadLine();
 

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Exception Handling
            Console.WriteLine("*Exception Handling*: Prompts for two integers then divides them if inputs are valid, catches invalid and throws error");

            //try-catch, will handle if an error that would otherwise crash the program happen in the "catch" portion(s)
            try {
                Console.Write("Enter first number: ");
                int e_num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int e_num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(e_num1 + " / " + e_num2 + " = " + (e_num1 / e_num2));

            } //can use multiple "catch"s to do different things for different errors
            catch(DivideByZeroException e) {
                Console.WriteLine("No div by 0! " + e.Message); 
            } catch(FormatException e) {
                Console.WriteLine("Format Exception! " + e.Message); 
            }catch(Exception e) {
                Console.WriteLine("Other Error, how'd you do that?! " + e.Message); 
            } finally {
                Console.WriteLine("This is demonstrating that the \"finally\" block always run, errors or not!");
            }

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Classes & Objects
            Console.WriteLine("*Classes & Objects*: ");

            //"Book.cs" class file must be in the same directory as main "Program.cs" file
            Book book1 = new Book("Bill"); //creating the object from "Book.cs" file
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine("Book1 Title: " + book1.title);
            Console.WriteLine("Book1 Author: " + book1.author);
            Console.WriteLine("Book1 Pages: " + book1.pages + "\n");

            Book book2 = new Book("Joe"); //"Book.cs" class file must be in the same directory as main "Program.cs" file
            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine("Book2 Title: " + book2.title);
            Console.WriteLine("Book2 Author: " + book2.author);
            Console.WriteLine("Book2 Pages: " + book2.pages);
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Constructors, uses Book.cs file
            Console.WriteLine("*Constructors*: ");

            Book book3 = new Book("Constructors!", "Garfield", "Jim Davis", 754); //created when declared because constructors are now built!

            Console.WriteLine("Book3 Title: " + book3.title);
            Console.WriteLine("Book3 Author: " + book3.author);
            Console.WriteLine("Book3 Pages: " + book3.pages + "\n");

            Book book4 = new Book(); //demoing empty constructor, as long as an empty constructor is set you can create empty objects

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Object Methods
            Console.WriteLine("*Object Methods*:");

            Student student1 = new Student("Billus", "Rocket Appliances", 3.1);
            Student student2 = new Student("Joe", "Being a cool guy", 3.9);

            Console.WriteLine(student1.name + " has a GPA of: " + student1.gpa + ", which is <3.5, so the \"HasHonors()\" method will return: " + student1.HasHonors());
            Console.WriteLine(student2.name + " has a GPA of: " + student2.gpa + ", which is >3.5, so the \"HasHonors()\" method will return: " + student2.HasHonors());
            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Getters and Setters
            Console.WriteLine("*Getters and Setters*: ");

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine("Movie1 Title: " + movie1.title);
            Console.WriteLine("Movie1 Director: " + movie1.director);
            Console.WriteLine("Movie1 Rating: " + movie1.Rating + "\n");

            Console.WriteLine("Movie2 Title: " + movie2.title);
            Console.WriteLine("Movie2 Director: " + movie2.director);
            Console.WriteLine("Movie2 Rating: " + movie2.Rating + "\n");

            Console.WriteLine("Changing rating on Movie1 to \"R\":");
            movie1.Rating = "R";
            Console.WriteLine("Movie1 Rating: " + movie1.Rating + "\n");

            Console.WriteLine("Changing rating on Movie1 to \"nonsense!\" (invalid):");
            movie1.Rating = "nonsense!";
            Console.WriteLine("Movie1 Rating: " + movie1.Rating);

            Console.ReadLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Static Class Attributes
            Console.WriteLine("*Static Class Attributes*: ");

            Song song1 = new Song("Holiday", "Green Day", 200);
            Song song2 = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine("Calling static class attribute \"songCount\" from the main program: " + Song.songCount); //how to call static var from outside class
            Console.ReadLine();
 

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Static Methods & Classes
            //Uses method(s) from "UsefulTools.cs" file
            Console.WriteLine("*Static Methods and Classes*: ");

            Console.Write("Calling Static Method \"SayHi(\"Billus\")\": ");
            UsefulTools.SayHi("Billus"); //using a static method from an external class w/o creating an object
            Console.ReadLine();

            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //Inheritance
            Console.WriteLine("*Inheritance*: ");

            Chef chef = new Chef(); //base class, will be inherited from ItalianChef class
            chef.MakeChicken(); 
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken(); //italianChef can use the "MakeChicken()" method from the Chef class b/c of inheritance
            italianChef.MakeSpecialDish(); //using override class


            Console.ReadLine();


        } //end main


        //Exponent function, integers only, needs modification for double/decimals because of how the for loop is checked
        static int GetPow(int base_num, int power){
            int result = 1;

            //for loop to calculate base_num ^ power
            for(int i = 0; i < power; i++){
                result *= base_num; //"result" starts at 1, so after one iteration will be the base, then loops through * by itself "power" # of times
            }

            return result;
        }

        //Switch Statements method
        static string GetDay(int dayNum){
            string dayName;

            switch (dayNum) {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                //equivalent of "else" for switch statements
                    dayName = "Invalid (0-6)";
                    break;
            }
            return dayName;
        }


        //If statement method
        static int GetMax(int num1, int num2, int num3)
        {
            //Returns largest integer from three input parameters, used statically in main method
            int result;
            if(num1 >= num2 && num1>= num3){
                result = num1;
            } else if (num2 >= num1 && num2 >= num3){
                result = num2;
            } else {
                result = num3;
            }

            return result;
        }

        //Return Statment Method
        static int cube(int num){
            //cubing parameter than returning result
            int result = num * num * num;
            return result;
        }

        //Methods example
        static void SayHi(string name, int age){
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("You are " + age + " years old!");
        }

    } //end Program

}
