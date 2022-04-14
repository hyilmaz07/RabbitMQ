**RabbitMQ Nedir?**

RabbitMQ bir mesaj kuyruğu sistemidir. Amacı herhangi bir kaynaktan alınan bir mesajın, bir başka kaynağa sırası geldiği anda iletilmesidir. Burada yapılacak işler bir sıraya alınmaktadır. İletimin yapılacağı kaynak ayağa kalkana kadar, tüm işlemler bir queue’da sıralanır.

**Peki neden kullanılmalıdır?**
Bazı işlemlerin anlık yapılmasına ihtiyaç yoktur. Sıraya alınan bu işlemlerin asenkron bir şekilde yapılması, hem çalışan uygulamanın boş yere bekletilmemesinden hem de sunucu üzerindeki işlem maliyetinin minimuma indirilmesinden dolayı RabbitMQ iyi bir tercih sebebidir.

**RabbitMQ’nun çalışma mantığı ve bilinmesi gereken bazı terimler**

**Producer :** Mesajı atan kaynak yani uygulamadır.

**Queue :** Gönderilen mesajlar alıcaya ulaştırılmadan önce bir sıraya konur. Gelen yoğunluğa göre veya alıcıya erişilemediği durumlarda, gelen tüm mesajlar Queue’de yani memory’de saklanır. Eğer bu süreç uzun sürer ise memory şişebilir. Ayrıca server’ın restart edilmesi durumunda ilgili mesajlar kaybolabilir.

**Consumer :** Gönderilen mesajı karşılayan sunucudur. ilgili kuyruğu(Queue)’yu dinleyen taraftır.

**Fifo :** RabbitMQ’da giden mesajların işlem sırası first in first out yani ilk giren ilk çıkar şeklindedir.

**Direct exchange :** Yapılacak işlere göre bir routing key belirlenir ve buna göre ilgili direct exchange ile amaca en uygun queue gidilir.

![image](https://user-images.githubusercontent.com/28646708/163357562-a708af7d-d02b-4596-88bd-6f9deb79f5ef.png)

**Fanout exchange :** Burada routing key’in bir önemi yoktur. Daha çok broadcast yayınlar için uygundur. Özellikle (MMO) oyunlarda top10 güncellemeleri ve global duyurular için kullanılır. Yine real-time spor haberleri gibi yayınlarda fanout exchange kullanılır.

![image](https://user-images.githubusercontent.com/28646708/163357652-60687ce6-ec59-4650-813c-c236f745ee38.png)

**Topic Exchange :** Bir route mesajın bir veya daha çok queue’ye gitmesi amacı ile kullanılır. Publish/Subscribe pattern’in bir varyasyonudur. Eğer ilgili sorun birkaç consumer’i alakadar ediyor ise, hangi çeşit mesajı almak istediklerini belirlemek için Topic Exchange kullanılmalıdır.

![image](https://user-images.githubusercontent.com/28646708/163357900-3fb7b572-1337-4e50-b24a-c9ad590f8582.png)

**Headers Exchange :** Yine bu exchange de routing key’i kullanmaz ve message headers’daki birkaç özellik ve tanımlama ile doğru queue’ye iletim yapar. Header üzerindeki attributeler ile  queue üzerindeki attributelerin, tamamının değerlerinin birbirini tutması gerekmektedir.

![image](https://user-images.githubusercontent.com/28646708/163358059-6f0300ad-2e36-44dd-9c86-152dd7d1dd66.png)
