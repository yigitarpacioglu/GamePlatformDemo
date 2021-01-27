# GamePlatformDemo
Kod içerisinde de elimden geldiği kadar yorum eklemeye çalıştım.

Uygulamada bir oyun için çeşitli planlar bulunmaktadır. (Ben 3 tane ekledim dilerseniz Business katmanındaki Program.cs içerisinde ekleyebilirsiniz.)
Tanımlanan farklı kuponlarla seçilen plana göre indirim uygulanmaktadır.
Kullanıcalar oyun platformuna ücretsiz hesap açabilmektedirler (members).
Satın alımlar sonucunda alım yapan üyeler müşteri listesine eklenmektedir.(customers)
Not: İki liste de Member türündedir.

Tanımlanan kuponlar da ayrı bir listede tutulmaktadır.(coupons)
Satışlar ayrı bir listede tutulmaktadır.(salesList)

Mimari 3 katmandan oluşmaktadır: 
# 1. GamePlatformDemo.Entities
Burada property tutan sınıflarım bulunmaktadır. 
Ortak özellikleri IEntity şeklinde bir interface aracılığıyla kazandırmaktayım.
# 2. GamePlatformDemo.DataAccess
Normal projeler içerisinde de Visual Studio ve Database arasındaki bağlantıları bu katmanda gerçekleştiğinden, ben de listelerimin kullanımını bu alanda sağlamaya çalıştım.
Ayrıca bir validasyon aracı olan Mernis'i de projeye bu alanda yerleştirdim.
# 3. GamePlatformDemo.Business
Business katmanında ise, nihai hedefim olan satın alım, indirim, hesap hareketleri gibi aktiviteleri bu katmanda sağladım.

Detaylar için projeye göz atmanız daha iyi olacaktır.
