using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    class IdNamePair {
        public long id;
        public string name;

        public IdNamePair(long id, string name) {
            this.id = id;
            this.name = name;
        }

        public override string ToString() {
            return name;
        }

    }
}
