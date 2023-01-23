class Lasagna
{
    // Declare set number for time in over. In future, setting a constructor with variable time would be better
    private int timeInOven = 40;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return timeInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int reaminingTime)
    {
        return timeInOven - reaminingTime;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        //Assuming two minutes of prep per layer
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        return (layers * 2) + (timeInOven);
    }
}
