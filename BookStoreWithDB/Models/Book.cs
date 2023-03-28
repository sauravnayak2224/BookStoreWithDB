using System;
using System.Collections.Generic;

namespace BookStoreWithDB.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string BookName { get; set; } = null!;

    public int? CustomerId { get; set; }
}
