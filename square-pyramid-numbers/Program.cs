    int sum = 0;
    Console.Write("N : ");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        sum = 0;
        for (int j = 1; j <= i; j++)
        {
            sum += j * j;
            Console.Write(j + "^2");
            if (j != i)
            {
                Console.Write(" + ");
            }
            else
            {
                Console.Write(" = ");
            }
        }
        Console.Write(sum);
        Console.WriteLine();
    }
    Console.ReadKey();