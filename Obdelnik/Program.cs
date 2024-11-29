



































namespace MyApp{

    class Program
    {
        static void Main(string[] args)
  {
    Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)

    Car Skoda = new Car("Karoq", "nafta");

    Console.WriteLine(Ford.model);  // Print the value of model
     Console.WriteLine(Skoda.model + " " + Skoda.palivo);
    }
    }
    
    class Car
{
  public string model;  // Create a field
  public string palivo;

  // Create a class constructor for the Car class
  public Car()
  {
    model = "Mustang"; // Set the initial value for model
  }

  public Car(string model_par)
  {
    this.model = model_par; // Set the initial value for model
  }
    public Car(string model, string palivo)
  {
    this.model = model; // Set the initial value for model
    this.palivo = palivo;
  }
  
}

}

