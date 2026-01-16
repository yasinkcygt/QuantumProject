from QuantumObject import QuantumObject
from ICritical import ICritical
from QuantumCollapseException import QuantumCollapseException

# DarkMatter utilizes Multiple Inheritance to act as both a QuantumObject and ICritical
class DarkMatter(QuantumObject, ICritical):
    def __init__(self, object_id, stability, danger_level):
        # Call the constructor of the abstract base class
        super().__init__(object_id, stability, danger_level)

    def analyze(self):
        """Reduces stability significantly due to high-energy analysis."""
        new_value = self.stability - 15
        
        if new_value <= 0:
            raise QuantumCollapseException(self.object_id)
            
        self.stability = new_value
        print("Dark matter composition analyzed.")

    def emergency_cooling(self):
        """Implementation of the ICritical interface behavior for thermal stabilization."""
        new_value = self.stability + 50
        
        # Logic Safety: Ensure stability doesn't exceed 100% by capping it at 99%
        self.stability = 99 if new_value > 100 else new_value
        print(f"Cooling successful. Current Stability: {self.stability}%")