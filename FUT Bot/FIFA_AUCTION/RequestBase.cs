using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Parameters;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    public class RequestBase {
        public EventQueue queue;
        public LoginDetails details;
        public TransHistory history;
        protected LoggerSave logger;
        protected SafeBox safeInfo;
        protected bool canceled = false;

        public RequestBase(RequestRes res) {
            this.queue = res.queue;
            this.details = res.details;
            this.history = res.history;
            this.logger = res.logger;
            this.safeInfo = res.safeInfo;
        }

        public void cancel() {
            canceled = true;
        }

    }
}
