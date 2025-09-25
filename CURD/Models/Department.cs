using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Models;

internal class Department
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee Manager { get; set; }
    
}
