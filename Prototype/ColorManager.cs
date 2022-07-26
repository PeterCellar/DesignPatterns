using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

        // indexer
        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors[key] = value; }
        }
    }
}
