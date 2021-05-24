using System;

class Point: Object
{
    public int X, Y;
    public override string ToString()
    {
        return X + " "+  Y;
    }
    public override bool Equals(object obj)
    {
        Point p = (Point)obj;
        return (this.X == p.X)&&(this.Y==p.Y);
    }
    public override int GetHashCode()
    {
        int hashx = X.GetHashCode();
        int hashy = Y.GetHashCode();

        int hash = 10;
        hash = (hash * 7) + hashx;
        hash = (hash * 7) + hashy;
        return hash;
    }
    

}
class Program
{
   static void Main(string[] args)
   {
        Point pt1 = new Point() {X=10, Y=10 };
        Console.WriteLine(pt1);
        Point pt2 = new Point() { X = 10, Y = 11};
        Console.WriteLine(pt1.Equals(pt2));
        Console.WriteLine(pt1.GetHashCode()+ " "+ pt2.GetHashCode());

        Type tp1= pt1.GetType();
        Type tp2 = pt2.GetType();
        Console.WriteLine(tp1==tp2);
    }
}
