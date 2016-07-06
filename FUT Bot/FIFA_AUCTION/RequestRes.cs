using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Models;

namespace FIFA_AUCTION {
    public class RequestRes {
        public EventQueue queue;
        public LoggerSave logger;
        public LoginDetails details;
        public SafeBox safeInfo;
        public TransHistory history;

        public RequestRes(EventQueue queue, LoggerSave logger, LoginDetails details, SafeBox safeInfo, TransHistory history) {
            this.queue = queue;
            this.logger = logger;
            this.details = details;
            this.safeInfo = safeInfo;
            this.history = history;
        }
    }
}
