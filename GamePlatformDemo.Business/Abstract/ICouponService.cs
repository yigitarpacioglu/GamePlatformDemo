using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Abstract
{
    public interface ICouponService
    {
        // CampaignCouponManager içerisindeki metodlar burada tanımlanmıştır.
        void DefineNewCoupon(CampaignCoupon coupon);
        void UpdateCoupon(int id, CampaignCoupon coupon);
        void DeleteCoupon(int id);
        void ListCoupons();
    }
}
