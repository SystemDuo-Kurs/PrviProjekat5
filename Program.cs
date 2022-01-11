//Jednolinijski komentar

/*
 *
 * viselinijski komentar
 */

//Celi brojevi
byte bajt = 255; //0-255
sbyte sBajt = 127; //-128, 127

int broj;
broj = 2147483647;
uint brojBezZnaka; //u kao unsigned
brojBezZnaka = 4_000_000_000;

long velikiBroj;
ulong velikiBrojBezZnaka;

//Brojevi sa ostatkom
float f; //kuliramo ga vecinu vremena

double d = 5.5; //standardni
decimal dd; //ultra precizan, obavezno ga koristimo kada je novac u pitanju

bool Istina = true;
Istina = false;

Console.WriteLine(5 + 7);
Console.WriteLine("Sabiranje: " + (5 + 7));

Console.WriteLine("Ovo je samo primer :D");
Console.WriteLine("Maksimalni int:" + int.MaxValue);
Console.WriteLine("Minimalan int:" + int.MinValue);
Console.WriteLine("Velicina inta je " + sizeof(int) + " bajta");

Console.ReadKey();