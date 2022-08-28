using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain
{
    class TwoStars: IMemberHostel
    {
        private readonly string _starCol;
        private readonly decimal _price;

        public TwoStars(decimal price)
        {
            _starCol = "2StarsTicket";
            _price = price;
        }

        public string NumberStars => _starCol;
        public decimal GetPrice() => _price;
        public string Description { get; set; }
    }
}
