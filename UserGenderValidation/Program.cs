// See https://aka.ms/new-console-template for more information

//programm küsib sugu lähtudes mis ta valib m/f
//"Welcome Mr. ..... / Ms. ....."

using System;

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}    
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

