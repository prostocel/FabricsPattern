using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain.factories
{
    class ThreeStarsBilet: HotelFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public ThreeStarsBilet(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMemberHostel GetMemberHostel()
        {
            ThreeStars ThreeStarsBilet = new ThreeStars(_price);
            ThreeStarsBilet.Description = _description;
            return ThreeStarsBilet;
        }
    }
}
