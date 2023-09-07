// See https://aka.ms/new-console-template for more information


// Atama ve İşlemli Atama
int x = 3;
int y = 3;

y = y + 2;
y += 2;
Console.WriteLine(y);

y /= 3;
Console.WriteLine(y);

x *= 2;
Console.WriteLine(x);

//Mantıksal Operatörler

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
{
    Console.WriteLine("Perfect");
}
if (isSuccess || isCompleted)
{
    Console.WriteLine("Great");
}

if (isSuccess && !isCompleted)
{
    Console.WriteLine("Fine");
}

// İlişkisel Operatörler
// <,  >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);




