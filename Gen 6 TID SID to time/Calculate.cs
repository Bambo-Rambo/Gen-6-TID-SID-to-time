using System;
using System.Collections.Generic;
using System.Text;

namespace Gen_6_TID_SID_to_time
{
    class Calculate
    {
        public uint getseed(int y)
        {
            uint yearsSeed = 0x00000000;
            for (int i = 0; i < (y - 2000); i++)
            {
                if (DateTime.IsLeapYear(2000 + i))
                    yearsSeed += 0x5CD78800;
                else
                    yearsSeed += 0x57B12C00;
            }
            return yearsSeed;
        }

        public DateTime secondsToDate(int sec, int year)
        {
            DateTime date1 = new DateTime(year, 1, 1, 13, 0, 0);
            DateTime date2 = date1.AddSeconds(sec);

            if (TimeZoneInfo.Local.IsDaylightSavingTime(date2))
                return date2.AddSeconds(3600);
            return date2;
        }

    }
}
