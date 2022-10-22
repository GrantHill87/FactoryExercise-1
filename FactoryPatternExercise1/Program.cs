using System;
using System.Threading;
using System.Collections.Generic;

namespace FactoryPatternExercise1
{
    internal class Program //it will be important to implement some form of exception handling and error checking, as users will have to be 'guided' towards appropriate, 'acceptable' inputs, per the program itself.
    { //even if you provide the user with different string based options to choose from in this scenario, people can mispell something, or type in an inadvertent repsonse, in which we as the programmers, would like to
        static void Main(string[] args) //avoid having the program crash -- so we must tell the program what to do under those sorts of circumstances. I might try an if -- else statement to achieve this at the interface.
        {
            Console.WriteLine("We've built our first factory recently -- wanna know what it manufactures?? Rhetorical question, but please press the enter key when you're ready.");
            Console.ReadLine();
            Console.WriteLine();
            NumericalBasedSelection(); //what the assignment called for.
            //NumericalBasedSelectionOutro(); //no longer needed -- I found more efficient methods of achieving what it was I wanted to within this assignment.
            StringBasedSelection(); //what the assignment didn't call for, but was used by course instructors anyway.
        } //I just had to figure out a way to run them exclusively of one another, so I decided to call each assignment format as a method here in the mainscript.
        static void NumericalBasedSelection() //if TryParse was able to be implemented here, I would like to think that it could have handled other unexpected exceptions, such as an integer based checker not crashing when given a string based value.
        {

            Console.WriteLine("First, you'll need enter the number of wheels required.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Choices are limited; # spectrum range is between values of 1 - 4.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Responding with values outside of this range will result in continued program prompting.");
            Thread.Sleep(2000);
            Console.WriteLine();
            var numberOfWheels = int.Parse(Console.ReadLine()); //it is on this line that the user will have to write in their response. This is also where the program will record and store the user's input.
                                                                //couldn't use TryParse here, for some reason. Parse will only check for numbers, not strings, in case the user doesn't write in a number for a response.
            
            
                var validInput = new List<int> { 1, 2, 3, 4 }; //we have to define what our correct answers are, so our do-while checker knows what to look for.
            do //sadly, even with the combined usage of if-else statements as well as do-while ones, this script can only handle exceptions that are expressed as integers. Writing in a string based response will crash the program.
            { //I learned the hard way that integer based variables cannot be directly equated or unequated to list based ones, for example, VSC will give us an error if we wrote something like this; if (numberOfWheels == validInput). If both variables represented the same type of value, then there's no error.
                if (validInput.Contains(numberOfWheels)) //this is how we can check to see if a response from the user is within our list of correct answers. 
                { 
                    VehicleFactory automobileFactory = new VehicleFactory();
                    IVehicle yourVehicle = automobileFactory.GetVehicle(numberOfWheels);
                    Console.WriteLine();
                    Console.WriteLine($"Ok. You've selected {numberOfWheels} wheels to be installed onto your vehicle.");
                    Console.WriteLine();
                    yourVehicle.Drive(); //without the do-while and if-else statements, these two methods function properly. For some reason, they don't run when they're incorporated into the scope of those statements.
                    yourVehicle.Operation(); //weird, these methods functioned on the second go -- no changes to the script.
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid response. Try again.");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Choices are limited; # spectrum range is between values of 1 - 4.");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Responding with values outside of this range will result in continued program prompting.");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    numberOfWheels = int.Parse(Console.ReadLine()); //if we don't write this line for user input, this scope of code will keep running itself endlessly with nothing to stop it.
                } //without the do while statement implementation, the if else statement will only run once, because there's nothing to give it direction as far as reverting back to its initial prompt.
            } while (!validInput.Contains(numberOfWheels)); //this syntax, right here, was my savior. Rather than putting valid.Input.DoesNotContain, I had to write !validInput.Contain.


            //Console.ReadLine(); this part gotten taken out, as it was unnecessary.
            //bool input = false;
            //    int numberOfWheels = 0;
            //do //this is a more efficient error and exception handling script, than say if else statements. At least I thought it was.... 
            //    { //problem is, it doesn't handle exceptions as well as I thought, causing the program to terminate prematurely. The bool initializer and function didn't work at all.... it probably assumed all input values equaled true, despite the cases defined in the factory class (switch).
            //        Console.WriteLine("First, you'll need enter the number of wheels required.");
            //        Thread.Sleep(2000);
            //        Console.WriteLine();
            //        Console.WriteLine("Choices are limited; # spectrum range is between values of 1 - 4.");
            //        Thread.Sleep(2000);
            //        Console.WriteLine();
            //        Console.WriteLine("Responding with values outside of this range will result in program termination.");
            //        Thread.Sleep(2000);
            //        Console.WriteLine();
            //        input = int.TryParse(Console.ReadLine(), out numberOfWheels); //it is on this line that the user will have to write in their response. This is also where the program will record and store the user's input.
            //    } while (input == false); //this means for as long as the user inputs a response that is not defined within the cases outlined in our switch function, back out in our factory, the program will continue prompting the user again with whatever we wrote inside the scope of the do while statement.
            //Repeat:
            //    Console.WriteLine("First, you'll need to enter the number of wheels required.");
            //    Thread.Sleep(2000);
            //    Console.WriteLine();
            //    Console.WriteLine("Choices are limited; # spectrum range is between values of 1 - 4.");
            //    Thread.Sleep(2000);
            //    Console.WriteLine();
            //    Console.WriteLine("Responding with values outside of this range will result in program termination.");
            //    Thread.Sleep(2000);
            //    Console.WriteLine();
            //    int numberOfWheels = int.Parse(Console.ReadLine()); //it is on this line that the user will have to write in their response. This is also where the program will record and store the user's input.

