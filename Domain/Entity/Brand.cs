﻿using System;
using System.Collections.Generic;

namespace Domain;

public  class Brand
{
    public int BrandId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
