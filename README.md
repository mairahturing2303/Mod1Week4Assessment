# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    
    C does not create an instance of a chair. It doesn't include the keyword chair so it cant be accessed or used as chair.
    
 
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
 Object priented programming is an efficient way to organize code that makes it so you can access specific instances of objects. It helps you to clearly define what the object you are programming needs in order to be considered an object. It gives it a specific roll as well as specific propertys.
 
3. What is Automated Testing?
Automated testing helps you to see if your code is functioning. You can test your code to see if it runs as a whole. It helps you to see if your code is also executing the way that you want it to. For example, if youre making a calculator making sure that 6 + 6 is 12 and not something else.

4. What are some benefits of creating tests for our projects?

Creating tests for our code helps us to see exactly where the problem is in our code and the reason it is not working.

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
Make sure the classes are public

(public class)

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#

TestVehicle
TestSummaryColorToWheel
TestDriveNumber
TestPaintColor




    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```



## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
