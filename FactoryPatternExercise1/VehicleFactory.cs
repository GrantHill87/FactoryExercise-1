using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FactoryPatternExercise1 //static classes don't have instances of themselves, they just do stuff.
{ //it was not necessary to make our factory class a static type. Doing so, in the case of how all of these classes have been written, would result in obnoxious errors on the main script.
    public class VehicleFactory //this is our factory! This is where we take what the interface class is instructing, and we give it specificity -- an efficient way of doing what it already does, but now within determined circumstrances (as implemented by the switch format below).
    { //previously, the method written below had 'void' listed as its return value; it has now gotten its return value changed to the interface class, 'IVehicle'. If we left it with a void return type, we wouldn't be able to return anything.
        public IVehicle CreateVehicle(string userInput) //we create the parameter, expressed as a string, of 'userInput'; where we have already defined this variable, in the main script, to take in put from the user,
        { //by way of utilizing, Console.ReadLine();.
            switch (userInput.ToLower()) //initially, this was written within the scope of the main script, but seeing as we needed to craft multiple objects of the same type, thought it better to cut and paste it
            { //into the scope of a method we define in our 'Factory' script.
                case "car": //it's imperative to implement the dot notation function of '.ToLower' so that no matter what the user's repsonse may be, utilization of capital letters makes no difference.
                    return new Car() { Color = "Green", IsDriveable = true}; //we need to find a way to have any vehicle type we make to be returned, without conflicting with other vehcile types --  to do this, the implementation of interface based classes would be ideal.
                    //break; //break only needs to be implemented where there is no return being written in the code, as utilization of 'return' essentially performs the same function of 'break', in this context.
                case "motorcycle":
                    return new Motorcycle() { Color = "Blue", HasHandBrake = false};
                //Motorcycle newMotorcycle = new Motorcycle(); //case is returning a new Motorcycle. The problem here is that while a new motorcycle is being made, it isn't necessarily being maintained or kept, just trashed virtually
                //break; // as soon as it has been created. Whereas if we elect to 'return' a new motorcycle, then we eliminate that issue.
                case "truck": //we created a method within our factory that is functioning based off of input written into IVehicle, because IVehicle is expressed in the method's, 'CreateVehicle', return type.
                    return new Truck() { Color = "Red", SnowReady = true};
                case "boat":
                    return new Boat() { Color = "Yellow", WaterOnly = true };
                default:
                    return null; //if user refuses to select from given options, default will return a value of null, no value.
                    //Console.WriteLine("Ho, ho; no car for you!"); //couldn't write this in for the return value -- some error regarding no return needed for void based returns.
                    //break; //the CreateVehicle method will keep having errors at runtime if we don't express a return here -- keeps suggesting that not all code paths return a value. Seems like it wants us to 'return' something.
                    
            }
        }
    public IVehicle GetVehicle(int countOfWheels) //we call this method per the requirement of the assignment from class, as a means of determining what vehicle will be created based upon # of wheels it has.
        {
            //Loop:
            switch (countOfWheels)
            {
                case 1:
                    return new Boat(); //boat has one wheel.
                case 2:
                    return new Motorcycle(); //motorcycle has two wheels.
                case 3:
                    return new Truck(); //truck has three wheels.
                case 4:
                    return new Car(); //car has four wheels.
                default:
                    return null;
                   // Console.WriteLine("Select a valid option.");
                    //goto Loop; //tried writing a goto function with the use of loop -- in an attempt to keep iterating this switch function's scope over and over again until an appropriate reponse from the user
            } //was written in.
        }
    }
}
