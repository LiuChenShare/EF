﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Fasterflect.Emitter
{
    /// <summary>
    /// A wrapper for value type.  Must be used in order for Fasterflect to 
    /// work with value type such as struct.
    /// </summary>
    internal class ValueTypeHolder
    {
        /// <summary>
        /// Creates a wrapper for <paramref name="value"/> value type.  The wrapper
        /// can then be used with Fasterflect.
        /// </summary>
        /// <param name="value">The value type to be wrapped.  
        /// Must be a derivative of <code>ValueType</code>.</param>
        public ValueTypeHolder(object value)
        {
            Value = (ValueType)value;
        }

        /// <summary>
        /// The actual struct wrapped by this instance.
        /// </summary>
        public ValueType Value { get; set; }
    }
}
