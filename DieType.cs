#if UNITY

using UnityEngine;

#endif

namespace StellarWolf.Core
{

    /// <summary>
    /// Defines the standard set of dice
    /// </summary>
    public enum DieType
    {
    
        /// <summary>Represents a standard 4 sided die.</summary>
        [Tooltip ( "Represents a standard 4 sided die." )] D4 = 4,
        
        /// <summary>Represents a standard 6 sided die.</summary>
        [Tooltip ( "Represents a standard 6 sided die." )] D6 = 6,
        
        /// <summary>Represents a standard 8 sided die.</summary>
        [Tooltip ( "Represents a standard 8 sided die." )] D8 = 8,
        
        /// <summary>Represents a standard 10 sided die.</summary>
        [Tooltip ( "Represents a standard 10 sided die." )] D10 = 10,
        
        /// <summary>Represents a standard 12 sided die.</summary>
        [Tooltip ( "Represents a standard 12 sided die." )] D12 = 12,
        
        /// <summary>Represents a standard 20 sided die.</summary>
        [Tooltip ( "Represents a standard 20 sided die." )] D20 = 20,
        
        /// <summary>Represents a standard 10 sided die and a percentile die.</summary>
        [Tooltip ( "Represents a standard 10 sided die and a percentile die." )] D100 = 100
        
    }

}
