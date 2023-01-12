// Programm One

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
float Days = Seconds / 86400;
int Years = Seconds / 31536000;

Console.WriteLine(Seconds + " seconds is " + Minutes + " minutes");
Console.WriteLine(Seconds + " seconds is " + Hours + " hours");
Console.WriteLine(Seconds + " seconds is " + Days + " days");
Console.WriteLine(Seconds + " seconds is " + Years + " years");

Console.ReadLine();



