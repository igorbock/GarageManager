using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace GarageManager.Forms
{
    public class OrderedPropertyGridWrapper : ICustomTypeDescriptor
    {
        private readonly object _target;
        private readonly PropertyDescriptorCollection _orderedProperties;

        public OrderedPropertyGridWrapper(object target)
        {
            _target = target;
            _orderedProperties = GetOrderedProperties(target.GetType());
        }

        private static PropertyDescriptorCollection GetOrderedProperties(Type type)
        {
            var properties = new List<PropertyDescriptor>();
            var seen = new HashSet<string>();

            for (var t = type; t != null && t != typeof(object); t = t.BaseType)
            {
                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(t))
                {
                    if (!seen.Add(prop.Name)) continue;
                    var browsable = (BrowsableAttribute)prop.Attributes[typeof(BrowsableAttribute)];
                    if (browsable != null && !browsable.Browsable) continue;
                    if (prop.Attributes[typeof(KeyAttribute)] is KeyAttribute) continue;
                    properties.Add(prop);
                }
            }

            return new PropertyDescriptorCollection(properties.ToArray());
        }

        public PropertyDescriptorCollection GetProperties()
        {
            return _orderedProperties;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return _orderedProperties;
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(_target);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(_target);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(_target);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(_target);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(_target);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(_target);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(_target, editorBaseType);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(_target);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(_target, attributes);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return _target;
        }
    }
}
