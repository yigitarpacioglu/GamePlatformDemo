using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using GamePlatformDemo.Business.Concrete;
using GamePlatformDemo.DataAccess.Abstract;
using GamePlatformDemo.DataAccess.Adapters;
using GamePlatformDemo.DataAccess.Concrete;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();                      // Standart üyelikler için liste oluşturuldu.
            MernisServiceAdapter adapter = new MernisServiceAdapter();
            MemberDal memberDal = new MemberDal(members, adapter);          // Listelere ulaşımda gerekli olan MemberDal instance'ı oluşturuldu.
            AccountManager accountManager = new AccountManager(memberDal);  // Hesap yönetimi için gerekli olan nihai araç, accountManager'a
            
            
            
            accountManager.SignUp(new Member()                    // Listeye başlangıç ataması için bir adet üye atandı.
            {
                DateOfBirth = new DateTime(1995, 3, 12),
                Id = 1,
                Name = "Yiğit",
                Lastname = "Arpacıoğlu",
                TC = 1111111111                       // Hata alınmaması adına gerçek kullanıcı bilgileri girilmelidir.
            });

            accountManager.ListAccounts();


            // ait bir instance oluşturuldu.

            //accountManager.SignUp(new Member()
            //{
            //    DateOfBirth = new DateTime(1994, 2, 23),
            //    Id = 2,
            //    Name = "AAAA",
            //    Lastname = "BBBBBB",
            //    TC = 12345678912
            //});

            //accountManager.SignUp(new Member()
            //{
            //    DateOfBirth = new DateTime(1995, 9, 11),
            //    Id = 3,
            //    Name = "CCCCCC",
            //    Lastname = "DDDDDDD",
            //    TC = 98765432198
            //});                                                         // Yeni üyeler eklenebilir. Fakat hatalı üyelerin MERNIS'e takılabileceği göz önünde bulundurulmalıdır.

            accountManager.UpdateAccount(1, new Member()
            {
                DateOfBirth = new DateTime(1995, 3, 12),
                Id = 1,
                Name = "Yiğit",
                Lastname = "Arpacıoğlu",
                TC = 11111111111111                                      // Hata alınmaması adına gerçek kullanıcı bilgileri girilmelidir.
            }); ;                                                        // güncelleme işlemi yapıldı.
            
            // accountManager.DeleteAccount(3);                           // hesap silindi.
            
            accountManager.ListAccounts();
            
            List<CampaignCoupon> coupons = new List<CampaignCoupon>()
            {
                new CampaignCoupon()
                {
                    Id = 1,
                    Discount = 35,
                    Name = "Spring Deal"
                },
                new CampaignCoupon()
                {
                    Id = 2,
                    Discount = 15,
                    Name = "Halloween Deal"
                },
                new CampaignCoupon()
                {
                    Id = 3,
                    Discount = 70,
                    Name = "New eve coupon"
                }
            };                                                           // Kampanyalar oluşturuldu.

            CampaignCouponDal campaignCouponDal = new CampaignCouponDal(coupons);
            CampaignCouponManager campaignCouponManager = new CampaignCouponManager(campaignCouponDal);

            campaignCouponManager.DefineNewCoupon(new CampaignCoupon()
            {
                Id = 4,
                Discount = 10,
                Name = "New membership discount(Valid for 15 days)"
            });
            campaignCouponManager.DeleteCoupon(4);
            campaignCouponManager.ListCoupons();
            List<GameEdition> gameEdition = new List<GameEdition>()
            {
                new GameEdition()
                {
                    Id = 1,
                    Name = "Basic",
                    Price = 80,
                },
                new GameEdition()
                {
                    Id = 2,
                    Name = "Premium",
                    Price = 125,
                },
                new GameEdition()
                {
                    Id = 3,
                    Name = "Legendary",
                    Price = 155,
                }
            };                                                              // oyun sürümleri tanımlandı.


            List<Sale> salesList = new List<Sale>();                        // yeni bir satış listesi oluşturuldu
            List<Member> customers = new List<Member>();                    // Satın alım yapan üyelikler için müşteri listesi tanımlandı.
            SaleManager saleManager = new SaleManager(salesList, customers, memberDal) { };
            saleManager.ListSales();                                        // tüm elemanlar listelendi.
            int discount = saleManager.Discount(coupons[1]);                // Discount fonksiyonu ile kupon seçimi yapıldı. 
                                                                            // Liste elemanı ile seçim yapıldığı için sıralamanın 0'dan başladığı düşünülmelidir.
            saleManager.BuyGame(gameEdition[0], members[0], discount);        // Yine liste elemanları ile satın alım gerçekleştirildi.
            saleManager.Refund(salesList[0]);                               // Satın alınan ürün geri iade edildi.tea




        }
    }
}
