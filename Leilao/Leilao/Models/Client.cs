﻿namespace Leilao.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public ICollection<Bid> Bids { get; set; }
    }
}
