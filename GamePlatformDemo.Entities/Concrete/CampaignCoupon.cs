using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Abstract;

namespace GamePlatformDemo.Entities.Concrete
{
    // Bu dosya kampanyaya ait bilgileri tutmaktadır.
    public class CampaignCoupon:IEntity
    {
        public int Id { get; set; }                 // Deal Id           :  Kampanya numarası
        public string Name { get; set; }            // Deal Name         :  Kuponun adı 
        
        public int Discount { get; set; }           // Deal discount     : İndirim oranı % (yüzdesi)

        
    }
}
