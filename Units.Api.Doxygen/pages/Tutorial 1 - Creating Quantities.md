# Tutorial 1 - Creating Quantities
## Introduction
For this tutorial we will go through the basic creation and manipulation of quantities through a simple project. In this project, we will calculate projectile motion but using quantities to add additional type-safety to our algorithms. The whole tutorial's source code is available within the project's github repository. 

## Project Set-Up
Before starting this tutorial, make sure that you have installed the [.Net Core](https://dotnet.microsoft.com/download) toolchain which is required to build this project. After install, you may need to restart your computer or refresh your terminal session in order to get access to the `dotnet` command. 

Open a new terminal session. This will be the powershell program on windows and something like bash for linux. In your terminal you can use the following 3 commands to create a new project directory and initialize a new C# console application within the directory.

```sh
mkdir ProjectileMotion
cd ProjectileMotion
dotnet new console
```

This will create an empty C# project consisting of a project file and a blank C# source code file. Additionally you will have to make sure that you are using a dotnet core version greater than 3.0 as that is the minium version supported by Nautilus. To check this open your `*.csproj` file, which is an xml file, and check that the `TargetFramework` is set to `netcoreapp3.0` as seen below.  

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.0</TargetFramework>
    <RootNamespace>Tutorial_1</RootNamespace>
  </PropertyGroup>

</Project>
```

Additionally you will need to add Nautilus as a dependency to this project in order to use it. To add Nautilus to the project simply download it and install it via the instructions located on the [Downloads](/downloads) page. Once Nautilus is installed, open `Program.cs` in your favorite code editor. The file should contain some C# code already similar to the following code snippet. 

```cs
using System;

namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

## Mathematical Principles
Projectile motion is a form of motion experienced by an object that is propelled at or near the surface of the Earth and as such moves along a curved path under the influence of gravity. In most cases, the effects of air resistance are usually assumed to be negligible and are ignored. 

Projectiles start with some velocity which can be expressed as a vector quantity with components along the X and Y axis
$$
\hat{V_0} = V_0\hat{X} + V_0\hat{Y}
$$
However, most problems simply provide an initial speed and a launch angle rather than a velocity vector so we will use that instead. In this case, the X and Y components can be computed from this information using the following formulae.
$$
|V_0\hat{X}| = |V_0|cos(\theta)
$$
$$
|V_0\hat{Y}| = |V_0|sin(\theta)
$$
In these equations, the speed is usually measured in Metres/Second and the angle is measured in radians. 

From this initial state, we can apply gravity to be able to determine the object's position at any given instance in time simply by applying some basic kinematics equations, the kind taught in high school physics.

Along the X axis, since we are neglecting air resistance, the position of the object along that axis can be computed by multiplying the speed along the X axis to the amount of time that has passed.
$$
X = |V_0\hat{X}| \times t
$$

The Y axis is a little more complicated. Along the Y axis we also have the application of gravity which pulls the object in a curved path. The following formula will take into account the initial vertical speed as well as the acceleration due to gravity which is measured in Metres/Second<sup>2</sup>.
$$
Y = |V_0\hat{Y}| \times t - (1/2) \times g \times t^{2}
$$

## From Math To Code
With the mathematical background out of the way, we can start to write the application. At the top of the project we need to add references to the Nautilus units that we will be needing.

```cs
using System.Units;                     // Bring in measured quantities
using System.Units.Time;                // Bring in seconds
using System.Units.Length;              // Bring in metres
using System.Units.Velocity;            // Bring in m/s
using System.Units.Acceleration;        // Bring in m/s^2
using System.Units.Angle;               // Bring in radians
```

Next let us add a class for simulating projectile motion problems. 

```cs
public class Projectile {
    public Projectile() {
        
    }
}
```

We will add our initial projectile motion conditions such as the initial speed and the launch angle as properties of this class. Our speed components will be measured in Metres/Second<sup>2</sup> and our angle will be measured in radians just like in the mathematical formulation above. However, besides just units, we also need to know what type of value is being measured. Since we are dealing with real values we will be measuring doubles. To represent this, we will use the `Quantity<double, Unit>` type where unit is the unit in which the quantity is measured in. 

```cs
public class Projectile {
    
    // Initial Horizontal Speed
    public Quantity<double, MetrePerSecond> Vx { get; private set; }
    // Initial Vertical Speed
    public Quantity<double, MetrePerSecond> Vy { get; private set; }
    // Initial Angle 
    public Quantity<double, Radians> LaunchAngle { get; private set; }

}
```

Let us create a constructor that takes in the launch angle and initial speed and will compute each of the velocity components as per the previously discussed equations. 

```cs
public Projectile(Quantity<double, MetrePerSecond> speed, Quantity<double, Radians> angle) {
    this.LaunchAngle = angle;
    this.Vx = new Quantity<double, MetrePerSecond>(speed.Value * Math.Cos(angle.Value));
    this.Vy = new Quantity<double, MetrePerSecond>(speed.Value * Math.Sin(angle.Value));
}
```

Now we will create an indexer which will allow us to obtain the position of the projectile after any given time. To do this we will need to add a reference to `System.Numerics` in order to access the vector type. 

```cs
using System.Numerics;
```

```cs
public static readonly Quantity<double, MetrePerSecondSq> g = new Quantity<double, MetrePerSecondSq>(9.8);

public Quantity<Vector2, Metre> this[Quantity<double, Second> t] {
    get {
        double xt = this.Vx.Value * t.Value;
        double yt = this.Vy.Value * t.Value - (0.5) * g.Value * (t.Value * t.Value);

        return new Quantity<Vector2, Metre>(new Vector2((float)xt, (float)yt));
    }
}
```

## Testing

We can now write some code into the `main` method to test our projectile motion code. 

```cs
static void Main(string[] args) {
    Projectile p1 = new Projectile(new Quantity<double, MetrePerSecond>(12), new Quantity<double, Radians>(0.78));

    var PositionAt1s = p1[new Quantity<double, Second>(1)];
    var PositionAt2s = p1[new Quantity<double, Second>(2)];

    Console.WriteLine(PositionAt1s);
    Console.WriteLine(PositionAt2s);
}
```

## More Readability
Well now we have a projectile motion, and we limited the algorithms in it to only accept quantities of the given types. However this has added a lot of code that is not all that readable. In this section we will look at ways to clean up the code and make it a lot more visually appealing.

First we will talk about type aliases. Type aliases allow us to create a shorthand for types we commonly use but are very annoying to write out each time due to their length. In this way we can replace types such as `Quantity<double, Second>` with `SecondsType` and so on. Add the following to the aliases to your project and replace all instances where you use the original type.

```cs
using SecondsType = System.Units.Quantity<double, System.Units.Time.Second>;
using SpeedType = System.Units.Quantity<double, System.Units.Velocity.MetrePerSecond>;
using AccelerationType = System.Units.Quantity<double, System.Units.Acceleration.MetrePerSecondSq>;
using AngleType = System.Units.Quantity<double, System.Units.Angle.Radians>;
using PositionType = System.Units.Quantity<System.Numerics.Vector2, System.Units.Length.Metre>;
```

You should notice that after replacing all the original references with the new ones, the code has become much simpler and cleaner. However, we can still do better in Nautilus. Let us get rid of the pesky instantiations such as `new SpeedType(12)`. These are readable, but not often clear as to what they mean. Luckily, in Nautilus, most units come with extension methods which allow them to be instantiated by using the symbol of the unit you want to measure in.

For instance:

```cs
new SpeedType(12)
```

becomes
```cs
12.0.m_s2();
```

Replacing all our instantiations with uses of these extension methods leads to much cleaner code. 

```cs
using System;
using System.Numerics;
using System.Units;
using System.Units.Time;
using System.Units.Length;
using System.Units.Velocity;
using System.Units.Acceleration;
using System.Units.Angle;

using SecondsType = System.Units.Quantity<double, System.Units.Time.Second>;
using SpeedType = System.Units.Quantity<double, System.Units.Velocity.MetrePerSecond>;
using AccelerationType = System.Units.Quantity<double, System.Units.Acceleration.MetrePerSecondSq>;
using AngleType = System.Units.Quantity<double, System.Units.Angle.Radians>;
using PositionType = System.Units.Quantity<System.Numerics.Vector2, System.Units.Length.Metre>;

namespace Tutorials.Tutorial1 {
    public class Projectile {
        
        public SpeedType Vx { get; private set; }
        public SpeedType Vy { get; private set; }
        public AngleType LaunchAngle { get; private set; }

        public Projectile(SpeedType speed, AngleType angle) {
            this.LaunchAngle = angle;
            this.Vx = (speed.Value * Math.Cos(angle.Value)).m_s();
            this.Vy = (speed.Value * Math.Sin(angle.Value)).m_s();
        }

        public static readonly AccelerationType g = 9.8.m_s2();

        public PositionType this[SecondsType t] {
            get {
                double xt = this.Vx.Value * t.Value;
                double yt = this.Vy.Value * t.Value - (0.5) * g.Value * (t.Value * t.Value);

                return (new Vector2((float)xt, (float)yt)).m();
            }
        }

    }

    public class Program {
        public static void Main(string[] args) {
            Projectile p1 = new Projectile(12.0.m_s(), 0.78.rad());

            var PositionAt1s = p1[1.0.s()];
            var PositionAt2s = p1[2.0.s()];

            Console.WriteLine(PositionAt1s);
            Console.WriteLine(PositionAt2s);
        }
    }
}
```