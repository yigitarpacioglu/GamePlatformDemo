using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Abstract;

namespace GamePlatformDemo.Entities.Concrete
{
    // Bu dosya oyun detaylarına ait bilgileri tutmaktadır.
    public class GameEdition:IEntity
    {
        public int Id { get; set; }             // Edition Id : 3 adet oyun versiyonu vardır. Bunlar içi
        public string Name { get; set; }        // Edition Name : Basic, Premium ve Legendary olmak üzere üç adet edition vardır.
        
        public double Price { get; set; }       // Edition Price : Yukarıda belirtilen farklı planlar için farklı ödemeler gerçekleştirilecektir.
    }
}
