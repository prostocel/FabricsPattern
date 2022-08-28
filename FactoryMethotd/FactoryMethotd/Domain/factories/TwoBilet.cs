using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain.factories
{
    class TwoBilet: HotelFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public TwoBilet(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMemberHostel GetMemberHostel()
        {
            TwoStars TwoStarsBilet = new TwoStars(_price);
            TwoStarsBilet.Description = _description;
            return TwoStarsBilet;
        }
    }
}
