using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace FIFA_AUCTION {
    public class LoggerBase {
        public ConcurrentQueue<string> queueMessages = new ConcurrentQueue<string>();
        public ConcurrentDictionary<int, string> listMessages = new ConcurrentDictionary<int, string>();

        protected void addMessage(string str) {
            string result;
            queueMessages.Enqueue(str);
            if (queueMessages.Count > Const.MAX_MESSAGES_SIZE) queueMessages.TryDequeue(out result); 
            listMessages.TryAdd((listMessages.Count == 0 ? 0 : listMessages.Last().Key + 1),str);
            if (listMessages.Count > Const.MAX_MESSAGES_SIZE) listMessages.TryRemove(listMessages.First().Key, out result);
        }

    }
}
