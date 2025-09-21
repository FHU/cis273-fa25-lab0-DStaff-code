namespace Vector;

public class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector() {X=3,Y=5};

        Vector v2 = v1;

        Vector result = v1.Add(v2);

        Vector result2 = Vector.Add(v1, v2);



    }
}

