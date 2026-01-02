using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickWindows.Tools
{
    internal class SubclassNavigation
    {
        #region SubClassNavigationMethods
        internal static bool FindFirstRecord<T>(ref int inpCurrentRecord,
                                                 ref List<T> inpRecordList)
        {
            inpCurrentRecord = 0;
            T record = inpRecordList[inpCurrentRecord];

            return (record != null);
        }
        internal static bool FindNextRecord<T>(ref int inpCurrentRecord,
                                                ref List<T> inpRecordList)
        {
            if (inpCurrentRecord == inpRecordList.Count - 1)
            {
                return false;
            }

            inpCurrentRecord++;
            T record = inpRecordList[inpCurrentRecord];
            return (record != null);
        }
        internal static bool FindPrevRecord<T>(ref int inpCurrentRecord,
                                         ref List<T> inpRecordList)
        {
            if (inpCurrentRecord == 0)
            {
                return false;
            }

            inpCurrentRecord--;
            T record = inpRecordList[inpCurrentRecord];
            return (record != null);
        }
        internal static bool FindLastRecord<T>(ref int inpCurrentRecord,
                                                ref List<T> inpRecordList)
        {
            inpCurrentRecord = inpRecordList.Count - 1;
            T record = inpRecordList[inpCurrentRecord];
            return (record != null);
        }
        internal static bool FindSpecificRecord<T>(int inpParcelIndex,
                                                    ref int inpCurrentRecord,
                                                    ref List<T> inpRecordList)
        {
            if (inpParcelIndex < 0 || inpParcelIndex > inpRecordList.Count - 1)
            {
                throw new IndexOutOfRangeException("There is no parcel at this position");
            }
            inpCurrentRecord = inpParcelIndex;
            T record = inpRecordList[inpCurrentRecord];
            return (record != null);
        }
        #endregion
    }
}
