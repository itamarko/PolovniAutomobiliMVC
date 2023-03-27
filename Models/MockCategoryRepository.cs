namespace PolovniAutomobiliMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{ Id=1, Name="Sedan", Description="A sedan has four doors and a traditional trunk."},
                new Category{ Id=2, Name="Hatchback", Description="Traditionally, the term hatchback has meant a compact or subcompact sedan with a squared-off roof and a rear flip-up hatch door that provides access to the vehicle's cargo area instead of a conventional trunk."},
                new Category{ Id=3, Name="SUV", Description="SUVs—often also referred to as crossovers—tend to be taller and boxier than sedans, offer an elevated seating position, and have more ground clearance than a car. "}
            };
    }
}
