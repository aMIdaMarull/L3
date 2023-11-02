namespace Lab3
{
    internal class Program
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        public static Season GetSeason(DateTime dateTime)
        {
            int currentMonth = dateTime.Month;

            switch (currentMonth)
            {
                case 12:
                case 1:
                case 2:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                default:
                    return Season.Winter;
            }
        }

        static ISeasonalClothingFactory GetSeasonalFactory(Season season)
        {
            switch (season)
            {
                case Season.Summer:
                    return new SummerFactory();
                case Season.Winter:
                    return new WinterFactory();
                case Season.Autumn:
                    return new AutumnFactory();
                case Season.Spring:
                    return new SpringFactory();
                default:
                    return new WinterFactory();
            }
        }


        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            //DateTime spring = new DateTime(2023, 3, 20);
            //DateTime summer = new DateTime(2023, 6, 21);
            //DateTime autumn = new DateTime(2023, 9, 23);
            //DateTime winter = new DateTime(2023, 12, 21);



            Season season = GetSeason(now);

            Console.WriteLine("It's currently " + season + ".");
            Console.WriteLine();

            ISeasonalClothingFactory factory = GetSeasonalFactory(season);
            IClothing clothing = factory.CreateClothing();
            IShoes shoes = factory.CreateShoes();

            Console.WriteLine("Dressing for " + season + ":");
            clothing.Dress();
            shoes.PutOn();
        }
    }
}