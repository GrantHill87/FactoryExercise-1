using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public interface IVehicle //our contract basis; for any class that is derived from this interface base, they must conform to its behavior (think of it as a blueprint).
    {
        void Operation();//what else do we want our interface to do? Let's throw out another stubbed out method, that now has to be implemented by classes inheriting from it.
        void Drive(); //derived class must implement a 'Drive' method, per the 'contract agreement' of this interface base class it is inheriting from. If we didn't create something here, within the scope of the interface class, IVehicle, then it lacks its own behavior, and therefore has no use until given aforementioned behavior. This behavior could be defined by properties as well, remember, and not just stubbed out methods.
    }//we created a stubbed out method for 'Drive'; because we wanted our interface to care about how the vehicle is driving. Sounds weird in a sense, doesn't it? This is important because when making
}//other vehicle types, say in the form of derived class from this base class, it gives us as the viewer an idea of differentiation between different vehicle types. In other words, a car doesn't necessarily 'drive' like a motorcyle.
