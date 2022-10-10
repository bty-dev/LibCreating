using CarActions;

Car car = new Car("Model s");

var name = car.getModelName();
Console.WriteLine(name);

car.openTheDoor();
car.engineStart();
