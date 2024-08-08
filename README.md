# Animal Zoo Simulator
This project simulates a zoo with different types of animals.

## This C# console application demonstrates object-oriented programming concepts. It includes:

**1. An abstract Animal class with properties and methods for common animal characteristics.**

**2. Concrete Dog, Frog, and Cat classes inheriting from Animal with specific implementations.**

**3. Interfaces ILand and IWater for defining land and water-based animal characteristics.**

**4. A InitAnimal function to populate a zoo with various animals based on a given pattern.**

**5. A TestAnimal function to display information about each animal in the zoo.**

## How to Use
Compile the code: Compile the C# code into an executable file.

Run the executable: Execute the compiled program.

The program will create a zoo with a mix of dogs, frogs, and cats and display information about each animal, including:

 * Greeting messages based on mood

 * Mammal and carnivorous status

 * Number of legs for land animals

 * Gill and egg-laying information for water animals

## Code Structure
The code is organized into multiple files:

 * Program.cs: Contains the main program logic, including the InitAnimal and TestAnimal functions.
 * Animal.cs: Defines the abstract Animal class.
 * Dog.cs: Defines the Dog class.
 * Frog.cs: Defines the Frog class.
 * Cat.cs: Defines the Cat class.
 * ILand.cs: Defines the ILand interface.
 * IWater.cs: Defines the IWater interface.

## Changing an Animal's Mood and Responses

The Animal class in this project incorporates a mood property that can be set to different values to influence how the animal responds. The available moods are:

**MOOD_HAPPY:** Indicates a happy state.

**MOOD_SCARE:** Indicates a scared state.


#### Set the mood property:
Use the mood property to assign a new mood value.

For Example:

    ```myDog.mood = Animal.MOOD_SCARE;```
    
**How the animal responds:**

The SayHello method in each animal class determines the specific response based on the current mood. For example, in the Dog class:

**MOOD_HAPPY:** The dog will "bark loudly".

**MOOD_SCARE:** The dog will "whoop".

**Other moods:** The dog will "wag its tail".

**Customizing Responses:**

To customize the responses for different moods or to add new moods, you can modify the **SayHello** method in the respective animal classes.

For instance, you could add a **MOOD_ANGRY** mood and define a corresponding response.

## Additional Notes
The **InitAnimal** function fills a zoo array with animals based on a specific pattern: every third animal is a dog, every second is a frog, and others are cats.
The **TestAnimal** function iterates through the zoo array and displays information about each animal.

This project serves as a basic example of object-oriented programming concepts and can be extended with additional animal types and features.

Enjoy!
