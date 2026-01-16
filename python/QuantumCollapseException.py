class QuantumCollapseException(Exception):
    """Custom exception thrown when stability hits zero."""
    def __init__(self, object_id):
        self.message = f"CRITICAL FAILURE: Object with ID '{object_id}' has collapsed and exploded!"
        super().__init__(self.message)