using System;
using System.Collections.Generic;
using System.Collections;

namespace FastReflection
{
    abstract class SerializedObject
    {
        /// <summary>
        /// The name of the object inside its host type.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The runtime/instance type of this object, if different from the declared type.
        /// </summary>
        public Type Type { get; set; }
    }

    class SerializedCollection : SerializedObject, IEnumerable<SerializedObject>
    {
        public SerializedCollection()
        {
            Items = new List<SerializedObject>();
        }

        public List<SerializedObject> Items { get; private set; }

        public IEnumerator<SerializedObject> GetEnumerator()
        {
            return Items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }

    class SerializedAggregate : SerializedObject
    {
        public SerializedAggregate()
        {
            Children = new Dictionary<object, SerializedObject>();
        }

        public Dictionary<object, SerializedObject> Children { get; private set; }

        public SerializedObject this[object key]
        {
            get { return Children[key]; }
        }
    }

    class SerializedAtom : SerializedObject
    {
        public object Value { get; set; }
    }
}
