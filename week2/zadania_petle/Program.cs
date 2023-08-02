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
string pyramid_number = Console.ReadLine();
int pyramid_number_int;
Int32.TryParse(pyramid_number, out pyramid_number_int);
Console.WriteLine();

int pyr_number = 1;
int counter = 1;
while (counter <= pyramid_number_int) 
{
    for (int i = 1; i <= pyr_number; i++) 
    {
        if (counter <= pyramid_number_int) 
        {
            Console.Write($"{counter} ");
            counter++;
        }
    }
    Console.WriteLine();
    pyr_number++;
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

Console.WriteLine("Ile pięter diamentu: ");
string diamond = Console.ReadLine();
int diamond_num;
Int32.TryParse((diamond), out diamond_num);

int astrix_num = 1;
int max_astrix = diamond_num * 2 - 1;

for (int i = 1; i <= diamond_num; i++) 
{
    int space_num = (max_astrix - astrix_num) / 2;
    for (int j = 1; j <= space_num; j++) 
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= astrix_num; k++) 
    {
        Console.Write("*");
    }
    for (int j = 1; j <= space_num; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
    astrix_num += 2;
}
// zmniejszanie diamentu
astrix_num -= 2;

for (int i = 1; i <= diamond_num; i++)
{
    astrix_num -= 2;
    int space_num = (max_astrix - astrix_num) / 2;
    for (int j = 1; j <= space_num; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= astrix_num; k++)
    {
        Console.Write("*");
    }
    for (int j = 1; j <= space_num; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

/* Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
Testowe dane:
Abcdefg
Rezultat
Gfedcba
*/

Console.Write("Wpisz słowo do odwrócenia: ");
string word =  Console.ReadLine();

string reversed_word = "";
for (int letter = word.Length - 1; letter >= 0; letter--) 
{
    reversed_word += word[letter];
}
Console.WriteLine($"Twoje odwrócone słowo to: {reversed_word}");

// Napisz program, który zamieni liczbę dziesiętną na liczbę binarną

Console.Write("Wpisz liczbę do przeliczenia na system dwójkowy: ");
string decimal_num = Console.ReadLine();
int decimal_num_int;
Int32.TryParse(decimal_num, out decimal_num_int);


string num_string_rev = "";
while  (decimal_num_int > 0) 
{
    int num_rest = decimal_num_int % 2;
    num_string_rev += num_rest;
    decimal_num_int /= 2;
}

// odwrócenie stringa

string decimal_number = "";
for (int letter = num_string_rev.Length - 1; letter >= 0; letter--)
{
    decimal_number += num_string_rev[letter];
}
Console.WriteLine($"W postaci binarnej to: {decimal_number}");


// Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb

Console.Write("Liczymy najmniejszą wspólną wielokrotność. Wpisz 1 licznę: ");
string number_one = Console.ReadLine();
int number_one_int;
Int32.TryParse(number_one,out number_one_int);

Console.Write("Wpisz 2 licznę: ");
string number_two = Console.ReadLine();
int number_two_int;
Int32.TryParse(number_two, out number_two_int);

// 1. największy wspólny dzielink
int nwd = 1;

for (int i=2; i < number_one_int; i++) 
{
    if (number_one_int % i == 0 && number_two_int % i == 0) 
    {
        nwd = i;
    }
}

// 2. nww

int nww = number_one_int * number_two_int / nwd;

Console.WriteLine($"Najmniejsza wspólna wielokrotność {number_one_int} i {number_two_int} to {nww}");