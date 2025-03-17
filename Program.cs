(int,int) heure_minute(int minute)
{
    return (minute/60, minute%60);
}

(int H, int M) = heure_minute(130);
Console.WriteLine($"{H}:{M}");