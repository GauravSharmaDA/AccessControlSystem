using AccessControlSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControlSystem.Models
{
    public class ServerModel
    {
        public string ServerName { get; set; }
        public int SelectedServerType { get; set; }
        public int SelectedAccessPolicy { get; set; }
        public int SelectedDepartment { get; set; }

        public List<ServerType> ServerTypes { get; set; }
        public List<AccessPolicy> AccessPolicies { get; set; }
        public List<Department> Departments { get; set; }
    }
}
