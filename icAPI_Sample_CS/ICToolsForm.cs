using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using interop.ICApiIronCAD;

namespace ICApiAddin.icAPI_Sample_CS
{
    [ComVisible(false)]
    public partial class ICToolsForm : Form
    {
        private IZAddinSite m_iZAddinSite;
        private IZDoc m_iZDoc;
        private IZEnvironmentMgr m_iZEnvMgr;
        private AppEvents AppEvent;

        public ICToolsForm()
        {
            InitializeComponent();
        }

        public IZDoc IronCADDocument
        {
            set { m_iZDoc = value; }
        }

        public IZAddinSite IronCADAddinSite
        {
            set { m_iZAddinSite = value; }
        }

        public IZEnvironmentMgr IronCADEnvMgr
        {
            set { m_iZEnvMgr = value; }
        }

        private void ICToolsForm_Load(object sender, EventArgs e)
        {
            if (m_iZDoc != null)
            {
                lblDisplay.Text = m_iZDoc.Name;
                lblResult.Text = GetDocInfo();
            }
            else
            {
                lblDisplay.Text = "開いているファイルがありません。";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetDocInfo()
        {
            string msg = string.Empty;
            if (m_iZDoc != null)
            {
                IZSceneDoc iZsceneDoc = m_iZDoc as IZSceneDoc;
                if (iZsceneDoc != null)
                {
                    msg += "IRONCADシーンファイル" + Environment.NewLine;
                    IZSelectionMgr iZselectionMgr = iZsceneDoc.SelectionMgr;
                    if (iZselectionMgr != null)
                    {
                        object elements = iZselectionMgr.GetSelectedElements();
                        List<IZElement> list = Addin.ConvertObjectToElementArray(elements);
                        if (list != null && list.Count > 0)
                        {
                            msg += "選択中のパーツアセンブリ:" + Environment.NewLine;
                            foreach (IZElement izEle in list)
                            {
                                string eleDesc = izEle.Type.ToString() + ": " + izEle.Name;
                                IZSceneElement izSceneEle = izEle as IZSceneElement;
                                if (izSceneEle != null)
                                {
                                    eleDesc += ", SceneElementです";
                                }
                                msg += eleDesc + Environment.NewLine;
                            }
                        }
                        else
                        {
                            msg += "選択しているパーツ/アセンブリがありません" + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    IZDrawingDoc iZDrawingDoc = m_iZDoc as IZDrawingDoc;
                    if (iZDrawingDoc != null)
                    {
                        msg += "IRONCADドローイングファイル" + Environment.NewLine;
                    }
                }
            }
            return msg;
        }

        private void buttonStartEvent_Click(object sender, EventArgs e)
        {
            if (AppEvent == null)
            {
               AppEvent = new AppEvents();
            }
            AppEvent.RegisterForAppEvents(m_iZAddinSite.Application);
        }

        private void buttonStopEvent_Click(object sender, EventArgs e)
        {
            if(AppEvent != null)
            {
                AppEvent.UnRegisterForAppEvents();
            }
        }
    }
}
