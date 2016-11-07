using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Sample
{
    public partial class Company
    {
        public string ExtendingInfo { get; set; }

        partial void ValidateName()
        {

        }
    }
}
