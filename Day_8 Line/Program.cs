
Console.WriteLine("Welcome to Line Comparison Computation Program");

 //A Length as 2 Points(x1, y1) and(x2, y2) 
 // - Length of a Line = sqrt( (x2 - x1) ^2 + (y2- y1) ^ 2)


int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
double Length = ((Math.Pow(x2, 2)) - (Math.Pow(x1, 2))) + ((Math.Pow(y2, 2)) - (Math.Pow(y1, 2)));
double sqr = Math.Sqrt(Length);
Console.WriteLine(sqr);

int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());
int y3 = Convert.ToInt32(Console.ReadLine());
int y4 = Convert.ToInt32(Console.ReadLine());
double Length1 = ((Math.Pow(x4, 2)) - (Math.Pow(x3, 2))) + ((Math.Pow(y4, 2)) - (Math.Pow(y3, 2)));
double sqr1 = Math.Sqrt(Length1);
Console.WriteLine(sqr1);



Console.WriteLine("Length of First line =" +sqr);
Console.WriteLine("Length of Second line ="+sqr1);

if (sqr == sqr1)
{
    Console.WriteLine("it is equal");
}
else if (sqr > sqr1)
{
    Console.WriteLine("sqr is greater");
}
else
{
    Console.WriteLine("sqr is lesser");
}