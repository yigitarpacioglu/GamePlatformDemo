using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Abstract
{
    public interface ISaleService
    {
        // SalesManager içerisinde satış kısmında kullanılacak olan fonksiyonlar burada tanımlanmıştır.
        public int Discount(CampaignCoupon coupon);
        void BuyGame(GameEdition edition, Member customer,int discount);
        void Refund(Sale sale);
        void ListSales();
    }
}
