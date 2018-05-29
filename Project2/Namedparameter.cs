class Program
{
    static void Main(string[] args)
    {
    Program p = new Program();
    int a, b, c, d;
    a = p.Add(10, 20, 30);
    b = p.Add(10, 20);
    c = p.Add(10);
    d = p.Add(x: 20, z: 200);
}
    private int Add(int x, int y=0, int z=0)
    {
        return x + y + z;
    }
}