using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain
{
    interface IMemberHostel
    {
        string NumberStars { get; }
        string Description { get; set; }

        decimal GetPrice();
    }
}
