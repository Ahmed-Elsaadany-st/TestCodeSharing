using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.bel_Models
{
    public class base_Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int createdby { get; set; }
        public int LastModifiedby { get; set; }
        public bool IsDeleted { get; set; }
    }
}
