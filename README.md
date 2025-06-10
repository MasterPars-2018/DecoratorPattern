# MacBook Decorator Pattern Example

This is a simple C# project demonstrating the **Decorator Design Pattern** using a MacBook customization example.

---

## Overview

The **Decorator Pattern** is a structural design pattern that allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class.

In this project, we simulate customizing a MacBook by adding options such as extra RAM, larger SSD, and AppleCare protection.

---

## Project Structure

- **IMacBook**: Interface defining MacBook properties and methods.
- **BaseMacBook16Ram256SSD**: The base MacBook implementation with 16GB RAM and 256GB SSD.
- **MackBookDecorator**: Abstract decorator class implementing `IMacBook` and wrapping an `IMacBook` instance.
- **MacBookWithAppleCare**: Decorator that adds AppleCare+ protection.
- **MacBook512SSD**: Decorator that adds 256GB more SSD storage.
- **MacBook24RAM**: Decorator that adds 8GB more RAM.

---

## How to Use

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build the solution.
4. Run the project.
5. The console will display different MacBook configurations with their specs and prices.

---

## Example Code

```csharp
IMacBook macBook16Ram256SSD = new BaseMacBook16Ram256SSD();
IMacBook macBook16Ram512Sdd = new MacBook512SSD(macBook16Ram256SSD);
IMacBook macBook24Ram512Sdd = new MacBook24RAM(macBook16Ram512Sdd);
IMacBook macBook24Ram512SddWithAppleCare = new MacBookWithAppleCare(macBook24Ram512Sdd);

Console.WriteLine(macBook16Ram256SSD);
Console.WriteLine(macBook16Ram512Sdd);
Console.WriteLine(macBook24Ram512Sdd);
Console.WriteLine(macBook24Ram512SddWithAppleCare);
