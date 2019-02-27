using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontVuelingAcademy.Models
{
    public class ODataResponse <T>
    {
        public List<T> Value { get; set; }
    }
}
