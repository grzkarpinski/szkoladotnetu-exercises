/* Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
one równe czy nie.
Dane testowe:
a : 5
b : 5
Rezultat w terminalu :
5 i 5 są równe */

using System;
using System.Reflection;

int a = 5;
int b = 5;

if (a == b)
{
    Console.WriteLine($"{a} i {b} są równe");
}
else
{
    Console.WriteLine($"{a} i {b} NIE są równe");
}

/* Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
jest parzysta czy nieparzysta.
Dane testowe : 15
Rezultat w terminalu :
15 jest liczbą nieparzystą */

Console.WriteLine("Wpisz liczbę do sprawdzenia:");
string numberInput = Console.ReadLine();
int numberInt;
int.TryParse( numberInput, out numberInt);

if (numberInt % 2 == 0) 
{
    Console.WriteLine("Ta liczba jest parzysta!");
}
else 
{
    Console.WriteLine("Ta liczba NIE jest parzysta!");
}

/* Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
jest dodatnia czy ujemna.
Dane testowe : 14
Rezultat w terminalu :
14 jest liczbą dodatnią */

Console.WriteLine("Wpisz liczbę do sprawdzenia czy jest dodatnia:");
string numberInput1 = Console.ReadLine();
int numberInt1;
int.TryParse(numberInput1, out numberInt1);

if (numberInt1 > 0) 
{
    Console.WriteLine("Ta liczba jest większa od 0!");
}
else if (numberInt1 < 0)
{
    Console.WriteLine("Ta liczba jest mniejsza od 0!");
}
else
{
    Console.WriteLine("Ta liczba to 0!");
}

/* Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
jest rokiem przestępnym.
Dane testowe : 2016
Rezultat w terminalu :
2016 jest rokiem przestępnym */

Console.WriteLine("Wpisz rok do sprawdzenia czy jest przestępny:");
string yearInput = Console.ReadLine();
int yearInt;
int.TryParse( yearInput, out yearInt);

if ((yearInt % 4 == 0 && yearInt % 100 != 0) || yearInt % 400 == 0) 
{
    Console.WriteLine("Ten rok jest przestępny!");
}
else
{
    Console.WriteLine("Ten rok nie jest przestępny!");
}

/* Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
prezydenta.
Dane testowe : 21
Rezultat w terminalu :
Możesz zostać posłem */

Console.WriteLine("Wpisz swój wiek:");
string ageInput = Console.ReadLine();
int ageInt;
int.TryParse(ageInput, out ageInt);

switch (ageInt) 
{
    case >= 35:
        Console.WriteLine("Możesz zostać posłem, premierem, senatorem i nawet prezydentem");
        break;

    case >= 30 :
        Console.WriteLine("Możesz zostać posłem, premierem lub senatorem");
        break;

    case >= 21:
        Console.WriteLine("Możesz zostać posłem lub premierem");
        break;

    default:
        Console.WriteLine("Nie masz biernego prawa wyborczego...");
        break;
}

/* Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
wymyśloną kategorię wzrostu.
Dane testowe : 140
Rezultat w terminalu :
Jesteś krasnoludem */

Console.WriteLine("Wpisz wzrost istoty:");
string highInput = Console.ReadLine();
int highInt;
int.TryParse(highInput, out highInt);

switch (highInt)
{
    case >= 190:
        Console.WriteLine("To musi być troll!");
        break;

    case >= 160:
        Console.WriteLine("To pewnie jest człowiek...");
        break;

    case >= 100:
        Console.WriteLine("Raczej krasnolud.");
        break;

    default:
        Console.WriteLine("Podstępny mały gnom!");
        break;
}

/* Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
która jest największa
Dane testowe:
25
63
79
Rezultat w terminalu :
79 jest największa z podanych */

Console.WriteLine("Wpisz 1 liczbę:");
string firstInput = Console.ReadLine();
int firstInt;
int.TryParse(firstInput, out firstInt);

Console.WriteLine("Wpisz 2 liczbę:");
string secondInput = Console.ReadLine();
int secondInt;
int.TryParse(secondInput, out secondInt);

Console.WriteLine("Wpisz 3 liczbę:");
string thirdInput = Console.ReadLine();
int thirdInt;
int.TryParse(thirdInput, out thirdInt);

int biggestNumber = firstInt;

if (secondInt > biggestNumber) 
{
    biggestNumber = secondInt;
}
else if (thirdInt > biggestNumber) 
{
    biggestNumber = thirdInt;
}

Console.WriteLine($"Największa z tych liczb to {biggestNumber}");

/* Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
na studiach wg. Następujących kryteriów:
Wynik z Matury z matematyki powyżej 70
Wynik z fizyki powyżej 55
Wynik z chemii powyżej 45
Łączny wynik z 3 przedmiotów powyżej 180
Albo
Wynik z matematyki i jednego przedmiotu powyżej 150
Dane testowe:
Matematyka 80
Fizyka 71
Chemia 0
Rezultat w terminalu :
Kandydat dopuszczony do rekrutacji */

