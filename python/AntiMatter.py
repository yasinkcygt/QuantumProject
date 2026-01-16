from QuantumObject import QuantumObject
from ICritical import ICritical
from QuantumCollapseException import QuantumCollapseException

# AntiMatter is a highly volatile QuantumObject that implements the ICritical interface
class AntiMatter(QuantumObject, ICritical):
    def __init__(self, object_id, stability, danger_level):
        # Initialize the base class with provided parameters
        super().__init__(object_id, stability, danger_level)

    def analyze(self):
        """
        Severe stability reduction occurs during Anti-Matter analysis.
        Triggers a collapse if stability falls to zero or below.
        """
        new_value = self.stability - 25
        
        if new_value <= 0:
            raise QuantumCollapseException(self.object_id)
            
        self.stability = new_value
        print("The fabric of the universe trembles during analysis...")

    def emergency_cooling(self):
        """
        Specialized cooling implementation with strict threshold checks.
        Unlike DarkMatter, Anti-Matter cannot be cooled if it leads to an overflow.
        """
        new_value = self.stability + 50
        
        # Safety Check: Adhere to strict physical limits for Anti-Matter stabilization
        if new_value >= 100:
            print("Warning: Cooling limit reached. Further cooling impossible.")
            return
            
        self.stability = new_value
        print(f"Thermal extraction complete. Stability: {self.stability}%")