using System;

WorkWithIntegers();
OrderPrecedence();
WorkWithDoubles();
WorkWithRemainders();
WorkWithDecimals();

void WorkWithIntegers()
{
    // addition
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void WorkWithRemainders()
{

    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

void WorkWithDoubles()
{

    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    // double a = 19;
    // double b = 23;
    // double c = 8;
    // double d = (a + b) / c;
    // Console.WriteLine(d);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

void WorkWithDecimals()
{

    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
}

double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"Area of a circle with radius {radius} is {area}");

double length = 2.0;
double width = 3.0;
double areaOfRectangle = length * width;
Console.WriteLine($"Area of a rectangle with length {length} and width {width} is {areaOfRectangle}");
double perimeterOfRectangle = 2 * (length + width);
Console.WriteLine($"Perimeter of a rectangle with length {length} and width {width} is {perimeterOfRectangle}");
