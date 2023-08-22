using EFCoreTest.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFCoreTest.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private DatabaseContext _context;

    public IndexModel(ILogger<IndexModel> logger, DatabaseContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet(bool generatePeople = false)
    {
        if (generatePeople)
        {
            var food = new[]
            {
                new Food("Best Brand", 4, 2),
                new Food("Mid Brand", 1, 1),
                new Food("Worst Brand", 0.5, 1)
            }.ToList();

            var animals = new Animal[]
            {
                new() { Name = "Dog", Legs = 4, AcceptableFood = food },
                new() { Name = "Cat", Legs = 4, AcceptableFood = food }
            }.ToList();

            var owners = new List<Person>
            {
                new Person {  Name = "Joe", Pets = animals },
                new Person { Name = "Bob",  Pets = animals },
                new Person { Name = "Sue", Pets = animals },
                new Person { Name = "Amy", Pets = animals },
            };

            owners[0].BestFriend = owners[2];

            _context.People.AddRange(owners);
            _context.SaveChanges();
        }
    }
}
