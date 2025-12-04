# QuantumProjesi

## Açıklama

Bu proje, farklı programlama dillerinde (C#, Java, JavaScript, Python) Nesne Yönelimli Programlama (OOP) prensiplerini kullanarak hazırlanmış bir 'Kuantum Ambarı' simülasyonudur. Proje, `KuantumNesnesi`, `AntiMadde`, `KaranlikMadde` gibi soyut kavramları sınıflar aracılığıyla modelleryerek bir konsol uygulaması üzerinden yönetilmesini sağlar. Temel amaç, aynı OOP konseptlerinin (kalıtım, polimorfizm, arayüzler, istisna yönetimi) farklı dillerdeki uygulamalarını karşılaştırmaktır.

## Özellikler

- **Çok Dilli Uygulama:** C#, Java, JavaScript ve Python dillerinde aynı projenin paralel olarak geliştirilmesi.
- **Nesne Yönelimli Modelleme:** `AntiMadde`, `KaranlikMadde` ve `VeriPaketi` gibi kavramların kalıtım yoluyla `KuantumNesnesi` sınıfından türetilmesi.
- **Etkileşimli Konsol Arayüzü:** 'Kuantum Ambarı'nı yönetmek için menü tabanlı bir kontrol paneli.
- **Polimorfizm:** Her nesne türü için farklı davranışlar sergileyen `AnalizEt()` metodu.
- **Arayüz (Interface) Kullanımı:** `IKritik` arayüzü ile 'Acil Durum Soğutması' gibi özel yeteneklerin belirli nesnelere kazandırılması.
- **Özel İstisna Yönetimi (Exception Handling):** `KuantumCokusuException` ile program akışında kritik hata durumlarının yönetilmesi.

## Başlarken

1.  Depoyu klonlayın:
    ```bash
    git clone https://github.com/your-kullaniciadi/QuantumProject.git
    ```
2.  İlgilendiğiniz dile özgü dizine gidin:
    *   `cd csharp`
    *   `cd java`
    *   `cd javascript`
    *   `cd python`

## Kullanım

Her dil dizini kendi örnek ve talimat setini içerir. Aşağıda her bir dil için genel çalıştırma yönergeleri bulunmaktadır:

### C#

C# projesini çalıştırmak için, `csharp` dizinine gidin ve .NET CLI'yı kullanın:

```bash
cd csharp
dotnet run
```

### Java

Java kodunu derlemek ve çalıştırmak için, `java` dizinine gidin ve `javac` ile `java` komutlarını kullanın:

```bash
cd java
javac *.java
java Program
```

### JavaScript

JavaScript dosyasını Node.js ile çalıştırmak için, `javascript` dizinine gidin ve `node` komutunu kullanın:

```bash
cd javascript
node Program.js
```

### Python

Python dosyasını çalıştırmak için, `python` dizinine gidin ve `python` yorumlayıcısını kullanın:

```bash
cd python
python main.py
```

## Klasör Yapısı

```
QuantumProject/
│
├── csharp/
│     - AntiMadde.cs
│     - IKritik.cs
│     - KaranlikMadde.cs
│     - KuantumCokusuException.cs
│     - KuantumNesnesi.cs
│     - VeriPaketi.cs
│     - Program.cs
│
├── java/
│     - AntiMadde.java
│     - IKritik.java
│     - KaranlikMadde.java
│     - KuantumCokusException.java
│     - KuantumNesnesi.java
│     - VeriPaketi.java
│     - Program.java
│
├── javascript/
│     - AntiMadde.js
│     - KaranlikMadde.js
│     - KuantumCokusuException.js
│     - KuantumNesnesi.js
│     - VeriPaketi.js
│     - Program.js
│
├── python/
│     - AntiMadde.py
│     - IKritik.py
│     - KaranlikMadde.py
│     - KuantumCokusException.py
│     - KuantumNesnesi.py
│     - VeriPaketi.py
│     - main.py
│
└── README.md
```
