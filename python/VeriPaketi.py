class VeriPaketi(KuantumNesnesi):
    def __init__(self, id, stabilite, t_seviyesi):
        super().__init__(id, stabilite, t_seviyesi)
    
    def analiz_et(self):
        yeni_deger = self.stabilite - 5

        if yeni_deger <= 0:
            raise KuantumCokusException(f"SİSTEM ÇÖKTÜ! ID: {self.id}")
        
        self.stabilite = yeni_deger
        print("Veri degeri okundu")