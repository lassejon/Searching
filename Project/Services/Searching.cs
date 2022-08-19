using System.Text.RegularExpressions;

namespace Project;

public class Searching
{
    private readonly MockDbContext _dbContext;

    public Searching(MockDbContext mockDbContext)
    {
        _dbContext = mockDbContext;
    }
    
    // TODO: Implement query logic for filtering and searching
    public void UpdateQuery<T>(ref IQueryable<T> query, bool condition, Func<IQueryable<T>, IQueryable<T>> getUpdatedQuery)
    {
        if (!condition)
        {
            return;
        }
    
        query = getUpdatedQuery(query);
    }

    // TODO: Use querying instead of a simple .Where search
    public IEnumerable<Product> GetStudents(string search)
    {
        var regex = new Regex($@"{search}", RegexOptions.IgnoreCase);

        return _dbContext.MockTShirtProducts.Where(p => !p.IsDeleted && regex.Match(p.Name).Success);
    }
}