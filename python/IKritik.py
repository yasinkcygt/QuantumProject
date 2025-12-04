from abc import ABC, abstractmethod

#InterFace pythonda aslında soyut bir sınıftır
class IKritik(ABC):
    @abstractmethod
    def acil_durum_sogutmasi(self):
        pass       # csharptaki gibi bos birakilir
