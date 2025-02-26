# Turkish Playfair Cipher with .NET MAUI

Alphabet = A B C Ç D E F G Ğ H I İ J K L M N O Ö P R S Ş T U Ü V Y Z X W Q ( ) . ,

## 🔐 Playfair Şifresi Nedir ve Nasıl Çalışır?

**Playfair Şifresi**, 19. yüzyılda Charles Wheatstone tarafından geliştirilmiş bir şifreleme algoritmasıdır. Bu algoritma, özellikle **Çift Harf (Digraph)** şifreleme tekniğini kullanarak güvenli iletişim sağlamak için tasarlanmıştır. Playfair, metni çiftler halinde şifreler ve bu çiftleri şifrelerken belirli kurallar uygular. Bu, klasik **Caesar Cipher** gibi basit şifreleme yöntemlerine göre daha güçlü bir şifreleme sağlar.

### **Playfair Şifresi Nasıl Çalışır?**

1. **Anahtar Matrisi Oluşturma:**
   Playfair şifresi için önce bir **anahtar matrisi** oluşturulması gerekir. Bu matris, **5x5**'lik bir ızgara şeklinde düzenlenir (ancak bu projede **6x6** kullanılmıştır). Anahtar metnindeki her harf, bu matrise yerleştirilir. Türkçe karakterler (Ç, Ş, İ, Ü, Ö, Ğ, vb.) ve özel karakterler (. , ( ) ) da bu matrisin içine eklenir.

   - Anahtar metnindeki tekrarlayan harfler çıkarılır.
   - Eğer harf sayısı 25'ten azsa (5x5 matris için), geri kalan yerler alfabetik sırayla doldurulur. Bu projede ise 6x6 bir matris kullanıldığı için daha fazla karakter kullanılabilir.

2. **Metnin Hazırlanması:**
   Şifrelenecek metin, **büyük harflerle** yazılır ve boşluklar kaldırılır. Eğer metnin uzunluğu tek sayıda ise, sonuna **"X"** harfi eklenir (bazı uygulamalarda bu harf farklı olabilir).

3. **Metnin Çiftlere Ayrılması:**
   Şifreleme işlemi için metin, **iki harflik çiftler** halinde gruplara ayrılır. Örneğin, "HELLO" kelimesi "HE", "LL", "OX" şeklinde ayrılır. Eğer aynı harf iki kez ardışık olarak gelirse, ikinci harf yerine başka bir harf (örneğin, "X") eklenir.

4. **Şifreleme Kuralları:**
   Şifreleme işlemi için üç temel kural vardır:

   - **Aynı Satırda Olan Harfler:** Eğer iki harf aynı satırda ise, her bir harf bir sonraki sütuna taşınır (matrisin sonuna gelindiğinde, başa dönülür).
   - **Aynı Sütunda Olan Harfler:** Eğer iki harf aynı sütunda ise, her bir harf bir sonraki satıra taşınır (matrisin sonuna gelindiğinde, başa dönülür).
   - **Farklı Satır ve Sütundaki Harfler:** Eğer harfler hem farklı satırda hem de farklı sütunda ise, her bir harf karşılıklı olan iki harfin bulunduğu pozisyonları değiştirir. Yani, bir harf diğer harfin bulunduğu satırda ve sütunda yer alacak şekilde yer değiştirilir.

5. **Şifre Çözme:**
   Şifre çözme işlemi de şifrelemeye benzer şekilde yapılır, ancak kurallar tersine uygulanır:
   
   - Aynı satırdaki harfler, bir öncekine doğru kaydırılır.
   - Aynı sütundaki harfler, bir önceki satıra kaydırılır.
   - Farklı satır ve sütundaki harfler, yine karşılıklı yer değiştirilir.

### **Örnek Uygulama:**

Diyelim ki şifrelenecek metin **"HELLO"** ve anahtar kelimesi **"KEY"**. Anahtar kelimesiyle 6x6'lık bir Playfair matrisi oluşturduktan sonra, "HELLO" metni şu adımlarla şifrelenir:

- **Adım 1:** Anahtar matrisi oluşturulur.
- **Adım 2:** Metin "HE", "LL", "OX" olarak çiftlere ayrılır.
- **Adım 3:** Şifreleme kurallarına göre her bir çift şifrelenir.
- **Adım 4:** Sonuçta, şifreli metin elde edilir.

Playfair şifresi, şifre çözme işlemi için de aynı kuralları tersine uygular ve metni çözmenizi sağlar.

---

Bu şifreleme algoritması, güvenliği artırmak ve metinlerin şifrelenmesini kolaylaştırmak için yaygın bir şekilde kullanılmıştır. Ancak günümüzde daha güçlü şifreleme yöntemleri bulunmaktadır. Bu projede, temel şifreleme mantığını öğrenmek ve uygulamak amacıyla Playfair Şifresi seçilmiştir.



