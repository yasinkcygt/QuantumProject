from abc import ABC, abstractmethod  #abstract icin sart

#ABC'den miras alinca sinif abstract olur
class KuantumNesnesi(ABC):
    def __init__(self, id, stabilite, t_seviyesi):
        self.id = id
        self.stabilite = stabilite
        self.tehlike_seviyesi = t_seviyesi

    @property
    def stabilite(self):
        return self._stabilite  # _ (alt cizgi) gizli degisken demek
    
    @stabilite.setter
    def stabilite(self, value):
        if 0 < value and value < 100:
            self._stabilite = value
        else:
            # Değişken oluşturmak yerine direkt programı durdurursun
            raise ValueError("Stabilite, 0 ile 100 arasinda olmali")

        
    @property
    def t_seviyesi(self):
        return self._tehlike_seviyesi
    
    @t_seviyesi.setter
    def t_seviyesi(self, value):
        if(value>0 and value<10):
            self._tehlike_seviyesi = value
        else:
            # Değişken oluşturmak yerine direkt programı durdurursun
            raise ValueError("Tehlike seviyesi, 0 ile 10 arasinda olmali.")
    
    @property
    def id(self):
        return self._id
    
    @id.setter
    def id(self, value):
        self._id = value

    # abstract metot gövdesi pass ile bos birakilir
    @abstractmethod
    def analiz_et(self):
        pass


    def durum_bilgisi(self):
        return f"Nesne ID: {self.id}, Stabilite: {self.stabilite}, Tehlike Seviyesi: {self.t_seviyesi}"