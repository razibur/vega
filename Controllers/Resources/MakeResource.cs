using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }        
        public string Name { get; set; }

        public ICollection<ModelResource> Modles { get; set; } = new Collection<ModelResource>();        
    }
}