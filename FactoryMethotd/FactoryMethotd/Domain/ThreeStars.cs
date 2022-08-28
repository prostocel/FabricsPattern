using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain
{
    class ThreeStars: IMemberHostel
    {
        private readonly string _starCol;
        private readonly decimal _price;

        public ThreeStars(decimal price)
        {
            _starCol = "3StarsTicket";
            _price = price;
        }

        public string NumberStars => _starCol;
        public decimal GetPrice() => _price;
        public string Description { get; set; }
    }
}
