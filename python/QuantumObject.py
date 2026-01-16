from abc import ABC, abstractmethod

# ABC (Abstract Base Class) ensures this class cannot be instantiated directly
class QuantumObject(ABC):
    def __init__(self, object_id, stability, danger_level):
        # The object_id is typically immutable, so we set it directly to the private field
        self._object_id = object_id
        
        # We assign values through properties to trigger validation logic (encapsulation)
        self.stability = stability  
        self.danger_level = danger_level 

    @property
    def object_id(self):
        """Getter for the unique object identifier."""
        return self._object_id

    @property
    def stability(self):
        """Getter for the current stability percentage."""
        return self._stability

    @stability.setter
    def stability(self, value):
        """Validates that stability remains within the 0-100 range."""
        if 0 <= value <= 100:
            self._stability = value
        else:
            # Raising an error prevents the object from being created with invalid data
            raise ValueError("Stability must be between 0 and 100.")

    @property
    def danger_level(self):
        """Getter for the object's threat assessment level."""
        return self._danger_level

    @danger_level.setter
    def danger_level(self, value):
        """Validates that danger level remains within the 1-10 range."""
        if 1 <= value <= 10:
            self._danger_level = value
        else:
            raise ValueError("Danger level must be between 1 and 10")

    @abstractmethod
    def analyze(self):
        """Abstract method; must be implemented by all derived quantum objects."""
        pass

    def get_status_info(self):
        """Returns a formatted string representing the object's current state."""
        return f"[ID: {self.object_id}] | Stability: {self.stability}% | Danger Level: {self.danger_level}/10"