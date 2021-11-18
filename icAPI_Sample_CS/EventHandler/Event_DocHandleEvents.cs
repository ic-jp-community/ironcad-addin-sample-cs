﻿using System;
using System.Collections.Generic;
using System.Text;

using interop.ICApiIronCAD;
using System.Windows.Forms;

namespace ICApiAddin.icAPI_Sample_CS
{
    class Event_DocHandleEvents
    {
        internal Event_DocHandleEvents()
        {
        }

        internal void RegisterEvents(ZHandleEvents zHandleEvents)
        {
            if (zHandleEvents != null)
            {
                zHandleEvents.OnBeginDrag += new _IZHandleEvents_OnBeginDragEventHandler(zHandleEvents_OnBeginDrag);
            }
        }

        internal void UnRegisterEvents(ZHandleEvents zHandleEvents)
        {
            if (zHandleEvents != null)
            {
                zHandleEvents.OnBeginDrag -= zHandleEvents_OnBeginDrag;
            }
        }

        void zHandleEvents_OnBeginDrag(ZHandle piHandle, int lClientX, int lClientY)
        {
            MessageBox.Show("OnBeginDragイベント");
        }
    }
}
