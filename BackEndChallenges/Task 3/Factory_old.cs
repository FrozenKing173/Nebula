
/// <summary>
/// The last task is about refactoring of code. Below you are given a class that creates robots and cars, this class uses a robot service, a part service, and a car service, which can be any web services (RESTful or SOAP).
/// You need to refactor this class as you see fit. The goal is to make the class more maintainable. You should apply any principles or patterns you think are necessary.
/// Don't write out the web service classes. Assume they have an implementation and you are just consuming them.
/// Bonus: what can be done to reduce tight coupling in a class?
/// </summary>
// Personal note: This is the original class
public class Factory
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;
    
    public Factory(RobotService robotService, PartsService partsService)
    {
        _robotService = new RobotService();
        _partsService = new PartsService();
        _carService = new CarService();
    }

    public Robot BuildRobot(Enum RobotType)
    {
        if(RobotType == RoboticDog)
            var parts = GetRobotPartsFor(RoboticDog);
            return _robotService.BuildRobotDog(parts);
        else if(RobotType == RoboticCat)
            var parts = GetRobotPartsFor(RoboticCat);
            return _robotService.BuildRobotCat(parts);
        else if(RobotType == RoboticDrone)
            var parts = GetRobotPartsFor(RoboticDrone);
            return _robotService.BuildRobotDrone(parts);
        else if (RobotType == RoboticCar)
            var parts = GetRobotPartsFor(RoboticCar);
            return _robotService.BuildRobotCar(parts);
        else
            return null;
    }

    public Car BuildCar(Enum CarType)
    {
        if(CarType == Toyota)
            var parts = GetCarPartsFor(Toyota);
            return _carService.BuildCar(parts);
        else if(RobotType == Ford)
            var parts = GetCarPartsFor(Ford);
            return _carService.BuildCar(parts);
        else if(RobotType == Opel)
            var parts = GetCarPartsFor(Opel);
            return _carService.BuildCar(parts);
        else if (RobotType == Honda)
            var parts = GetCarPartsFor(Honda);
            return _carService.BuildCar(parts);
        else
            return null;
    }

    public List<Parts> GetRobotPartsFor(Enum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    public List<Parts> GetCarPartsFor(Enum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}