class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int RemainingMinutesInOven(int rem)
    {
        var lasagna = new Lasagna();
        int ex = lasagna.ExpectedMinutesInOven();
        return (ex - rem);
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int PreparationTimeInMinutes(int x)
    {
        return x * 2;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int x , int y)
    {
        var lasagna = new Lasagna();
        //int con = lasagna.RemainingMinutesInOven(y);
        //Console.WriteLine("con:-" + con);
        int prep = lasagna.PreparationTimeInMinutes(x);
        Console.WriteLine("prep:-" + prep);
        return (y + prep);
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
}
