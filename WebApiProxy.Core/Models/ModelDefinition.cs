using System.Collections.Generic;
using System.Diagnostics;

namespace WebApiProxy.Core.Models
{
    [DebuggerDisplay("{Name}")]
    public class ModelDefinition
    {
        #region Properties

        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public IEnumerable<ConstantDefinition> Constants { get; set; }
            = new List<ConstantDefinition>();

        public IEnumerable<ModelProperty> Properties { get; set; }
            = new List<ModelProperty>();

        #endregion
    }
}
