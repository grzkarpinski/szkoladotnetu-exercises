/* Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
które chcesz przetrzymywać to:
a. Imię,
b. Nazwisko
c. Wiek
d. Płeć (‘m’ albo ‘k’)
e. PESEL
f. Numer pracownika (np. 2509324094)
Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje */

string name;
string secondName;
int age;
char gender;
string pesel;
string workerNumber;

/* Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
odwrotnej kolejności niż zostały zadeklarowane. */

char firstChar = 'a';
char secondChar = 'b';
char thirdChar = 'c';

Console.WriteLine($"3: {thirdChar}, 2: {secondChar}, 1: {firstChar}");

/* Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) */

double lenghtA = 5;
double lenghtB = 10;

double lenghtDiagonal = Math.Sqrt(Math.Pow(lenghtA, 2) + Math.Pow(lenghtA, 2));
Console.WriteLine($"Długość przekątnej prostokąta o bokach {lenghtA} i {lenghtB} to {lenghtDiagonal}");

/*  Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
przypiszesz im następujące wartości:
a. 10
b. Szkoła Dotneta
c. 12,5
Pamiętaj o użyciu poprawnych typów danych. */

int a = 10;
string b = "Szkoła Dotneta";
double c = 12.5;

/* Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
typDanych.Parse(odpowiedźOdUżytkownika). */

Console.WriteLine("Wpisz swoję imię:");
string nameInput = Console.ReadLine();
Console.WriteLine($"Podałeś swoje imię: {nameInput}");

Console.WriteLine("Wpisz swój wiek:");
string ageInput = Console.ReadLine();
int ageInt;
int.TryParse(ageInput, out ageInt);
Console.WriteLine($"Podałeś swój wiek: {ageInt}");