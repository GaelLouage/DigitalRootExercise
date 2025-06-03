internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DigitalRoot(16999));
    }
    public static int DigitalRoot(long n)
    {
        var result = long.Parse(n.ToString());
        var resString = result.ToString();
        var counter = 0;
        var data = 0;
        while (resString.Length > 1)
        {
            data += (int)char.GetNumericValue(resString[counter]);

            if (counter == result.ToString().Length - 1)
            {
                counter = 0;
                result = data;
                resString = result.ToString();
                data = 0;
            }
            else
            {
                counter++;
            }
        }
        return (int)result;
    }
}