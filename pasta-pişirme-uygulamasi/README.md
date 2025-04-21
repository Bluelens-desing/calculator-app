# Pasta Pişirme Süreç Uygulaması

Bu C# Windows Forms uygulaması, bir pastanın yapım sürecini adım adım simüle eder. Uygulama; karıştırma, çırpma, tekrar karıştırma ve pişirme aşamalarını içerir ve bu işlemleri ilerleme çubukları (progress bar) ile görsel olarak gösterir.

--Özellikler--

- Aşama Aşama Süreç Takibi:** Karıştırma, çırpma, yeniden karıştırma ve pişirme adımları sırayla ilerler.
- İlerleme Çubukları:** Her adım için ayrı bir progress bar ile animasyon.
- Duraklatma ve Devam Ettirme:** Süreci istediğin zaman durdurup tekrar başlatabilirsin.
- Hazır Olduğunda Bildirim:** Tüm işlemler tamamlandığında mesaj kutusu ile bilgi verilir.
- Sıfırlama:** Süreci sıfırlamak için buton desteği.
- Renkli Geri Bildirim:** Aşamalar sırasında arka plan renk değişimleriyle kullanıcı bilgilendirilir.

--Kullanım--

1. **Başlat** butonuna tıklayarak süreci başlat.
2. Aşamalar otomatik olarak sırayla başlar ve tamamlandıkça bir sonrakine geçilir.
3. **Duraklat** butonuyla süreci geçici olarak durdurabilir, tekrar çalıştırabilirsin.
4. **Sıfırla** butonuyla tüm süreçleri başa alabilirsin.
5. Tüm işlemler tamamlandığında “Pastamız hazır oldu :)” mesajı görünür.

--Teknik Bilgiler--

- .NET Windows Forms ile geliştirildi.
- `Timer`, `ProgressBar`, `Label`, `MessageBox` gibi temel UI bileşenleri kullanıldı.
- `Color` sınıfı ile görsel geçişler sağlandı.
