using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaShop.Models
{
    class User
    {
        private int id { get; set; }
        private string mail { get; set; }
        private Department department { get; set; }

        public User()
        {
        }

        enum Department
        {
            SALES,
            STORAGE
        }
    }
}
