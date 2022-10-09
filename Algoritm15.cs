class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the size of first array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value by which you want to shift the array elements: ");
        int d=Convert.ToInt32(Console.ReadLine());
        var A = new List<double>();
        var B = new List<double>();
        var C = new List<double>();
        double sum = 0;
        double sred = 0;
        int k = 0;
        bool b = false;
        int t = 0;
        int x = 0;
        int LB = 0;
        int LA = 0;
        double f;
        Console.WriteLine("Enter the first array: ");
        for (int i = 0; i < n; i++)
        {
            A.Add(Convert.ToDouble(Console.ReadLine()));
        }
        for (int i=0; i<d; i++)
        {
            f = A[n - 1];
            for (int j = n-1; j > 0; j--)
            {
                A[j]=A[j-1];
            }
            A[0] = f;
        }
        Console.WriteLine("The new array: ");
        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine(A[i]);
        }
        return 0;
    }
}