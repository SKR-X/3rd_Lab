class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the size of first array: ");
        int n = Convert.ToInt32(Console.ReadLine());
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
            A.Add(Convert.ToInt32(Console.ReadLine()));
        }
        for (int i=0; i < n/2; i++)
        {
            f = A[i];
            A[i] = A[n-1-i];
            A[n-1-i] = f;
        }
        Console.WriteLine("The new array: ");
        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine(A[i]);
        }
        return 0;
    }
}