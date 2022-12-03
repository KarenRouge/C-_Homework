//Задача 2
int a = 5;
int b = 7;

bool comp1 =  a > b;
bool comp2 = a < b;
if (comp1)
{Console.WriteLine("max = 5");
}
else if (comp2)
{Console.WriteLine("max = 7");
} 

int a1 = 2;
int b1 = 10;

bool comp11 =  a1 > b1;
bool comp21 = a1 < b1;
if (comp11)
{Console.WriteLine("max = 2");
}
else if (comp21)
{Console.WriteLine("max = 10");
}  

int a2 = -9;
int b2 = -3;

bool comp12 =  a2 > b2;
bool comp22 = a2 < b2;
if (comp12)
{Console.WriteLine("max = -9");
}
else if (comp22)
{Console.WriteLine("max = -3");
} 
//Задача 4
int max = 2;
int e = 3;
int f = 7;

if (e>max)max=e;
if (f>max)max=f;
Console.WriteLine(max);

//Задача 6
int n = 4;
Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");
int n1 = -3;
Console.WriteLine(n1 % 2 == 0 ? "Четное" : "Не четное");
int n2 = 7;
Console.WriteLine(n2 % 2 == 0 ? "Четное" : "Не четное");

//Задача 8
 
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
for (int i=0; i<num; i++)
{
    Console.WriteLine(num);
    num = (-(~num)); num = (-(~num));
}



