using System;
using System.Collections.Generic;

namespace WebApiProxy.Core.Models
{
    public class ModelDefinitionEqualityComparer : IEqualityComparer<ModelDefinition>
    {
        public bool Equals(ModelDefinition x, ModelDefinition y) =>
            x.Name.Equals(y.Name, StringComparison.OrdinalIgnoreCase);

        public int GetHashCode(ModelDefinition obj) =>
            obj.Name.GetHashCode();
    }
}
