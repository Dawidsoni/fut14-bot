using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace FIFA_AUCTION {
    public class Stats {
        public ConcurrentDictionary<DateTime, SafeBox> safeBoxes = new ConcurrentDictionary<DateTime, SafeBox>();
        SafeBox curBox = null;
        bool isStatic;

        public Stats(SafeBox safeBox, bool isStatic) {
            curBox = safeBox;
            this.isStatic = isStatic;
        }

        public void update() {
            while (true) {
                System.Threading.Thread.Sleep(Const.STATS_SLEEP);
                if (isStatic) safeBoxes.TryAdd(DateTime.Now, SafeBox.staticObj());
                else safeBoxes.TryAdd(DateTime.Now, curBox.copy());
            }
        }

    }
}
