
## C# Design Patterns Linkeldn Learning Kursu Notları

### Design Patterns(Tasarım Desenleri) kısaca nedir?
- Yazılımlarımızı oluşan hataları çözmek için kullanılan yeniden kullanılabilir çözümler diyebiliriz.Bu çözümler üç farklı kategorilere ayrılmaktadır.Bu kategoriler:Creational(Yaratıcı),Behavioral(Davranışsal) ve Structural(Yapıcı) şeklinde üçe ayrılır.Peki bu kategorileri biraz açmadan önce neden tasarım desenlerine ithiyaç var bundan bahsedelim

### Neden tasarım desenleri ithiyaç olunabilir ya da olunur?
- Tasarım desenlerin nihai olarak sunduğu faydalara baktığımız da:Test edilebilirlik,Tekrardan kullanabilirlik ve yeni gelen değişiklikleri kolaylıkla mevcut kodlarımızda adapte edebilmek yani yeni ilaveler yapıldığında mevcuttaki kodların etkilenmemesi gerekir.
- Şimdi eğer çok da büyük olmayan bir proje geliştiriyorsak 20-30 satırlık bir kodsa tasarım deseni kullanmak birazcık işi bir tık karma karışık yapabilir ki zaten yapmassa bile çok da üzerinde değişiklikler olmayacaksa,test ithiyacı olmayacaksa vs. ithiyaç yoktur.
- Ama büyüyen bir proje ise ve yarın öbür gün yeni istek gelecekse ki buna göre de kodlarda değişiklikler olacaktır ki mevcut kodların da çok da etkilenmemesi lazım işte burada OOP'in nimetlerini kullanılacaktır.Zaten tasarım desenleri de OOP'in nimetlerini fazlasıyla kullanmaktadır.Soyutlamalar olsun kalıtımlar olsun kullanılmaktadır.

- Tasarım desenlerin büyük projelerde kullandığımızda gelecek olan yeni taleplerle beraber oluşacak büyük değişiklikleri öngörmemizi ve ona göre de mevcuttaki kodların da zarar görmemesini sağlar.Ayrıca tasarım desenleri yardımıyla yazdığımız kodları bir şekilde yeniden kullanmamıza da imkan sağlar.
- Mesela mevcut sınıfın miras aldığı soyut sınıfı yardımıyla yeni bir sınıfı da yine o soyut sınıftan miras edersek yeni gerçek sınıfımız bizim mevcuttaki gerçek sınıfımızın da metotlarını kullanabilir;ama farkı şudur ki:metotun döndüreceği  değer ya da yapacağı işlemlerde iş sürecine göre farklı olacaktır.Bu da soyutlamanın bize sunduğu imkandır.Zaten tasarım desenleri bu dediğimiz soyutlama ve miras alma denilen nimetleri kullanmakta bu da tasarım desenlerin yeniden kullanılabilirliğini artırıyor.

- Veya bir obje ya da nesne tanımlarken verdiğimiz bir özellik ya metot tanımlaması sonucu yine kendisi döndürüyor ise yine o metot ya da özelliği dinamik olarak o ilgili nesneye verebiliriz ki bu tasarım desenleri Fluent Interface tasarım desenine örnek olabilir ki görüldüğü üzere özellikler ya metotlar yeniden verilebilir diyoruz bakın.Yani yine olay yeniden kullanılabilirlik.Ayrıca o objeye dinamik olarak verilen metot ya özelliklerin miras aldığı soyut sınıfında hele tanımlamışsa ki yine benzer başka bir sınıf oluşturduğumuzda ve soyut sınıftan yeni sınıfa miras verdiğimizde görüleceği üzere yine yeni sınıftan obje üretildiğinde yine dinamik olarak metot ve özellik eklenebilir hatta aynıları bir daha da eklenebilir.Neden?Çünkü soyut sınıfımızda bunu tanımlamış ya da imzasını oluşturmuşuz yine o metotun kendisini döndüreceğine dahil.Yine sınıflar,yine soyutlama ve yine kalıtım.İşte tasarım desenleri bu nimetlerden fazlasıyla faydalanmaktadır. 

- Buradan anlaşılacağı üzere uzatılabilir ya da esnetilebilir yani kısacası devamlı büyüyebilecek,yeni özellikler eklenip mevcut sistemdeki de etkilenmeyip hatta o bile kullanılabilecek bir proje geliştirmeye çalışıyorsanız tasarım desenleri ithiyacınız olacak olan yapılardır.Evet bundan sonrasında üç çeşit var demiştik bunları biraz açıklayalım :)


### Creational,Structural ve Behavioral çeşitleri nedir?

####  Creational(Yaratıcı)
- Creational dediğimiz aslında objenin oluşturulma mantığı saklanılırken direk objenin kendisini oluşturabilmemize yol ya da imkan sunan tasarım desenlerin kategorik ismidir diyebiliriz.Yaratımsal tasarım desenleri,direk nesnenin nasıl oluşturalacağı hakkında spesifik bir tanımlama konmadan bağımsız bir şekilde nesnenin nasıl oluşturalacağı ile ilgilenenlerdir.

### 





