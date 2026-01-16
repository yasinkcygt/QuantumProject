using System;

namespace NDP_Odev4
{
    // Custom exception thrown when stability hits zero
    public class QuantumCollapseException : Exception
    {
        public QuantumCollapseException(string id) 
            : base($"CRITICAL FAILURE: Object with ID '{id}' has collapsed and exploded!") { }
    }
}