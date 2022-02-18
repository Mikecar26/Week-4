
class program
{
    static int Main()
    {
        int width = 0;
        int height = 0;

        Function f = new Function();

        f.MakeRectangle(10, 30, ref width, ref height );
        Rectangle rectangle = new Rectangle(width, height);
        f.PrintRect(rectangle);

        return 0;
    }

}
class Rectangle
{
    int width;
    int height;

    public int getWidth() { return this.width; }
    public int getHeight() { return this.height; }

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
   
}
class Function
{
    static Random random = new Random();

    public static int Area(int width, int height)
    {
        return width * height;
    }
    public static int Perimeter(int width, int height)
    {
        return (width + height) * 2;
    }

    public void MakeRectangle(int min, int max, ref int width, ref int height)
    {
        width = random.Next(min, max);
        height = random.Next(min, max);
    }
    public void PrintRect(Rectangle rect)
    {
        Console.WriteLine("Length: " + rect.getHeight());
        Console.WriteLine("Width: " + rect.getWidth());
        Console.WriteLine("Area: " + Area(rect.getWidth(), rect.getHeight()));
        Console.WriteLine("Perimeter: " + Perimeter(rect.getWidth(), rect.getHeight()));
    }
}