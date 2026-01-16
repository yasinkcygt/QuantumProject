class ICritical:
    """Interface for objects that require stabilization via cooling."""
    def emergency_cooling(self):
        raise NotImplementedError("Emergency cooling must be implemented by the subclass.")