Console.WriteLine("Simula Soup Making");
//string user;

// Named tuple
(Base soup, Main_Ingredient ingre, Seasoning season) SoupType = GetSoup();
Console.WriteLine($"{SoupType.soup}, {SoupType.ingre}, {SoupType.season}");

// Unamed tuple
// (Base, Main_Ingredient, Seasoning) SoupType = GetSoup();
// Console.WriteLine($"{SoupType.Item1}, {SoupType.Item2}, {SoupType.Item3}");

Console.WriteLine(SoupType);

// Function to get the complete soup
(Base, Main_Ingredient, Seasoning) GetSoup()
{
    Base SoupType = GetSoupType();
    Main_Ingredient ingre = GetIngre();
    Seasoning seasoning = GetSeasoning();
    return (SoupType, ingre, seasoning);
}

// Pick a base from enum Base
Base GetSoupType()
{
    Console.WriteLine("Pick a soup type: soup, stew, gumbo");
    string user = Console.ReadLine().ToLower();
    if (user == "soup")
    {
        return Base.Soup;
    }
    else if (user == "stew")
    {
        return Base.Stew;
    }
    else if (user == "gumbo")
    {
        return Base.Gumbo;
    }
    else
    {
        Console.WriteLine("Default is Soup.");
        return Base.Soup;
    }
}

// Pick an ingredient from enum Main_Ingredient
Main_Ingredient GetIngre()
{
    Console.WriteLine("Pick an ingredient: Mushroom, Chicken, Carrots, Potatoes");
    string user = Console.ReadLine().ToLower();
    if (user == "mushroom")
    {
        return Main_Ingredient.Mushroom;
    }
    else if (user == "chicken")
    {
        return Main_Ingredient.Chicken;
    }
    else if (user == "carrots")
    {
        return Main_Ingredient.Carrots;
    }
    else if (user == "potatoes")
    {
        return Main_Ingredient.Potatoes;
    }
    else
    {
        Console.WriteLine("Default is Mushrooms.");
        return Main_Ingredient.Mushroom;
    }
}

// Pick a seasoning from enum Seasoning
Seasoning GetSeasoning()
{
    Console.WriteLine("Pick a seasoning: Spicy, Salty, Sweet");
    string user = Console.ReadLine().ToLower();
    if (user == "spicy")
    {
        return Seasoning.Spicy;
    }
    else if (user == "salty")
    {
        return Seasoning.Salty;
    }
    else if (user == "sweet")
    {
        return Seasoning.Sweet;
    }
    else
    {
        Console.WriteLine("Default is Sweet.");
        return Seasoning.Sweet;
    }
}

enum Base { Soup, Stew, Gumbo}
enum Main_Ingredient { Mushroom, Chicken, Carrots, Potatoes}
enum Seasoning { Spicy, Salty, Sweet}