using LogicalProgramming;


Console.WriteLine("Basic programming");


while (true)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("\nChoose the Program to be executed :\n1)Fibonacci Series\n2)Perfect NUmber\n3)Prime Number\n4)Reverse Number\n5)Coupon Number\n6)Stopwatch" + "");    
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Fibonacciseries fibonacci = new();
            fibonacci.fibonacciseries();
            break;

        case 2:
            PerfectNumber perfect = new();
            perfect.perfefctnumber();
            break;

        case 3:
            PrimeNumber prime = new();
            prime.primenumber();
            break;

        case 4:
            ReverseNumber reverse = new();
            reverse.reverseNumber();
            break;

        case 5:
            CouponNumber coupon = new();
            coupon.CouponCode();
            break;

        case 6:
            stopwatch watch = new();
            watch.StopWatch();
            break;

        default:
            break;
    }
}

