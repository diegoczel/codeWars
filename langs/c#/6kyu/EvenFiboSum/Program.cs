Console.WriteLine(Fibonacci(33));

static long Fibonacci(int max)
{
    long a = 0;
    long b = 1;
    long fib = 0;
    long s = 0;

    do
    {
        if(fib % 2 == 0)
        {
            s += fib;
        }
        fib = a + b;
        a = b;
        b = fib;
    } while(fib < max);

    return s;
}