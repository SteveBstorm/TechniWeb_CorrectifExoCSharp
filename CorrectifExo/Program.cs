
/*Raccourci Région : ctrl + k + s 
    après sélection du code à englober dans la région
 */

#region Exo 1
//int nb1, nb2;

//Console.Write("Entrez nb 1 : ");

//nb1 = int.Parse(Console.ReadLine());

//Console.Write("Entrez nb 2 : ");

//nb2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}"); 
#endregion

#region Exo2
using System.Globalization;

float nb1, nb2;

Console.Write("Entrez nb 1 : ");

nb1 = Convert.ToSingle(Console.ReadLine());

Console.Write("Entrez nb 2 : ");

nb2 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
#endregion