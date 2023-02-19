﻿using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Item() { }

        // Relations
        public List<TransactionLine> TransactionLines { get; set; }

    }
}


