/*
Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow
them to enter their current holdings and compute a point total.
Objectives:
• Create a program that allows users to enter how many provinces, duchies, and estates they have.
• Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
• Display the point total to the user
 */

Console.Write("Number of provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of duchies: ");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of estates: ");
int estates = Convert.ToInt32(Console.ReadLine());

// 6 points per province
int pScore = provinces * 6;

// 3 points per duchies
int dScore = duchies * 3;

// 1 point per estate
int eScore = estates * 1;

int totalScore = pScore + dScore + eScore;

Console.WriteLine($"The number of points the user have are {totalScore}");