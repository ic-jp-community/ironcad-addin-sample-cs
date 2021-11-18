﻿using System;
using System.Collections.Generic;
using System.Text;

using interop.ICApiIronCAD;
using System.Windows.Forms;

namespace ICApiAddin.icAPI_Sample_CS
{
    class Event_DocEvents
    {
        internal Event_DocEvents()
        {
        }

        internal void RegisterEvents(IZDoc iZDoc)
        {
            if (iZDoc != null)
            {
                DDEventsObj IDDocEvents = iZDoc as DDEventsObj;
                if (IDDocEvents != null)
                {
                    IDDocEvents.SelectionChanged += new _IZDocEvents_SelectionChangedEventHandler(IDDocEvents_SelectionChanged);
                    IDDocEvents.DocModifyNotify += new _IZDocEvents_DocModifyNotifyEventHandler(IDDocEvents_DocModifyNotify);
                    IDDocEvents.DocDestroyNotify += new _IZDocEvents_DocDestroyNotifyEventHandler(IDDocEvents_DocDestroyNotify);
                }
            }
        }

        internal void UnRegisterEvents(IZDoc iZDoc)
        {
            if (iZDoc != null)
            {
                DDEventsObj IDDocEvents = iZDoc as DDEventsObj;
                if (IDDocEvents != null)
                {
                    IDDocEvents.SelectionChanged -= IDDocEvents_SelectionChanged;
                    IDDocEvents.DocModifyNotify -= IDDocEvents_DocModifyNotify;
                    IDDocEvents.DocDestroyNotify -= IDDocEvents_DocDestroyNotify;
                }
            }
        }

        void IDDocEvents_DocDestroyNotify(IZDoc piDoc)
        {
            MessageBox.Show("DocDestroyNotify event fired.");
        }

        void IDDocEvents_DocModifyNotify(string bstrFileName, bool vbModified)
        {
            MessageBox.Show("DocModifyNotify event fired.");
        }

        void IDDocEvents_SelectionChanged()
        {
            MessageBox.Show("SelectionChanged event fired.");
        }
    }

}