            //    if (numberOfWheels < 1 && numberOfWheels > 4)
            //    {
            //        goto Repeat; //TrueCoders has suggested not to use goto-label statements.
            //    }

            
        }

        //static void NumericalBasedSelectionOutro()


        static void StringBasedSelection()
        {
            Console.WriteLine("So, you picked out a vehicle to be made based on how many wheels it was going to have.... strange.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Why not just pick one out? Say out of a list that's based on what's in stock, with regards to our material supplies.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Today, we're offering a nice variety of boats, cars, motorcycles.... and even trucks of the like.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("What type of vehicle would you like to create?");
            Console.WriteLine();
            string userInput = Console.ReadLine(); //remember, 'userInput' was a variable already defined in our factory (our factory class), but now it's being put to use in our main script.
            //user's input gets stored in the variable, 'userInput'. //our switch function will run that user's input against different cases we outlined for it, and will default to a null response if none of those cases match what the user wrote into the console.
            var logicalInput = new List<string> { "boat", "car", "truck", "motorcycle" };
            VehicleFactory autoFactory = new VehicleFactory(); //vehicle factory class defines new variable 'autoFactory' to initialize into a new vehicle factory type.
            IVehicle myVehicle = autoFactory.CreateVehicle(userInput); //previously, before creating the interface class, there was no variable set equal to 'autoFactory.CreateVehicle(userInput)'; it was expressed by itself.
            do //IVehicle defines what the new variable, 'myVehicle', is going to do, and is then initialized.
            { //unlike the first method, which has VehicleFactory, and IVehicle lines of code written into the scope of the if-else statement, here I had to move them outside of said scope, to another scope that encompassed them, so that the same variables could be used again withou thaving to redefine them.
                if (logicalInput.Contains(userInput)) //creating the same sort of exception handling method down here, just string based.
                {
                    Console.WriteLine();
                    Console.WriteLine($"Awesome, so you've gotten a {userInput} crafted right out the automobile factory."); //now we print what the user wrote to the console, in a manner that is clear to the user of the program.
                    Console.WriteLine();
                    //yourVehicle.Drive(); //these don't work here, perhaps because the VehicleFactory class, and the IVehicle class aren't scripted into the same scope as the methods calling from those classes.
                    //yourVehicle.Operation();
                    Console.WriteLine("Great. Now, you may craft another automobile.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Reponse. Try again");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Today, we're offering a nice variety of boats, cars, motorcycles.... and even trucks of the like.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("What type of vehicle would you like to create?");
                    Console.WriteLine();
                    userInput = Console.ReadLine(); //variable has already been announced as a string type, so it no longer needs to have string written in front of it, with its continued usage.
                }
            } while (!logicalInput.Contains(userInput));

            Console.WriteLine();
            userInput = Console.ReadLine();
            myVehicle = autoFactory.CreateVehicle(userInput);//if we use this variable again, which we are because it's redundant to create another variable that performs the same function, it is no longer necessary to type 'IVehicle' in front of the same variable because it has already been defined above, and within the same scope.
            do
            {
                if (logicalInput.Contains(userInput)) //tried to incorporate .ToLower method here, but VSC doesn't like it.
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cool. looks like you had a {userInput} built at the factory.");
                    Console.WriteLine();
                    Console.WriteLine("Alright, well that does it for today, as the factory is running low on building materials."); //wanted to print the colors and properties of the other vehicle types to the console, but didn't know how here.
                }
                else
                {
                    Console.WriteLine("Invalid repsonse. Try again.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("Today, we're offering a nice variety of boats, cars, motorcycles.... and even trucks of the like.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("What type of vehicle would you like to create?");
                    Console.WriteLine();
                    userInput = Console.ReadLine(); //I know the assignment didn't require exception handling, or having an additional method to select vehicle manufcture, but I wanted to make the most out of what I learned.
                }


            } while (!logicalInput.Contains(userInput)); //I really like this syntax. Makes my life much easier.
        }
    }
}
