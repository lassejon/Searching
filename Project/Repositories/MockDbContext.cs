namespace Project;

public class MockDbContext
{
    public Product[] MockTShirtProducts { get; } =
    {
        new()
        { 
            Name = "Fed T-SHIRT",
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK T-SHIRT", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 10 },
                { Size.L, 20},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "basic", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "cool", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK T-bag", 
            Id = Guid.NewGuid(), 
            InStock = false, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "bag",
            Id = Guid.NewGuid(), 
            InStock = false, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "T", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = true, 
            SizesAvailable = new Dictionary<Size, int>()
            {
                { Size.S, 1 },
                { Size.L, 1},
                { Size.M, 1}
            }
        },
        new Product 
        { 
            Name = "SHIRT",
            Id = Guid.NewGuid(),
            InStock = false,
            IsDeleted = true,
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "T-SHIRT",
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 2 },
                { Size.L, 3},
                { Size.M, 40}
            }
        },
        new Product 
        { 
            Name = "hey", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "heyson", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 123},
                { Size.L, 123},
                { Size.M, 1123}
            }
        },
        new Product 
        { 
            Name = "t", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "vans", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "mmh", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "hmm", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = true, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "OK T-SHIRT",
            Id = Guid.NewGuid(), 
            InStock = false, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>()
        },
        new Product 
        { 
            Name = "hm", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "not OK SHIRT", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "not OK T", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "not OK T-SHIRT", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK V-SHIRT", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK SHIRT", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1 },
                { Size.L, 2},
                { Size.M, 10}
            }
        },
        new Product 
        { 
            Name = "OK T", 
            Id = Guid.NewGuid(), 
            InStock = true, 
            IsDeleted = false, 
            SizesAvailable = new Dictionary<Size, int>
            {
                { Size.S, 1123 },
                { Size.L, 2213},
                { Size.M, 11230}
            }
        },
    };
}