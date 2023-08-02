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
string second_name;
string age;
char gender;
string pesel;
string worker_number;

/* Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
odwrotnej kolejności niż zostały zadeklarowane. */

char first_char = 'a';
char second_char = 'b';
char third_char = 'c';

Console.WriteLine($"3: {third_char}, 2: {second_char}, 1: {first_char}");

/* Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) */

double lenght_a = 5;
double lenght_b = 10;

double lenght_diagonal = Math.Sqrt(Math.Pow(lenght_a, 2) + Math.Pow(lenght_b, 2));
Console.WriteLine($"Długość przekątnej prostokąta o bokach {lenght_a} i {lenght_b} to {lenght_diagonal}");

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
string name_input = Console.ReadLine();
Console.WriteLine($"Podałeś swoje imię: {name_input}");

Console.WriteLine("Wpisz swój wiek:");
string age_input = Console.ReadLine();
int age_int;
int.TryParse(age_input, out age_int);
Console.WriteLine($"Podałeś swój wiek: {age_int}");