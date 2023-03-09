int a = -4;
int b = 0;
int c = 56;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max=");
Console.WriteLine(max);
