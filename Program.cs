﻿// Sous-programme heure-minute
// Conertit un nombre de minutes au format H:M
//Valeur de retour : un tuple (H,M)
(int,int) heure_minute(int minute)
{
    return (minute/60, minute%60);
}

int minute_non_converti = Convert.ToInt32(Console.ReadLine());
(int H, int M) = heure_minute(minute_non_converti);
Console.WriteLine($"{H}:{M}");