using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Business.Abstract;
using GamePlatformDemo.DataAccess.Concrete;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Concrete
{
    public class CampaignCouponManager:ICouponService
    {
        private CampaignCouponDal _campaignCouponDal;

        public CampaignCouponManager(CampaignCouponDal campaignCouponDal)
        {
            _campaignCouponDal = campaignCouponDal;
        }

        public void DefineNewCoupon(CampaignCoupon coupon)
        {
            _campaignCouponDal.Add(coupon);
        }

        public void UpdateCoupon(int id, CampaignCoupon coupon)
        {
            _campaignCouponDal.Update(id,coupon);
        }

        public void DeleteCoupon(int id)
        {
            _campaignCouponDal.Delete(id); 
        }

        public void ListCoupons()
        {
            _campaignCouponDal.GetAll();
        }
    }
}
