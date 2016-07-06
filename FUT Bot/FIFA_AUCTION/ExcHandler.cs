using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace FIFA_AUCTION {
    class ExcHandler {
        private ConcurrentDictionary<string, bool> dict = new ConcurrentDictionary<string, bool>();
        public void add(string exc) {
            Task.Run(new Action(() => addAsync(exc)));
        }

        private void addAsync(string exc) {
            if (dict.ContainsKey(exc)) {
                dict.TryUpdate(exc, true, false);
            } else {
                dict.TryAdd(exc, true);
            }
            Thread.Sleep(1);
            dict.TryUpdate(exc, false, true);
        }

        public bool contains(string exc) {
            bool val = false;
            dict.TryGetValue(exc, out val);
            return val;
        }
    }
}
