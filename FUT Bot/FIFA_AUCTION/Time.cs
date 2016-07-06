using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA_AUCTION {
    class Time {
        public static string time() {
            DateTime now = DateTime.Now;
            return changeTime(now.Year) + "-" + changeTime(now.Month) + "-" + changeTime(now.Day) + " " + changeTime(now.Hour) + ":" + changeTime(now.Minute);
        }

        private static string changeTime(int value) {
            if (value < 10)
                return "0" + value.ToString();
            else return value.ToString();
        }

    }
}
