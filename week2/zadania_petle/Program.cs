// Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100

using System.Dynamic;

int primeNumbers = 0;

for  (int i = 2; i<= 100; i++) 
{
    int dividers = 0;

    for (int j = 1; j <= i; j++) 
    {
        if (i % j == 0) 
        {
            dividers++;
        }
    }
    if (dividers <= 2) 
    {
        primeNumbers++;
        Console.WriteLine("Znalazłem liczbę pierwszą: " + i);
    }
}
Console.WriteLine("\nZnaleziono " +  primeNumbers + " liczb pierwszych.");

// Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
// zakresu 0 – 1000

int number = 0;
Console.WriteLine("\nLiczby parzyste:");
do
{
    Console.Write($"{number}, ");
    number += 2;
} while (number < 1001);

// Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
int fMinusOne = 1;
int fMinusTwo = 0;
int nextFib = 0;

Console.Write("\n\nCiag Fibonacciego:" + fMinusTwo + ", " + fMinusOne + ", ");

while (nextFib <= 100) 
{
    nextFib = fMinusOne + fMinusTwo;
    Console.Write(nextFib + ", ");
    fMinusTwo = fMinusOne;
    fMinusOne = nextFib;
}

/* Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
liczby w formie jak poniżej:
1
2 3
4 5 6
7 8 9 10 */

Console.WriteLine("\n\nPodaj liczbę do wygenerowania piramidy:");
string pyramidNumber = Console.ReadLine();
int pyramidNumberInt;
Int32.TryParse(pyramidNumber, out pyramidNumberInt);
Console.WriteLine();

int pyrNumber = 1;
int counter = 1;
while (counter <= pyramidNumberInt) 
{
    for (int i = 1; i <= pyrNumber; i++) 
    {
        if (counter <= pyramidNumberInt) 
        {
            Console.Write($"{counter} ");
            counter++;
        }
    }
    Console.WriteLine();
    pyrNumber++;
}

// Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

Console.WriteLine("\nPotęgi ^3 dla liczb od 1 do 20:\n");

for (int i = 1; i <= 20; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"{i}^3 = {cube}");
}

// Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
// 1 + 1/2 + 1/3 + 1/4 itd.

Console.WriteLine("\nSumy ułamkowe 1 + 1/2 + 1/3 + 1/4 itd. :\n");

for (double i = 0; i <=20.0; i++) 
{
    double sum = 0;
    for (double j = 1.0; j <= i; j++) 
    {
        sum = sum + 1 / j;
    }
    Console.WriteLine($"Suma ułamkowa dla {i} = {Math.Round(sum, 3)}");
}

/* Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    * 
*/

Console.WriteLine("Podaj długość krótszej przekątnej diamentu (liczba nieparzysta!): ");
string diamond = Console.ReadLine();
int diamondNum;
Int32.TryParse(diamond, out diamondNum);

if (diamondNum % 2 == 1 && diamondNum > 0)
{
    for (int i = 1; i <= diamondNum; i += 2)
    {
        int stars = i;
        int spaces = (diamondNum - i) / 2;

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < stars; k++)
        {
            Console.Write("*");
        }
        for (int l = 0; l < spaces; l++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    for (int i = diamondNum - 2; i >= 1; i -= 2)
    {
        int spaces = (diamondNum - i) / 2;
        int stars = i;

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < stars; k++)
        {
            Console.Write("*");
        }
        for (int l = 0; l < spaces; l++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Podana liczba jest nieprawidłowa!");
}

/* Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
Testowe dane:
Abcdefg
Rezultat
Gfedcba
*/

Console.Write("Wpisz słowo do odwrócenia: ");
string word =  Console.ReadLine();

string reversedWord = "";
for (int letter = word.Length - 1; letter >= 0; letter--) 
{
    reversedWord += word[letter];
}
Console.WriteLine($"Twoje odwrócone słowo to: {reversedWord}");

// Napisz program, który zamieni liczbę dziesiętną na liczbę binarną

Console.Write("Wpisz liczbę do przeliczenia na system dwójkowy: ");
string decimalNum = Console.ReadLine();
int decimalNumInt;
Int32.TryParse(decimalNum, out decimalNumInt);


string numStringRev = "";
while  (decimalNumInt > 0) 
{
    int numRest = decimalNumInt % 2;
    numStringRev += numRest;
    decimalNumInt /= 2;
}

// odwrócenie stringa

string decimalNumber = "";
for (int letter = numStringRev.Length - 1; letter >= 0; letter--)
{
    decimalNumber += numStringRev[letter];
}
Console.WriteLine($"W postaci binarnej to: {decimalNumber}");


// Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb

Console.Write("Liczymy najmniejszą wspólną wielokrotność. Wpisz 1 licznę: ");
string numberOne = Console.ReadLine();
int numberOneInt;
Int32.TryParse(numberOne,out numberOneInt);

Console.Write("Wpisz 2 licznę: ");
string numberTwo = Console.ReadLine();
int numberTwoInt;
Int32.TryParse(numberTwo, out numberTwoInt);

// 1. największy wspólny dzielink
int nwd = 1;

for (int i=2; i < numberOneInt; i++) 
{
    if (numberOneInt % i == 0 && numberTwoInt % i == 0) 
    {
        nwd = i;
    }
}

// 2. nww

int nww = numberOneInt * numberTwoInt / nwd;

Console.WriteLine($"Najmniejsza wspólna wielokrotność {numberOneInt} i {numberTwoInt} to {nww}");