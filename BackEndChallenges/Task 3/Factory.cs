// The class name Factory is ambiguous 
    // This Factory creates instances of several families of classes and derived classes and is classified as an abstract factory pattern. Since The parts service is used in both the Robot services and the Car services, we can seperate it from what varies in this class, also known as a principle
    // Now we can create different derived classes based on PartAbstractFactory, which makes it more of a factory pattern and makes the 'PartsService'/'PartsAbstractFactory' more flexible in it's purpose, being open for extension and closed for modification set. But was implemented wrong intially.
    // Now this PartsFactory and PartsAbstractFactory can implement the Interface Segregation princple neatly and sexy. Because this PartsFactory implements all the methods it depends on of the PartsAbstractFactory and could easily extend methods (Interfaces/ Contracts) that could be introduced by the PartsAbstractFactory. Like implementing an IPartsQualityTests as an example
    public class PartsFactory : PartsAbstractFactory
    {
        // Just a note, all references or datatypes should be in libraries, otherwise it creates duplicate code, which increases maintainability.
        // Use Dependency Inversion principle, it states that high modules should not depend on lower modules, that objects should not depend on concreation but on abstraction.
        
        // Removed the parts Service since this class should be implemented in it's abstract class and not as a service. We want to seperate what varies and this parts service is dupilicating in this class. There is also a princple called favor composition over inheritance, but this factory is clearly an "IS A" relationship with the PartsService than a "HAS A" relationship.
        private readonly IRobotService _robotService;
        private readonly ICarService _carService;

        // remove these enums here, they should be implemented in their respective classes 'Robot' and 'Car'. Having a single responsibility class and being referenced to as a library, having it's own extension methods.
        /*enum RobotType
        {
            RoboticDog,
            RoboticCat,
            RoboticDrone,
            RoboticCar
        }

        enum CarType
        {
            Toyota,
            Ford,
            Opel,
            Honda
        }*/

        // Factory constructor is missing the ICarServiceo
        public Factory(IRobotService robotService, ICarService carService)
        {
            // Don't instantiate new instances, use dependency inversion principle, depend on abstraction, not concreation.
            _robotService = robotService;
            _carService = carService;
        }

        // RobotType is an enum and should
        public override Robot BuildRobot(RobotType robotType)
        {
            // Removing all the redundant if statements since they all do the same thing.
            var parts = GetPartsFor(RobotType.RoboticDog);
            if (parts == null)
                return null;
            return _robotService.BuildRobotDog(parts);

        }

        // Using override in BuildRobot method and BuildCar method, so that we can follow the principle depend on abstraction rather than concreation right as well as the important Liskov substitution principle, which states that a derived class should be substitutable of it's base/ parent class.
        public override Car BuildCar(CarType carType)
        {
            // Removing all the redundant if statements since they all do the same thing.
            var parts = GetPartsFor(CarType.Toyota);
            if (parts == null)
                return null;
            return _carService.BuildCar(parts);
        }

        // Local variables and parameter names should be Camel casing.
        // GetRobotPartsFor and GetCarPartsFor can be changed to GetpartsFor, since they both have Enum parameters and it's underlying code encapsulation _partService.GetParts(Enum enumType) is already an overloaded methodod. But simple clean code reads better and duplicate code is bad (classes with too much code). Hence I'm removing it.
        // I commented out the below code, because it should be removed. This can now sit in it's base class.
        /*public List<Parts> GetPartsFor(Enum type)
        {
            return _partsService.GetParts(type);
        }
        */
    }