using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GamePlatformDemo.Business.Abstract;
using GamePlatformDemo.DataAccess.Concrete;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Concrete
{
    public class SaleManager:ISaleService       // Interface aracılığıyla gerekli fonksiyonlar aşağıda implemente edilmiştir.
    {
        private List<Sale> _salesList;          // Yine satışların sembolik olarak kaydının tutulması adına liste oluşturuldu.
        private List<Member> _customerList;     // Ayrıca ücretsiz hesap açan üyeliklerin(members) satın alım yapması durumunda
        private MemberDal _memberDal;           //    müşteri listesine ekleme yapıldı.
        
        private int sales=1;                    // Local kullanımda tricky yöntem için gerekli bir değişken.

        public SaleManager(List<Sale> salesList, List<Member> customerList, MemberDal memberDal)
        {
            _salesList = salesList;             // constructor vasıtasıyla kullanım sırasında alınacak olan listelerin eşitlenme aşaması
            _customerList = customerList;
            _memberDal = memberDal;
        }

        public void BuyGame(GameEdition edition, Member customer, int discount=0)       // Satın alım metodu
        {
            
            edition.Price -= edition.Price * discount / 100;            // Olası bir kupona karşı indirim hesaplaması
            _salesList.Add(new Sale                                     
            {
                Name = edition.Name, 
                GameEditionId = edition.Id, 
                CustomerId = customer.Id, 
                Id = sales,
                Price = edition.Price                                   // Satın alımın satış geçmişi listesine eklenmesi
            });
            sales++;                                                    //Yukarıda belirtilen sales değişkeni yeni satış Id'sini belirlemektedir.
            Console.WriteLine("\n"+customer.Name + ", bought " + edition.Name + " edition for " + edition.Price+ " TL\n");
            if (!_customerList.Contains(customer))
            {
                _customerList.Add(customer); // Satış yapıldığı için <Member> formatında oluşturulan Customers listesine müşteri kaydedildi
                                             // Fakat müşteri liste içerisinde mevcut ise kaydedilmiyor.
            }
        }

        public void Refund(Sale sale)
        {
            Console.WriteLine("\n"+"Sale with Id: " + sale.Id + " has been refunded to customer(ID="+sale.CustomerId+")"+ "\n");
            _salesList.Remove(_salesList[sale.Id-1]);       // İade durumunda satış listeden çıkarılıyor.
        }

        public void ListSales()
        {
            foreach (var sale in _salesList)
            {
                Console.WriteLine(sale.Id+". "+"Customer: "+_customerList[sale.Id-1]+""+sale.GameEditionId);
            }
        }

        public int Discount(CampaignCoupon coupon)
        {
            Console.WriteLine("\n"+coupon.Name+" coupon has been approved\n");
            return coupon.Discount;                         // Uygulanan kupona göre indirim oranı int değeri olarak, oyun satın
                                                            // alımı sırasında BuyGame metodunda kullanılmak üzere geri döndürülüyor.
        }                                               
        
        // Net kullanımını Business modülü içerisindeki main programında bulabilirsiniz. 
    }
}
