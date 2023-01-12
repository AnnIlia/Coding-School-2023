// Programm One

using System;
using System.Globalization;

string hello = "Hello";
string name = "Anna";

Console.WriteLine(hello + " " + name);


// Programm Two
int numberA = 6;
int numberB = 3;

int Sum = numberA + numberB;
int Division = numberA / numberB;

Console.WriteLine("Sum = " + Sum + "     " + "Division = " + Division);


// Programm Three

int OneBoulet = -1 + 5 * 6;
int TwoBoulet = 38 + (5 % 7);
int ThreeBoulet = 14 + ((-3 * 6) / 7);
int FourBoulet = (int)(2 + (13 / 6) * 6 + Math.Sqrt(7));
int FiveBoulet = (int)((((Math.Pow( 6, 4)) + (Math.Pow( 5, 7))) / (9 % 4)));

Console.WriteLine("The 1st result is: " + OneBoulet);
Console.WriteLine("The 2nd result is: " + TwoBoulet);
Console.WriteLine("The 3rd result is: " + ThreeBoulet);
Console.WriteLine("The 4th result is: " + FourBoulet);
Console.WriteLine("The 5th result is: " + FiveBoulet);


// Programm Four

ushort Age = 24;
string Gender = "female";

Console.WriteLine("You are " + Gender + " and look younger than " + Age);


// Programm Five 

int Seconds = 45678;

int Minutes = Seconds / 60;
int Hours = Seconds / 3600;
float Days = Seconds / (float)86400;
float Years = Seconds / (float)31536000;

Console.WriteLine(Seconds + " seconds is " + Minutes + " minutes");
Console.WriteLine(Seconds + " seconds is " + Hours + " hours");
Console.WriteLine(Seconds + " seconds is " + Days + " days");
Console.WriteLine(Seconds + " seconds is " + Years + " years");


// Programm Six

TimeSpan t = TimeSpan.FromSeconds(45678);
string time = string.Format(
      CultureInfo.CurrentCulture,
      "{0} minutes \n{1} hours \n{2} days \n{3} years",
      t.TotalMinutes,
      t.TotalHours,
      t.TotalDays,
      t.TotalDays / 365  )    ;
Console.WriteLine(time);


// Programm Seven

int Celsius = 38;

float Kelvin = Celsius + (float)273.15;
float Fahrenheit = Celsius * (float)1.8 + 32;

Console.WriteLine(Celsius + " celsius is " +  Kelvin + " kelvin");
Console.WriteLine(Celsius + " celsius is " + Fahrenheit + " fahrenheit");


Console.ReadLine();