int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double length( int x, int y, int z)
{
    double temp = (x*x)+(y*y)+(z*z);
    return Math.Sqrt(temp);
}



int x1 = ReadInt("Введите координау X первой точки ");
int y1 = ReadInt("Введите координау Y первой точки ");
int z1 = ReadInt("Введите координау Z первой точки ");
int x2 = ReadInt("Введите координау X второй точки ");
int y2 = ReadInt("Введите координау Y второй точки ");
int z2 = ReadInt("Введите координау Z второй точки ");



double res = length (x1-x2,y1-y2,z1-z2);
double res2 = Math.Sqrt( ((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2))+((z1-z2)*(z1-z2)));// Проверка 
Console.WriteLine ( res);
Console.WriteLine ( res2);