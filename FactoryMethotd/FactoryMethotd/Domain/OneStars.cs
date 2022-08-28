using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethotd.Domain
{
    class OneStars: IMemberHostel
    {
        private readonly string _starCol;
        private readonly decimal _price;

        public OneStars(decimal price)
        {
            _starCol = "1StarsTicket";
            _price = price;
        }

        public string NumberStars => _starCol;
        public decimal GetPrice() => _price;
        public string Description { get; set; }
    }
}
