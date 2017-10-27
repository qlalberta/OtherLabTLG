// Hotel.cs

using System;
public class HotelCopy
{

    public static void Main()
    {
        Hotel[] hotels;
        hotels = new Hotel[5];
        hotels[0] = new Hotel("Seattle", "Ritz", 50, 190.00m);
        hotels[1] = new Hotel("Bellevue", "HolidayInn", 60, 180.00m);
        hotels[2] = new Hotel("MountRainier", "paradise", 60, 180.00m);
        hotels[3] = new Hotel("Ballard", "testinn", 60, 180.00m);
        hotels[4] = new Hotel("Beijing", "DailyInn", 60, 180.00m);
        foreach (Hotel key in hotels)
        {
            key.Show();
        }

        Hotel[] hotelsCopy = new Hotel[5];
        for (int i = 0; i < hotelsCopy.Length; i++)
        {
            hotelsCopy[i] = hotels[i];
            hotels[i].init("", "", 0, 0);
        }
        foreach (Hotel key in hotelsCopy)
        {
            key.Show();
        }
        foreach (Hotel key in hotels)
        {
            key.Show();
        }
    }
}

