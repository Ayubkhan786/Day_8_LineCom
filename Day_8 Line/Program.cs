
Console.WriteLine("Welcome to Line Comparison Computation Program");

 //A Length as 2 Points(x1, y1) and(x2, y2) 
 // - Length of a Line = sqrt( (x2 - x1) ^2 + (y2- y1) ^ 2)


int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
double Length = ((Math.Pow(x2, 2)) - (Math.Pow(x1, 2))) + ((Math.Pow(y2, 2)) - (Math.Pow(y1, 2)));
Console.WriteLine(Math.Sqrt(Length));
