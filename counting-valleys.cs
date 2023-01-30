class Result
{
    public static int countingValleys(int steps, string path)
    {
        var altitude = 0;
        var valleys = 0;
        foreach (var item in path)
        {
            if(item == 'U')
            {
                if(altitude == -1) valleys++;
                altitude++;
            }
            else 
                altitude--;
        }
        return valleys;
    }
}
