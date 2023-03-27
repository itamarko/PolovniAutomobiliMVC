namespace PolovniAutomobiliMVC.Models
{
    public class MockCarRepository : ICarRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Car> AllCars =>
            new List<Car>
            {
                new Car{ Id = 1, Name = "Hyundai Kona", DescriptionShort = "The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position.",
                Description = "When an SUV delivers as crisp a driving experience as the 2022 Hyundai Kona, it's hard to get hung up on the usual anti-crossover sentiment—so we won't. The subcompact Kona is, simply put, a great package that blends carlike on-road behavior with bold styling, a dose of practicality, and an elevated driving position. Two four-cylinder engines are offered: a 2.0-liter four, which is admittedly pretty poky, and a more desirable turbocharged 1.6-liter four that delivers a lot more punch.",
                IsSpecialOffer = false, FuelTypeId = 1, Price = 22135, ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=980:*",
                ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-hyundai-kona-101-1613496529.jpg?crop=1xw:1xh;center,top&resize=800:*", Category = _categoryRepository.AllCategories.ToList()[2]},
                new Car{ Id = 2, Name = "Nissan Kicks", DescriptionShort = "Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick.",
                Description = "With a bold exterior look and a surprisingly spacious cabin, the 2021 Nissan Kicks is a stylish small SUV with a practical side. Its powertrain leaves us wanting, especially when traveling at highway speeds, but as a city-focused commuter the Kicks is, um, a kick. Standard equipment is plentiful and includes driver-assistance features and popular infotainment tech such as Apple CarPlay and Android Auto.",
                IsSpecialOffer = false, FuelTypeId = 2, Price = 20650, ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=2048:*",
                ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-nissan-kicks-35-1607442145.jpg?crop=0.854xw:0.665xh;0.130xw,0.335xh&resize=800:*", Category = _categoryRepository.AllCategories.ToList()[2]},
                new Car{ Id = 3, Name = "VW Golf", DescriptionShort = "Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. ",
                Description = "Few compact hatchbacks are better than the 2021 Volkswagen Golf, but one that is happens to share the same showroom: the sporty GTI (reviewed separately). Apart from the standard Golf's lower asking price and higher fuel efficiency, it isn't as desirable as its more powerful, better-equipped sibling. While that's partly why VW will only offer the next-generation GTI and high-performance Golf R on our shores, it doesn't diminish that the regular version remains a terrific value in its final year.",
                IsSpecialOffer = false, FuelTypeId = 1, Price = 24190, ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=2048:*",
                ImageUrlThumbnail = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2021-volkswagen-golf-mmp-1-1604508183.jpg?crop=0.814xw:0.688xh;0.175xw,0.255xh&resize=800:*", Category = _categoryRepository.AllCategories.ToList()[1]}
            };

        public IEnumerable<Car> SpecialOfferCars => throw new NotImplementedException();

        public Car GetCarById(int carId)
        {
            return AllCars.FirstOrDefault(p => p.Id == carId);
        }
    }
}
