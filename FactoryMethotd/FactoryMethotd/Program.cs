using FactoryMethotd.Domain;
using FactoryMethotd.Domain.factories;
using System;

namespace FactoryMethotd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hotel 'ass we can' \n");
            string HotelBiletType = Console.ReadLine();

            HotelFactory factory = GetFactory(HotelBiletType);
            IMemberHostel memberhostel = factory.GetMemberHostel();
            Console.WriteLine(
                $"\tName:\t\t{memberhostel.NumberStars}\n" +
                $"\tDescription:\t\t{memberhostel.Description}\n" +
                $"\tprice:\t\t {memberhostel.GetPrice()}");
            Console.ReadLine();
        }

        private static HotelFactory GetFactory(string HotelBiletType) =>
            HotelBiletType.ToLower() switch
            {
                "1" => new OneBilet(1000, "one bilet"),
                "2" => new TwoBilet(1500, "two bilet"),
                "3" => new ThreeStarsBilet(3000, "three bilet"),
                _ => null,
            };
    }
}
