using System;

public class Object2
{
    private object value;

    public Object2(object value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return base.ToString() + ": " + value.ToString();
    }
}

public class Example
{
    public static void Main()
    {
        //Object2 obj2 = new Object2('a');
        //Console.WriteLine(obj2.ToString());

        //Console.ReadKey();

        int numero1 = 1;
        long numero2 = 2;

        long numero3 = numero1 + numero2;

        int numero4 = numero1 + (int)numero2;

    }
}
// The example displays the following output:
//       Object2: a