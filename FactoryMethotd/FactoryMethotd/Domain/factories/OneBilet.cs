using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain.factories
{
    class OneBilet: HotelFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public OneBilet(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMemberHostel GetMemberHostel()
        {
            OneStars oneStarsBilet = new OneStars (_price);
            oneStarsBilet.Description = _description;
            return oneStarsBilet;
        }
    }
}
