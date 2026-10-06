using CarLibrary;

var engine = new Engine(4, 210);
var car = new Car("Ford", "Fiesta", 2016, engine);

car.Drive();
car.Stop();
