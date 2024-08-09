using System;

namespace RimWorld
{
    /// <summary>
    /// 默认值特性
    /// </summary>
    public class DefaultValueAttribute : Attribute
    {
        public object value;

        public DefaultValueAttribute(object value)
        {
            this.value = value;
        }

        public virtual bool ObjIsDefault(object obj)
        {
            if (obj == null)
            {
                return value == null;
            }
            if (value == null)
            {
                return false;
            }
            return value.Equals(obj);
        }
    }
}

