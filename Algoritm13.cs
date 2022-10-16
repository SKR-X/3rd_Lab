class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the size of first array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the size of second array: ");
        int m = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine("Enter the second array: ");
        for (int i = 0; i < m; i++)
        {
            B.Add(Convert.ToDouble(Console.ReadLine()));
        }
        while (k < n || t < m)
        {
            if (k == n) { C.Add(B[t]); t++; continue; }
            if (t == m) { C.Add(A[k]); k++; continue; }
            if (A[k] >= B[t]) { C.Add(A[k]); k++; }
            else { C.Add(B[t]); t++; }
        }
        Console.WriteLine("The new array: ");
        for (int i = 0; i < C.Count; i++)
        {
            Console.WriteLine(C[i]);
        }
        return 0;
    }
}