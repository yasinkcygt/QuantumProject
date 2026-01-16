from QuantumObject import QuantumObject
from QuantumCollapseException import QuantumCollapseException

# DataPacket inherits from the abstract QuantumObject class
class DataPacket(QuantumObject):
    def analyze(self):
        """
        Implementation of the abstract analyze method.
        Simulates data decryption by reducing stability by 5 units.
        """
        new_value = self.stability - 5
        
        # If stability drops to or below zero, trigger a system collapse
        if new_value <= 0:
            raise QuantumCollapseException(self.object_id)
            
        # Update the object's stability using the setter in the base class
        self.stability = new_value
        print("Data decryption successful. Content read.")