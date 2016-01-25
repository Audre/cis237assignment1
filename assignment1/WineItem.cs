using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        // backing fields
        private string id;
        private string description;
        private string pack;

        // default constructor
        public WineItem()
        {

        }

        // 3-parameter constructor
        public WineItem(string id, string description, string pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        // overrides ToString
        public override string ToString()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        // properties for the backing fields
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Pack
        {
            get { return pack; }
            set { pack = value; }
        }
    }
}
