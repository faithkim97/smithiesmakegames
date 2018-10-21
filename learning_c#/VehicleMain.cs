using System; //package we import by default

/*
  This class contains the main method. This main method
  is supposed to show how Vehicle class can be implemented by
  creating two Vehicle objects
*/
public class VehicleMain {

    public static void Main(string[] args) {
      //instantiates a Vehicle object that is a car with 4 wheels with color pink
      Vehicle car = new Vehicle(4, "car", "pink");
      //instantiates a Vehicle object that is a truck with 6 wheels with color red
      //due to the default values we gave the fields with the Vehicle() constructor
      Vehicle truck = new Vehicle();

      System.Console.WriteLine("This vehicle is a " + car.getVehicleType() + " that has " +
                        car.getNumWheels() + " wheels and the color is " + car.getColor() );

      System.Console.WriteLine("This vehicle is a " + truck.getVehicleType() + " that has " +
                    truck.getNumWheels() + " wheels and the color is " + truck.getColor());
    }

}

/*
The print statements in the main method will print out the following:

This vehicle is a car that has 4 wheels and the color is pink
This vehicle is a truck that has 6 wheels and the color is red

*/
