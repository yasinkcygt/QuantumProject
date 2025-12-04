class KaranlikMadde(KuantumNesnesi, IKritik):
    def __init__(self, id, stabilite, t_seviyesi):
        super().__init__(id, stabilite, t_seviyesi)

    def analiz_et(self):
        yeni_deger = self.stabilite - 15

        if yeni_deger <= 0:
            raise KuantumCokusException(f"SİSTEM ÇÖKTÜ! ID: {self.id}")
        self.stabilite = yeni_deger

    def acil_durum_sogutmasi(self):
        yeni_deger = self.stabilite + 50
        if yeni_deger > 100:
            self.stabilite = 100
            print("Sınır değer aşılıyor, nesne maxta sogutuldu.")
        else:
            self.stabilite = yeni_deger
            print(f"Nesne sogutuldu: {self.stabilite}")