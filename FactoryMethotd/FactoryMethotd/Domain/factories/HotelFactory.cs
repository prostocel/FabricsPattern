using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain.factories
{
    abstract class HotelFactory
    {
        public abstract IMemberHostel GetMemberHostel();
    }
}
