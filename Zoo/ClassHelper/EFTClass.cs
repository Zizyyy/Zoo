using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.DB;

namespace Zoo.ClassHelper
{
    public class EFTClass
    {
        public static Entities context { get; set; } = new Entities();
    }
}
