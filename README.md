<div align="center">

# 🍽️ Yummy Restaurant - API Proje Kampı

<img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8"/>
<img src="https://img.shields.io/badge/Entity%20Framework-Core%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt="EF Core"/>
<img src="https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server"/>
<img src="https://img.shields.io/badge/Swagger-API%20Docs-85EA2D?style=for-the-badge&logo=swagger&logoColor=black" alt="Swagger"/>
<img src="https://img.shields.io/badge/OpenAI-GPT--4o-412991?style=for-the-badge&logo=openai&logoColor=white" alt="OpenAI"/>
<img src="https://img.shields.io/badge/Hugging%20Face-AI%20Models-FFD21E?style=for-the-badge&logo=huggingface&logoColor=black" alt="Hugging Face"/>

<br/>

**Murat Yücedağ** tarafından sunulan **Api Proje Kampı** eğitimi kapsamında geliştirilen, modern ve kapsamlı bir restoran yönetim sistemi.

[📖 Eğitim Detayları](#-eğitim-detayları) •
[🛠️ Teknolojiler](#️-kullanılan-teknolojiler) •
[📡 API Endpoints](#-api-end-pointleri) •
[🚀 Kurulum](#-kurulum-ve-çalıştırma)

</div>

---

## 📑 İçindekiler

- [🎯 Proje Detayları](#-proje-detayları)
- [📖 Eğitim Detayları](#-eğitim-detayları)
- [🛠️ Kullanılan Teknolojiler](#️-kullanılan-teknolojiler)
- [🤖 Yapay Zeka API Entegrasyonları](#-yapay-zeka-api-entegrasyonları)
- [📡 API End-Pointleri](#-api-end-pointleri)
  - [Products (Ürünler)](#products-ürünler)
  - [Categories (Kategoriler)](#categories-kategoriler)
  - [Reservations (Rezervasyonlar)](#reservations-rezervasyonlar)
  - [Messages (Mesajlar)](#messages-mesajlar)
  - [Chefs (Şefler)](#chefs-şefler)
  - [Services (Servisler)](#services-servisler)
  - [Features (Özellikler)](#features-özellikler)
  - [Testimonials (Referanslar)](#testimonials-referanslar)
  - [Abouts (Hakkında)](#abouts-hakkında)
  - [Contacts (İletişim)](#contacts)
  - [Events (Etkinlikler)](#events-etkinlikler)
  - [Notifications (Bildirimler)](#notifications-bildirimler)
  - [Images (Görseller)](#images-görseller)
  - [Group Reservations (Grup Rezervasyonları)](#group-reservations-grup-rezervasyonları)
  - [Employee Tasks (Çalışan Görevleri)](#employee-tasks-çalışan-görevleri)
  - [Statistics (İstatistikler)](#statistics-i̇statistikler)
- [📸 Projeden Görseller](#-projeden-görseller)
- [🚀 Kurulum ve Çalıştırma](#-kurulum-ve-çalıştırma)
- [🤝 Katkıda Bulunma](#-katkıda-bulunma)

---

## 🎯 Proje Detayları

**Yummy Restaurant** projesi, bir restoran işletmesinin tüm dijital ihtiyaçlarını karşılamak üzere tasarlanmış **full-stack** bir web uygulamasıdır. Proje, modern yazılım mimarisi prensiplerini takip ederek geliştirilmiştir.

### ✨ Temel Özellikler

| Özellik | Açıklama |
|---------|----------|
| 🍕 **Ürün Yönetimi** | Menü ürünlerinin kategorilere göre yönetimi ve listelenmesi |
| 📅 **Rezervasyon Sistemi** | Online masa rezervasyonu oluşturma ve takip etme |
| 👨‍🍳 **Şef Profilleri** | Restoran şeflerinin profillerini yönetme |
| 💬 **Mesajlaşma** | Müşteri mesajlarını alma ve yönetme |
| 🔔 **Bildirim Sistemi** | Gerçek zamanlı bildirim yönetimi |
| 🎉 **Etkinlik Yönetimi** | Özel günler ve etkinliklerin duyurulması |
| 📊 **İstatistikler** | Dashboard için anlık istatistik verileri |
| 🖼️ **Galeri Yönetimi** | Restoran görsellerinin yönetimi |
| 📝 **Referans Sistemi** | Müşteri yorumları ve referansları |
| 👥 **Grup Rezervasyonları** | Özel organizasyonlar için toplu rezervasyon |
| ✅ **Görev Yönetimi** | Personel görev takip sistemi |
| 🤖 **AI Yemek Önerileri** | OpenAI ile malzemelere göre tarif üretme |
| 💬 **AI Sohbet Asistanı** | GPT-4o ile gerçek zamanlı sohbet (SignalR) |
| 🛡️ **İçerik Moderasyonu** | Hugging Face ile toksik mesaj algılama |

### 🏗️ Mimari Yapı

```
📦 ApiProjeKampi
├── 🔧 ApiProjeKampi_WebAPI     # RESTful API Katmanı
│   ├── Controllers/            # API Controller'ları
│   ├── Context/                # Entity Framework DbContext
│   ├── DTOs/                   # Data Transfer Objects
│   ├── Entities/               # Veritabanı Entity'leri
│   ├── Mapping/                # AutoMapper Profilleri
│   ├── Migrations/             # EF Core Migration'ları
│   └── ValidationRules/        # FluentValidation Kuralları
│
└── 🌐 ApiProjeKampi_WebUI      # MVC Web Arayüzü
    ├── Controllers/            # MVC Controller'ları
    ├── DTOs/                   # UI Data Transfer Objects
    ├── Models/                 # ViewModel'ler ve SignalR Hub
    ├── ViewComponents/         # Reusable View Components
    ├── Views/                  # Razor View'ları
    └── wwwroot/                # Static Dosyalar (CSS, JS, Images)
```

---

## 📖 Eğitim Detayları

<div align="center">

| 👨‍🏫 Eğitmen | 📺 Platform | 🎓 Eğitim Adı |
|-------------|-------------|---------------|
| **Murat Yücedağ** | YouTube | **Api Proje Kampı** |

</div>

### 🎯 Eğitimden Kazanılan Yetkinlikler

<table>
<tr>
<td width="50%">

**Backend Geliştirme**
- ✅ ASP.NET Core Web API geliştirme
- ✅ Entity Framework Core ile veritabanı işlemleri
- ✅ Code First yaklaşımı ve Migration yönetimi
- ✅ Repository Pattern ve katmanlı mimari
- ✅ AutoMapper ile nesne dönüşümleri
- ✅ FluentValidation ile veri doğrulama
- ✅ Swagger/OpenAPI entegrasyonu

</td>
<td width="50%">

**Frontend & Entegrasyon**
- ✅ ASP.NET Core MVC ile web uygulaması
- ✅ API consume etme teknikleri (HttpClient)
- ✅ ViewComponent kullanımı
- ✅ SignalR ile gerçek zamanlı iletişim
- ✅ Bootstrap ile responsive tasarım
- ✅ Admin panel geliştirme
- ✅ DTO (Data Transfer Object) kullanımı

</td>
</tr>
<tr>
<td colspan="2">

**🤖 Yapay Zeka Entegrasyonları**
- ✅ OpenAI API entegrasyonu (GPT-3.5-turbo, GPT-4o-mini)
- ✅ Hugging Face API entegrasyonu
- ✅ AI ile içerik üretimi (Tarif önerileri, Menü önerileri)
- ✅ Toksik içerik algılama ve moderasyon
- ✅ SignalR ile streaming AI yanıtları
- ✅ Çoklu dil desteği için AI çeviri

</td>
</tr>
</table>

---

## 🛠️ Kullanılan Teknolojiler

### Backend

| Teknoloji | Versiyon | Açıklama |
|-----------|----------|----------|
| ![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white) | 8.0 | Ana framework |
| ![EF Core](https://img.shields.io/badge/EF%20Core-512BD4?style=flat&logo=dotnet&logoColor=white) | 8.0.20 | ORM aracı |
| ![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white) | - | Veritabanı |
| ![AutoMapper](https://img.shields.io/badge/AutoMapper-BE161D?style=flat&logoColor=white) | 13.0.1 | Object mapping |
| ![FluentValidation](https://img.shields.io/badge/FluentValidation-1E90FF?style=flat&logoColor=white) | 12.0.0 | Veri doğrulama |
| ![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black) | 6.6.2 | API dokümantasyonu |

### Frontend

| Teknoloji | Açıklama |
|-----------|----------|
| ![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-512BD4?style=flat&logo=dotnet&logoColor=white) | Web framework |
| ![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=flat&logo=bootstrap&logoColor=white) | CSS framework |
| ![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=flat&logo=html5&logoColor=white) | Markup |
| ![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=flat&logo=css3&logoColor=white) | Styling |
| ![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=flat&logo=javascript&logoColor=black) | Client-side scripting |
| ![SignalR](https://img.shields.io/badge/SignalR-512BD4?style=flat&logo=dotnet&logoColor=white) | Real-time communication |

### Kullanılan Temalar
- 🎨 **Yummy** - Restoran teması (Vitrin)
- 🎨 **Otika** - Bootstrap admin teması (Yönetim Paneli)

---

## 🤖 Yapay Zeka API Entegrasyonları

Bu projede **yapay zeka destekli** özellikler için harici API'ler entegre edilmiştir. Bu sayede restoran yönetim sistemi akıllı öneriler sunabilmekte ve içerik moderasyonu yapabilmektedir.

### OpenAI API

<div align="center">

| Model | Kullanım Alanı | Özellik |
|-------|----------------|---------|
| ![GPT-3.5](https://img.shields.io/badge/GPT--3.5--Turbo-412991?style=flat&logo=openai&logoColor=white) | Yemek Tarifi Önerisi | Girilen malzemelere göre tarif üretme |
| ![GPT-3.5](https://img.shields.io/badge/GPT--3.5--Turbo-412991?style=flat&logo=openai&logoColor=white) | Mesaj Yanıtlama | Müşteri mesajlarına otomatik yanıt önerisi |
| ![GPT-4o-mini](https://img.shields.io/badge/GPT--4o--mini-412991?style=flat&logo=openai&logoColor=white) | Gerçek Zamanlı Sohbet | SignalR ile streaming AI chat |
| ![GPT-4](https://img.shields.io/badge/GPT--4-412991?style=flat&logo=openai&logoColor=white) | Günlük Menü Önerisi | Dünya mutfaklarından rastgele menü oluşturma |

</div>

#### 🍳 Yemek Tarifi Önerisi (AI Recipe Generator)
```
Kullanıcı malzemelerini girer → OpenAI GPT-3.5-turbo → Özelleştirilmiş yemek tarifi
```
- **Endpoint:** `/AI/CreateRecipeWithOpenAI`
- **Model:** `gpt-3.5-turbo`
- **Açıklama:** Kullanıcının girdiği malzemelere göre restoran tarzında yemek tarifleri önerir

#### 💬 Akıllı Mesaj Yanıtlama
```
Müşteri mesajı → OpenAI GPT-3.5-turbo → Profesyonel yanıt önerisi
```
- **Endpoint:** `/Message/AnswerMessageWithOpenAI`
- **Model:** `gpt-3.5-turbo`
- **Açıklama:** Müşteri mesajlarına müşteri memnuniyetini gözeten profesyonel yanıtlar önerir

#### 🗨️ Gerçek Zamanlı AI Sohbet (SignalR + Streaming)
```
Kullanıcı sorusu → SignalR Hub → OpenAI GPT-4o-mini (Streaming) → Anlık yanıt
```
- **Hub:** `ChatHub`
- **Model:** `gpt-4o-mini`
- **Özellik:** Server-Sent Events ile token token gerçek zamanlı yanıt akışı

#### 🍽️ Günlük Menü Önerileri (Dashboard Widget)
```
Dashboard yükleme → OpenAI API → 4 farklı dünya mutfağından menü önerisi
```
- **ViewComponent:** `_DashboardAIDailyMenuSuggestionComponentPartial`
- **Özellik:** Her gün farklı ülke mutfaklarından (Türkiye, Fransa, İtalya, Çin vb.) rastgele menü önerileri

---

### Hugging Face API

<div align="center">

| Model | Kullanım Alanı | Açıklama |
|-------|----------------|----------|
| ![Translation](https://img.shields.io/badge/Helsinki--NLP-opus--mt--tr--en-FFD21E?style=flat&logo=huggingface&logoColor=black) | Çeviri | Türkçe → İngilizce çeviri |
| ![Toxic](https://img.shields.io/badge/Unitary-toxic--bert-FFD21E?style=flat&logo=huggingface&logoColor=black) | İçerik Moderasyonu | Toksik içerik algılama |

</div>

#### 🔤 Otomatik Çeviri (Translation)
```
Türkçe mesaj → Helsinki-NLP/opus-mt-tr-en → İngilizce metin
```
- **Model:** `Helsinki-NLP/opus-mt-tr-en`
- **Açıklama:** Müşteri mesajlarını içerik analizi için Türkçe'den İngilizce'ye çevirir

#### 🛡️ Toksik İçerik Algılama (Content Moderation)
```
Mesaj metni → unitary/toxic-bert → Toksiklik skoru → Otomatik etiketleme
```
- **Model:** `unitary/toxic-bert`
- **Eşik Değer:** %50 üzeri toksiklik skoru
- **Sonuç:** Toksik mesajlar otomatik olarak "Toksik Mesaj!" olarak işaretlenir

---

### 🔐 API Anahtarları Yapılandırması

Yapay zeka özelliklerini kullanabilmek için `.env` dosyasında aşağıdaki anahtarların tanımlanması gerekmektedir:

```env
OpenAIApiKey=sk-your-openai-api-key-here
HuggingFaceApiKey=hf_your-huggingface-api-key-here
```

> ⚠️ **Güvenlik Notu:** API anahtarlarınızı asla Git'e commit etmeyin. `.env` dosyasını `.gitignore`'a eklediğinizden emin olun.

---

## 📡 API End-Pointleri

> **Base URL:** `https://localhost:{port}/api`

### Products (Ürünler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Products` | Tüm ürünleri listeler |
| 🟡 `POST` | `/Products` | Yeni ürün oluşturur |
| 🔵 `PUT` | `/Products` | Ürün bilgilerini günceller |
| 🔴 `DELETE` | `/Products?id={id}` | Belirtilen ürünü siler |
| 🟢 `GET` | `/Products/GetProduct?id={id}` | ID'ye göre ürün getirir |
| 🟢 `GET` | `/Products/ProductListWithCategory` | Kategorileriyle birlikte ürünleri listeler |

### Categories (Kategoriler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Categories` | Tüm kategorileri listeler |
| 🟡 `POST` | `/Categories` | Yeni kategori oluşturur |
| 🔵 `PUT` | `/Categories` | Kategori bilgilerini günceller |
| 🔴 `DELETE` | `/Categories?id={id}` | Belirtilen kategoriyi siler |
| 🟢 `GET` | `/Categories/GetCategory?id={id}` | ID'ye göre kategori getirir |

### Reservations (Rezervasyonlar)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Reservations` | Tüm rezervasyonları listeler |
| 🟡 `POST` | `/Reservations` | Yeni rezervasyon oluşturur |
| 🔵 `PUT` | `/Reservations` | Rezervasyon bilgilerini günceller |
| 🔴 `DELETE` | `/Reservations?id={id}` | Belirtilen rezervasyonu siler |
| 🟢 `GET` | `/Reservations/GetReservation?id={id}` | ID'ye göre rezervasyon getirir |
| 🟢 `GET` | `/Reservations/GetTotalReservationCount` | Toplam rezervasyon sayısını döner |
| 🟢 `GET` | `/Reservations/GetTotalCustomerCount` | Toplam müşteri sayısını döner |
| 🟢 `GET` | `/Reservations/GetPendingReservations` | Bekleyen rezervasyon sayısını döner |
| 🟢 `GET` | `/Reservations/GetApprovedReservations` | Onaylanan rezervasyon sayısını döner |
| 🟢 `GET` | `/Reservations/GetReservationStats` | Rezervasyon istatistiklerini döner (Grafik) |

### Messages (Mesajlar)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Messages` | Tüm mesajları listeler |
| 🟡 `POST` | `/Messages` | Yeni mesaj oluşturur |
| 🔵 `PUT` | `/Messages` | Mesaj bilgilerini günceller |
| 🔴 `DELETE` | `/Messages?id={id}` | Belirtilen mesajı siler |
| 🟢 `GET` | `/Messages/GetMessage?id={id}` | ID'ye göre mesaj getirir |
| 🟢 `GET` | `/Messages/MessageListByIsReadFalse` | Okunmamış mesajları listeler |

### Chefs (Şefler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Chefs` | Tüm şefleri listeler |
| 🟡 `POST` | `/Chefs` | Yeni şef oluşturur |
| 🔵 `PUT` | `/Chefs` | Şef bilgilerini günceller |
| 🔴 `DELETE` | `/Chefs?id={id}` | Belirtilen şefi siler |
| 🟢 `GET` | `/Chefs/GetChef?id={id}` | ID'ye göre şef getirir |

### Services (Servisler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Services` | Tüm servisleri listeler |
| 🟡 `POST` | `/Services` | Yeni servis oluşturur |
| 🔵 `PUT` | `/Services` | Servis bilgilerini günceller |
| 🔴 `DELETE` | `/Services?id={id}` | Belirtilen servisi siler |
| 🟢 `GET` | `/Services/GetService?id={id}` | ID'ye göre servis getirir |

### Features (Özellikler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Features` | Tüm özellikleri listeler |
| 🟡 `POST` | `/Features` | Yeni özellik oluşturur |
| 🔵 `PUT` | `/Features` | Özellik bilgilerini günceller |
| 🔴 `DELETE` | `/Features?id={id}` | Belirtilen özelliği siler |
| 🟢 `GET` | `/Features/GetFeature?id={id}` | ID'ye göre özellik getirir |

### Testimonials (Referanslar)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Testimonials` | Tüm referansları listeler |
| 🟡 `POST` | `/Testimonials` | Yeni referans oluşturur |
| 🔵 `PUT` | `/Testimonials` | Referans bilgilerini günceller |
| 🔴 `DELETE` | `/Testimonials?id={id}` | Belirtilen referansı siler |
| 🟢 `GET` | `/Testimonials/GetTestimonial?id={id}` | ID'ye göre referans getirir |

### Abouts (Hakkında)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Abouts` | Tüm hakkında bilgilerini listeler |
| 🟡 `POST` | `/Abouts` | Yeni hakkında bilgisi oluşturur |
| 🔵 `PUT` | `/Abouts` | Hakkında bilgilerini günceller |
| 🔴 `DELETE` | `/Abouts?id={id}` | Belirtilen hakkında bilgisini siler |
| 🟢 `GET` | `/Abouts/GetAbout?id={id}` | ID'ye göre hakkında bilgisi getirir |

### Contacts

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Contacts` | Tüm iletişim bilgilerini listeler |
| 🟡 `POST` | `/Contacts` | Yeni iletişim bilgisi oluşturur |
| 🔵 `PUT` | `/Contacts` | İletişim bilgilerini günceller |
| 🔴 `DELETE` | `/Contacts?id={id}` | Belirtilen iletişim bilgisini siler |
| 🟢 `GET` | `/Contacts/GetContact?id={id}` | ID'ye göre iletişim bilgisi getirir |

### Events (Etkinlikler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/YummyEvents` | Tüm etkinlikleri listeler |
| 🟡 `POST` | `/YummyEvents` | Yeni etkinlik oluşturur |
| 🔵 `PUT` | `/YummyEvents` | Etkinlik bilgilerini günceller |
| 🔴 `DELETE` | `/YummyEvents?id={id}` | Belirtilen etkinliği siler |
| 🟢 `GET` | `/YummyEvents/GetEvent?id={id}` | ID'ye göre etkinlik getirir |

### Notifications (Bildirimler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Notifications` | Tüm bildirimleri listeler |
| 🟡 `POST` | `/Notifications` | Yeni bildirim oluşturur |
| 🔵 `PUT` | `/Notifications` | Bildirim bilgilerini günceller |
| 🔴 `DELETE` | `/Notifications?id={id}` | Belirtilen bildirimi siler |
| 🟢 `GET` | `/Notifications/GetNotification?id={id}` | ID'ye göre bildirim getirir |
| 🟢 `GET` | `/Notifications/NotificationListByIsReadFalse` | Okunmamış bildirimleri listeler |

### Images (Görseller)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Images` | Tüm görselleri listeler |
| 🟡 `POST` | `/Images` | Yeni görsel oluşturur |
| 🔵 `PUT` | `/Images` | Görsel bilgilerini günceller |
| 🔴 `DELETE` | `/Images?id={id}` | Belirtilen görseli siler |
| 🟢 `GET` | `/Images/GetImage?id={id}` | ID'ye göre görsel getirir |

### Group Reservations (Grup Rezervasyonları)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/GroupReservation` | Tüm grup rezervasyonlarını listeler |
| 🟡 `POST` | `/GroupReservation` | Yeni grup rezervasyonu oluşturur |
| 🔵 `PUT` | `/GroupReservation` | Grup rezervasyonu bilgilerini günceller |
| 🔴 `DELETE` | `/GroupReservation?id={id}` | Belirtilen grup rezervasyonunu siler |
| 🟢 `GET` | `/GroupReservation/GetGroupReservation?id={id}` | ID'ye göre grup rezervasyonu getirir |

### Employee Tasks (Çalışan Görevleri)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/EmployeeTasks` | Tüm çalışan görevlerini listeler |
| 🟡 `POST` | `/EmployeeTasks` | Yeni çalışan görevi oluşturur |
| 🔵 `PUT` | `/EmployeeTasks` | Çalışan görevi bilgilerini günceller |
| 🔴 `DELETE` | `/EmployeeTasks?id={id}` | Belirtilen çalışan görevini siler |
| 🟢 `GET` | `/EmployeeTasks/GetEmployeeTask?id={id}` | ID'ye göre çalışan görevi getirir |

### Statistics (İstatistikler)

| Metot | Endpoint | Açıklama |
|:-----:|----------|----------|
| 🟢 `GET` | `/Statistics/ProductCount` | Toplam ürün sayısını döner |
| 🟢 `GET` | `/Statistics/ReservationCount` | Toplam rezervasyon sayısını döner |
| 🟢 `GET` | `/Statistics/CategoryCount` | Toplam kategori sayısını döner |
| 🟢 `GET` | `/Statistics/YummyEventCount` | Toplam etkinlik sayısını döner |

---

## 📸 Projeden Görseller

### 🏠 Ana Sayfa
<img width="1900" alt="#01" src="https://github.com/user-attachments/assets/394036b9-b78d-46d6-90bf-e142c1d220ad" />
<img width="1900" alt="#02" src="https://github.com/user-attachments/assets/44eefd1b-a26e-4dd7-9a3a-d7cd10b0037b" />
<img width="1900" alt="#03" src="https://github.com/user-attachments/assets/695b216d-50db-4028-84d6-78b223d199f0" />
<img width="1900" alt="#04" src="https://github.com/user-attachments/assets/20414fa5-d3b6-4f83-ab82-daab8bc9e1cc" />
<img width="1900" alt="#05" src="https://github.com/user-attachments/assets/3a854180-1daf-4515-85c9-f4b8cbab356e" />
<img width="1900" alt="#06" src="https://github.com/user-attachments/assets/c3717767-3afd-4f04-aa5d-6d8bbfe1e43a" />
<img width="1900" alt="#07" src="https://github.com/user-attachments/assets/8f1b974d-1ad3-4492-9eff-7b25283d5e1f" />
<img width="1900" alt="#08" src="https://github.com/user-attachments/assets/e847f3cd-d21a-4fa0-85e6-ae20921c697e" />
<img width="1900" alt="#09" src="https://github.com/user-attachments/assets/3b7e5f8a-3d22-4e51-bc2a-dca1a460d293" />

### 📊 Admin Paneli
<img width="1900" alt="#10" src="https://github.com/user-attachments/assets/555ea007-897e-492d-b349-512f02000fee" />
<img width="1900" alt="#11" src="https://github.com/user-attachments/assets/a38d5ade-b701-4234-942c-d70bd64eef38" />
<img width="1900" alt="#12" src="https://github.com/user-attachments/assets/6ef912b7-34cd-4288-9286-ba774bb2168d" />
<img width="1900" alt="#13" src="https://github.com/user-attachments/assets/f1c3d76f-aeb8-4cbf-b554-0af7d4d9a80d" />
<img width="1900" alt="#14" src="https://github.com/user-attachments/assets/3f966dbe-07aa-49df-bbf3-e399ac9da26e" />
<img width="1900" alt="#15" src="https://github.com/user-attachments/assets/fa88767a-0694-4189-ae4c-383a4b0757df" />
<img width="1900" alt="#16" src="https://github.com/user-attachments/assets/3eb6d909-2091-43d8-9d1a-f6a498e58290" />
<img width="1900" alt="#17" src="https://github.com/user-attachments/assets/984b3b02-bd60-435f-96a8-f29c8b256bf0" />
<img width="1900" alt="#18" src="https://github.com/user-attachments/assets/cd848539-7fdf-4eba-9e17-5c6efbeed4d1" />
<img width="1900" alt="#19" src="https://github.com/user-attachments/assets/03f791a4-e672-488c-99b9-1221dd56e391" />
<img width="1900" alt="#20" src="https://github.com/user-attachments/assets/60b4f021-be4f-4b68-a0ff-2b14a952284b" />


## 🚀 Kurulum ve Çalıştırma

### 📋 Ön Gereksinimler

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server) (LocalDB veya Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) veya [VS Code](https://code.visualstudio.com/)

### ⚙️ Kurulum Adımları

**1. Projeyi klonlayın:**
```bash
git clone https://github.com/kullanici-adi/ApiProjeKampi.git
cd ApiProjeKampi
```

**2. Veritabanı bağlantı dizesini güncelleyin:**

`ApiProjeKampi_WebAPI/Context/ApiContext.cs` dosyasında connection string'i kendi SQL Server bilgilerinize göre düzenleyin:

```csharp
optionsBuilder.UseSqlServer("server=SUNUCU_ADI;initial catalog=ApiYummyDb;integrated security=true;TrustServerCertificate=True");
```

**3. Yapay Zeka API anahtarlarını yapılandırın:**

`ApiProjeKampi_WebUI` klasöründe `.env` dosyası oluşturun:
```env
OpenAIApiKey=sk-your-openai-api-key-here
HuggingFaceApiKey=hf_your-huggingface-api-key-here
```
> 💡 API anahtarlarını [OpenAI Platform](https://platform.openai.com/) ve [Hugging Face](https://huggingface.co/settings/tokens) adreslerinden alabilirsiniz.

**4. Migration'ları çalıştırın:**
```bash
cd ApiProjeKampi_WebAPI
dotnet ef database update
```

**5. API projesini başlatın:**
```bash
cd ApiProjeKampi_WebAPI
dotnet run
```
> API varsayılan olarak `https://localhost:7xxx` adresinde çalışacaktır.

**6. Web UI projesini başlatın (yeni terminal):**
```bash
cd ApiProjeKampi_WebUI
dotnet run
```
> Web arayüzü varsayılan olarak `https://localhost:7xxx` adresinde çalışacaktır.

### 🔍 Swagger UI

API çalıştırıldıktan sonra Swagger dokümantasyonuna erişmek için:
```
https://localhost:{port}/swagger
```

---

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak istiyorsanız aşağıdaki adımları takip edebilirsiniz:

1. 🍴 Bu repoyu **fork** edin
2. 🌿 Yeni bir **branch** oluşturun (`git checkout -b feature/yeni-ozellik`)
3. 💾 Değişikliklerinizi **commit** edin (`git commit -m 'Yeni özellik eklendi'`)
4. 📤 Branch'inizi **push** edin (`git push origin feature/yeni-ozellik`)
5. 🔃 Bir **Pull Request** oluşturun

### 📝 Katkı Kuralları

- Kod yazarken mevcut kod stiline uyun
- Anlamlı commit mesajları yazın
- Yeni özellikler için dokümantasyon ekleyin
- Test edilmiş kod gönderin

---

<div align="center">

### ⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!

---

**📺 Eğitim İçin:** [Murat Yücedağ - YouTube](https://www.youtube.com/@MuratYucedag)

---

<sub>Bu proje eğitim amaçlı geliştirilmiştir. © 2025</sub>

</div>

