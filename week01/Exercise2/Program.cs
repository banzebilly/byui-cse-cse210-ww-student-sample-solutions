// Author: Banze Billy
// I m liking c# now my focus was on python and it frameworks

Console.Write("Enter your grade percentage: ");

int grade = int.Parse(Console.ReadLine());

string letter = "";

if (grade >= 90)
{
    letter = "A";
}
else if (grade >= 80)
{
    letter = "B";
}
else if (grade >= 70)
{
    letter = "C";
}
else if (grade >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

int determineGradeSign = grade % 10;

string sign = "";

if (determineGradeSign >= 7)
{
    sign = "+";
}
else if (determineGradeSign < 3)
{
    sign = "-";
}
else
{
    sign = "";
}

if (letter == "A" && sign == "+")
{
    sign = "";
}
else if (letter == "F" && sign == "+")
{
    sign = "";
}
else if (letter == "F" && sign == "-")
{
    sign = "";
}

Console.WriteLine($"Your grade is: {letter}{sign}");

if (grade >= 70)
{
    Console.WriteLine("Congratulations! You passed the course.");
}
else
{
    Console.WriteLine("Keep working hard and try again next time.");
}