using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teleprogram
{
    public class TeleprogramModel
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string Date { get; set; }

        public override string ToString()
        {
            return $"{this.Name}.{this.Genre}.{this.Date}*";
        }
    }
}
