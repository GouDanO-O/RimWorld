using System;
using Unity.VisualScripting;

namespace RimWorld
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DescriptionAttribute : Attribute
    {
        public string description;

        public DescriptionAttribute(string description)
        {
            this.description = description;
        }
    }
}