int math = 80;
int physics = 71;
int chemistry = 50;

if ((math > 70 && physics > 55 && chemistry > 45 && math + physics + chemistry > 180) || math + physics > 150 || math + chemistry > 150) 
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else 
{
    Console.WriteLine("Kandydat nie dopuszczony");
}

/* Napisz program, który odczyta temperaturę I zwróci nazwę jak w
poniższych kryteriach
Temp < 0 – cholernie piździ
Temp 0 – 10 – zimno
Temp 10 – 20 – chłodno
Temp 20 – 30 – w sam raz
Temp 30 – 40 – zaczyna być słabo, bo gorącoTemp >= 40 – a weź wyprowadzam się na Alaskę. */

Console.WriteLine("Jaka jest temperatura?:");
string tempInput = Console.ReadLine();
int temp;
int.TryParse(tempInput, out temp);

if (temp < 0)
{
    Console.WriteLine("Cholernie piździ");
}
else if (0 <= temp && temp <= 10)
{
    Console.WriteLine("zimno");
}
else if (10 > temp && temp <= 20)
{
    Console.WriteLine("chłodno");
}
else if (20 > temp && temp <= 30)
{
    Console.WriteLine("W sam raz");
}
else if (30 > temp && temp <= 40)
{
    Console.WriteLine("zaczyna być słabo, bo gorąco");
}
else 
{
    Console.WriteLine("a weź wyprowadzam się na Alaskę.");
}

/* Napisz program, który sprawdzi, czy z 3 podanych długości można
stworzyć trójkąt
Dane testowe : 40 55 65
Rezultat w terminalu :
Można zbudować trójkąt */

int bokA = 40;
int bokB = 55;
int bokC = 65;

if (bokA + bokB > bokC && bokA + bokC > bokB && bokB + bokC > bokA)
{
    Console.WriteLine("Można zbudować trójkąt");
}
else 
{
    Console.WriteLine("Nie można zbudować trójkąta.");
}

/* Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
Ocena Opis
6 Celujący
5 Bardzo dobry
4 Dobry
3 Dostateczny
2 Dopuszczający
1 Niedostateczny */

int mark = 4;

switch (mark) 
{
    case 1: Console.WriteLine("Niedostateczny");
    break;

    case 2: Console.WriteLine("Dopuszczający");
        break;

    case 3: Console.WriteLine("Dostateczny");
        break;

    case 4: Console.WriteLine("Dobry");
        break;

    case 5: Console.WriteLine("Bardzo dobry");
        break;

    case 6: Console.WriteLine("Celujący");
        break;

    default: Console.WriteLine("Nie ma takiej oceny");
    break;
}

/* Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
nazwę
Dane testowe : 4 Rezultat w terminalu :
Czwartek */

Console.WriteLine("Jaki jest dzień tygodnia? (numer)");
string day  = Console.ReadLine();
switch (day) 
{
    case "1": 
        Console.WriteLine("Poniedziałek");
        break;

    case "2": 
        Console.WriteLine("Wtorek");
        break;

    case "3":
        Console.WriteLine("Środa");
        break;

    case "4": 
        Console.WriteLine("Czwartek");
        break;

    case "5": 
        Console.WriteLine("Piątek");
        break;

    case "6": 
        Console.WriteLine("Sobota");
        break;

    case "7": 
        Console.WriteLine("Niedziela");
        break;

    default : 
        Console.WriteLine("Nie ma takiego dnia tygodnia");
        break;
}

/* Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
będzie prostym kalkulatorem
Podaj pierwszą liczbę:
…
Podaj drugą liczbę:
…
Podaj numer operacji do wykonania:
1. Dodawanie
2. Odejmowanie
3. Mnożenie
4. Dzielenie
…
Twój wynik to: */

Console.WriteLine("Podaj numer operacji do wykonania:");
Console.WriteLine(@"1. Dodawanie
2. Odejmowanie
3. Mnożenie
4. Dzielenie");

string operation  = Console.ReadLine();

Console.WriteLine("Wpisz pierwszą liczbę:");
string number1 =  Console.ReadLine();
double number1Int;
Double.TryParse(number1, out number1Int);

Console.WriteLine("Wpisz drugą liczbę:");
string number2 = Console.ReadLine();
double number2Int;
Double.TryParse(number2, out number2Int);

double output;
switch (operation) 
{
    case "1":
        output = number1Int + number2Int;
        break;
    case "2":
        output = number1Int - number2Int;
        break;
    case "3":
        output = number1Int * number2Int;
        break;
    case "4":
        if (number2Int == 0)
        {
            Console.WriteLine("Pamiętaj cholero, nigdy nie dziel przez 0!");
            output = 0;
            break;
        }
        else
        {
            output = number1Int / number2Int;
        }
        break;
    default:
        output = 0;
        Console.WriteLine("Nie znam takiej operacji");
        break;
}

Console.WriteLine($"Wynik operacji  = {output}");

