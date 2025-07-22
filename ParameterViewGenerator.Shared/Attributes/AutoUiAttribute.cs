using System;
using System.Collections.Generic;
using System.Text;

namespace ParameterViewGenerator.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class AutoUIAttribute : Attribute
    {
    }
}
