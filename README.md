## Abstract Factory Design Pattern

### Çalışma Mantığı

Yapılan sistemimizde soyutlamaları sağlamak amacıyla interface'ler ve abstract sınıflar kullanırız demiştik Bu desende mevcut bulunan yapıya uymayan bir sınıfı entegre etme tekniği incelenecektir. Yani çalışan sisteme yeni bir özelliğini eklenmesini kolaylaştıran bir tekniktir. Bunu yapmak için ayrı bir adaptör sınıfı yazılır ve bu sınıftan adapte edilmeye çalışılan sınıfa bir referans vardır. Bu sayede yazılmış olan adaptör sınıfı mevcut yapıya entegre bir şekilde çalışabilir. Aslında yapılan iş arka tarafta sisteme yeni bir arayüz kazandırmakta farklı bir şey değildir.

### Ne zaman kullanılır?

Adaptör kelimesinin günlük hayattaki karşılığı da benzer bir işlevi yerine getirmektedir. Bilgisayarlarımızın adaptörleri vardır. Bilgisayarın istemiş olduğu elektrik voltajı bellidir. Ancak priz voltajdan çok daha yükseğini verir. İşte adaptörü kullanarak çıkan voltajı istenen seviyeye çekme işlemi gerçekleştirilir.

Orta ve büyük ölçekli projeleri iş hayatında genelde tek bir kişi yapmaz. Bazı durumlarda birden fazla ekip bile aynı projede görev alabilir. Diğer yazılımcılar kendi sistemlerine çoğu zaman daha önceden yazılmış parçaları entegre etmek isterler. Bu tarz bir senaryoda adaptör tasarım deseni ihtiyaç duyarlar. Bu durum aynı şekilde para ile satın alınan veya açık kaynak kodlu bir üçüncü parti bileşen veya Frameworkte olabilir. Bu tarz durumlarda da sisteme entegre etmek için adaptör tasarım deseni kullanılır.

Aisteme yeni bir log kütüphanesi eklendiğinde, sistemi yeni bir veri erişim kaynağı ilave edildiğinde, sisteme yeni bir şifreleme algoritması entegre edildiğinde, sistemin genişletilmesi için yapılan yeni tedarikçi firma eklenmesi gibi senaryolarda eklemek istediğiniz sistem bizim sistemimizin arayüzüne çoğu zaman uymaz. Bu tarz bir durumda mevcut kodu değiştiremeyiz. Kendi projemizin kodlarını da değiştirmemiz zaten söz konusu olamaz. Bu desendeki teknik sayesinde sistemimizin arayüzünü bozmadan kolayca dış sistem kaynaklarını ekleyebiliriz.

### Örnek

Mevcut bir projemiz vardı. Binlerce serviste, metotda kendi yazdığımız log sistemini kullanıyorduk. Daha sonra projeye nugetten yeni bir log sistemi entegre ettiğimizi düşünelim. Bu sistemi hiçbir yeri değiştirmeden mevcut sistemimize entegre edeceğiz.
