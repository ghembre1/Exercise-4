// See https://aka.ms/new-console-template for more information

// Asks user the length of rectangle
Console.Write("Enter the length of the rectangle: ");

// Makes the length be a number
double length = Convert.ToDouble(Console.ReadLine());

// Get width from the user
Console.Write("Enter the width of the rectangle: ");

// Makes the area be a number
double width = Convert.ToDouble(Console.ReadLine());

// Calculates the area of the rectangle
double area = length * width;

// Calculates the perimeter of the rectangle
double perimeter = 2 * (length + width);

Console.WriteLine("Results:");
// Both of these lines shows the results for the area and perimeter
Console.WriteLine($"Area of the rectangle: {area}");
Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
