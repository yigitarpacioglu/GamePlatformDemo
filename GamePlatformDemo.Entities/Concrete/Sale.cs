using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Abstract;

namespace GamePlatformDemo.Entities.Concrete
{
    public class Sale:IEntity
    {
        public int Id { get; set; }             // Satış Id'si

        public string Name { get; set; }        // Kime satıldığını Mr./Mrs. Arpacıoğlu olarak döndüreceğiz

        public int GameEditionId { get; set; } // Game Edition Id 1. Basic, 2.Premium, 3.Legendary
        public int CustomerId { get; set; }    // Customer Id: Müşteri Id'si

        public double Price { get; set; }       // Satış fiyatı
    }
}
