using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using GamePlatformDemo.DataAccess.Abstract;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.DataAccess.Concrete
{
    public class CampaignCouponDal : IEntityRepository<CampaignCoupon>
    {
        private List<CampaignCoupon> _coupons;  // Verilerin tutulması için bir liste oluşturulmuştur. Database ile olan
                                                // bağlantıyı DataAccess kısmında kurduğumuz için, ben de listeleri database
                                                // gibi burada kullandım.

        public CampaignCouponDal(List<CampaignCoupon> coupons)
        {
            _coupons = coupons;                 
        }
        public CampaignCoupon GetById(int id)
        {
            return _coupons[id - 1];          // return değeri kullanım sırasında ekrana yazdıralarak kontrol edilebilir.    
                                            // Id sırası 1 den başladığı için -1 işlemi yapılmıştır. 
                                            
        }

        public void GetAll()
        {
            Console.WriteLine("\nExisting coupons in system:\n");
            Console.WriteLine("\n------------------------------\n");
            foreach (var coupon in _coupons)
            {
                Console.WriteLine(coupon.Id + ". %" + coupon.Discount+" " + coupon.Name + "\n\t");
                // Kampanya listesini GetAll() metodu yardımıyla, "1. Kampanya İsmi
                //                                                    Açıklama: ..." şeklinde print ediyor olacağız
            }
            Console.WriteLine("\n------------------------------\n");
        }

        public void Add(CampaignCoupon coupon)
        {
            _coupons.Add(coupon);   // Ekleme işlemi
            Console.WriteLine("New coupon has been defined\n");
        }

        public void Update(int id, CampaignCoupon coupon)
        {
            
            _coupons[id - 1] = coupon;
            Console.WriteLine(_coupons[id - 1].Name+" has been updated\n");                    
                                  // Listeden kullanıcı tarafından güncellenmesi istenen değerin id'sini kullanarak
                                  // mevcut değerin yerine yeni bir kullanıcı tanımlayıp, yeni özellikler girerek güncellenecektir.
        }

        public void Delete(int id)
        {
            Console.WriteLine(_coupons[id-1].Name +" has been deleted from system\n");
            _coupons.Remove(_coupons[id - 1]); // Listeden kullanıcı tarafından silinmesi istenen değerin id'sini kullanarak
                                           // mevcut değerin yerine yeni bir kullanıcı tanımlayıp, yeni özellikler girerek silinecektir.
        }
    }
}
