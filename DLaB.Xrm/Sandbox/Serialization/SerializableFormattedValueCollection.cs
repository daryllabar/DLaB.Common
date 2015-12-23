﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

namespace DLaB.Xrm.Sandbox.Serialization
{
    /// <summary>
    /// Sandbox safe FormattedValueCollection
    /// </summary>
    [CollectionDataContract(Name = "FormattedValueCollection", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
    public class SerializableFormattedValueCollection: List<KeyValuePairOfstringstring>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableFormattedValueCollection"/> class.
        /// </summary>
        public SerializableFormattedValueCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableFormattedValueCollection"/> class.
        /// </summary>
        /// <param name="values">The values.</param>
        public SerializableFormattedValueCollection(FormattedValueCollection values)
        {
            foreach (var value in values)
            {
                Add(new KeyValuePairOfstringstring(value));
            }
        }
    }
}