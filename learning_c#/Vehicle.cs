using System; //package we import by default

public class Vehicle {

  //these global variables are the fields, or
  //characteristics of a Vehicle template
  //we always declare fields at the top
  private int numWheels;

  private string vehicleType;

  private string color;


  /*Constructors your user/programmer can use
  We provide two different constructor options the user/programmer
  can choose from
  In constructors, we always initialize our fields
  */
  public Vehicle(int n, string v, string c) {
    numWheels = n;
    vehicleType = v;
    color = c;
  }

  public Vehicle() {
    numWheels = 6;
    vehicleType = "truck";
    color = "red";
  }

  //accessors
  //returns the value of fields
  public int getNumWheels() {
    return numWheels;
  }

  public string getVehicleType() {
    return vehicleType;
  }

  public string getColor() {
    return color;
  }

  //manipulators
  //re-assigns the value of the fields
  public void setNumWheels(int n) {
    numWheels = n;
  }

  public void setVehicleType(string v) {
    vehicleType = v;
  }

  public void setColor(string c) {
    color = c;
  }

}
