using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using interop.ICApiIronCAD;

namespace ICApiAddin.icAPI_Sample_CS
{
    [Guid("6AE87CEF-C966-4938-A945-40D4280F6021"), ClassInterface(ClassInterfaceType.None), ProgId("icAPI_Sample_CS.AddIn")]
    public class Addin : IZAddinServer, IZEDOTriballCallback
    {
        //, IZEDOSelectionCallback
        public const string ADDIN_GUID = "6AE87CEF-C966-4938-A945-40D4280F6021";

        #region [Private Members]
        private ZAddinSite m_izAddinSite;
        private ZCommandHandler m_buttonForm;
        private ZCommandHandler m_buttonDockingBar;
        #endregion

        //Constractor
        public Addin()
        {
        }

        #region [Public Properties]
        public IZBaseApp IronCADApp
        {
            get
            {
                if (m_izAddinSite != null)
                    return m_izAddinSite.Application;
                return null;
            }

        }

        #endregion

        #region [IZAddinServer Members]
        public void InitSelf(ZAddinSite piAddinSite)
        {
            if (piAddinSite != null)
            {
                m_izAddinSite = piAddinSite;
                try
                {
                    //ボタンの作成(Form)
                    stdole.IPictureDisp oImageSmall = ConvertImage.ImageToPictureDisp(Properties.Resources.icon_form_s);
                    stdole.IPictureDisp oImageLarge = ConvertImage.ImageToPictureDisp(Properties.Resources.icon_form_l);
                    m_buttonForm = piAddinSite.CreateCommandHandler("SampleForm", "SampleForm", "icAPI C# SampleForm Description", "icAPI C# SampleForm ToolTip", oImageSmall, oImageLarge);
                    m_buttonForm.Enabled = true;

                    //ボタンの作成(Dockbar)
                    stdole.IPictureDisp oImageSmall2 = ConvertImage.ImageToPictureDisp(Properties.Resources.icon_dockbar_s);
                    stdole.IPictureDisp oImageLarge2 = ConvertImage.ImageToPictureDisp(Properties.Resources.icon_dockbar_l);
                    m_buttonDockingBar = piAddinSite.CreateCommandHandler("SampleDockingBar", "SampleDockingBar", "icAPI C# SampleDockingBar Description", "icAPI C# SampleDockingBar ToolTip", oImageSmall2, oImageLarge2);
                    m_buttonDockingBar.Enabled = true;

                    //Control bar
                    ZControlBar cControlBar;
                    ZEnvironmentMgr cEnvMgr = this.IronCADApp.EnvironmentMgr;
                    ZControls cControls;
                    IZControl cControl;
                    ZRibbonBar cRibbonBar;

                    //ツールバーを作成する
                    IZEnvironment cEnv = cEnvMgr.get_Environment(eZEnvType.Z_ENV_SCENE);
                    cRibbonBar = cEnv.GetRibbonBar(eZRibbonBarType.Z_RIBBONBAR);
                    cControlBar = cEnv.AddControlBar(piAddinSite, "icAPI_Sample_C#_ControlBar");
                    cControls = cControlBar.Controls;
                    cControl = cControls.Add(ezControlType.Z_CONTROL_BUTTON, m_buttonForm.ControlDescriptor, null);
                    cControl = cControls.Add(ezControlType.Z_CONTROL_BUTTON, m_buttonDockingBar.ControlDescriptor, null);

                    //Add button to RibbonBar
//                    cRibbonBar.AddButton(m_buttonForm.ControlDescriptor);
                    cRibbonBar.AddButton2(m_buttonForm.ControlDescriptor, false);
                    cRibbonBar.AddButton2(m_buttonDockingBar.ControlDescriptor, true);

                    /************************************************************
                      リボンバーに大きいボタンで表示させたい時はこっち↓を使用する
                      cRibbonBar.AddButton2(m_button.ControlDescriptor, true);
                    *************************************************************/


                    //Event handlers
                    m_buttonForm.OnClick += new _IZCommandEvents_OnClickEventHandler(m_buttonForm_OnClick);
                    m_buttonForm.OnUpdate += new _IZCommandEvents_OnUpdateEventHandler(m_buttonForm_OnUpdate);
                    m_buttonDockingBar.OnClick += new _IZCommandEvents_OnClickEventHandler(m_buttonDockingBar_OnClick);
                    m_buttonDockingBar.OnUpdate += new _IZCommandEvents_OnUpdateEventHandler(m_buttonDockingBar_OnUpdate);

                    //Register App Events
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Addin Server is null.");
            }
        }


        public void DeInitSelf()
        {
            m_buttonForm = null;
         }

        #endregion

        #region [Private Methods]
        [DllImport("icAPI_CppWrapper.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr HwndToCwnd(IntPtr hwnd);

        private void m_buttonForm_OnUpdate()
        {
            m_buttonForm.Enabled = true;  //Change to m_button.Enabled = false; to disable the button  
        }
        private void m_buttonDockingBar_OnUpdate()
        {
            m_buttonDockingBar.Enabled = true;  //Change to m_button.Enabled = false; to disable the button  
        }

        private void m_buttonForm_OnClick()
        {
            IZDoc iZDoc = GetActiveDoc();
            IZEnvironmentMgr iZEnvMgr = GetEnvironmentMgr();
            if (iZDoc != null)
            {
                ICToolsForm frm = new ICToolsForm();
                frm.IronCADDocument = iZDoc;
                frm.IronCADEnvMgr = iZEnvMgr;
                frm.IronCADAddinSite = m_izAddinSite;
                frm.Show();
            }
        }

        private void m_buttonDockingBar_OnClick()
        {
            IZAddinSite addinSite = m_izAddinSite;
            IZEnvironmentMgr envMgr = GetEnvironmentMgr();
            IZEnvironment env = envMgr.ActiveEnvironment;
            IZDockingBar dockingBar;
            int left, top, right, bottom;

            /* DockingBarの追加 */
            dockingBar = env.AddDockingBar((ZAddinSite)addinSite, 1, "AddDockingBar", 0);
            dockingBar.GetClientRect(out left, out top, out right, out bottom);

            /* ユーザコントロールをDockingBarにマッピング */
            UserControl_DockBar uc = new UserControl_DockBar();
            uc.SetBounds(left, top, right - left, bottom - top);
            IntPtr hwnd = uc.Handle;
            IntPtr cwnd = HwndToCwnd(hwnd);
            dockingBar.SetSubWindow((ulong)cwnd);
            dockingBar.ShowControlBar(1, 1, 0);
           
        }


        private IZDoc GetActiveDoc()
        {
            if (this.IronCADApp != null)
            {
                return this.IronCADApp.ActiveDoc;
            }
            return null;
        }

        private IZEnvironmentMgr GetEnvironmentMgr()
        {
            if (this.IronCADApp != null)
            {
                return this.IronCADApp.EnvironmentMgr;
            }
            return null;
        }

        #endregion

        #region [Internal Methods]

        internal static List<IZElement> ConvertObjectToElementArray(object varElements)
        {
            if (varElements != null)
            {
                object[] oElements = varElements as object[];
                if (oElements != null)
                {
                    List<IZElement> izElements = new List<IZElement>();
                    foreach(object oEle in oElements)
                    {
                        IZElement izEle = oEle as IZElement;
                        if (izEle != null)
                        {
                            izElements.Add(izEle);
                        }
                    }
                    return izElements;
                }
            }
            return null;
        }

        #endregion

        #region [Public IZEDOSelectionCallback]
        public void OnDeselect(IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("deselect");
            // throw new NotImplementedException();
        }

        public void OnSelect(IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("select");
            // throw new NotImplementedException();
        }
        #endregion
        #region [Public IZEDOSelectionCallback]
        public void OnPreTriballMove (IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("deselect");
            // throw new NotImplementedException();
        }
        public void OnPreTriballCopy(IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("deselect");
            // throw new NotImplementedException();
        }
        public void OnPostTriballMove(IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("deselect");
            // throw new NotImplementedException();
        }
        public void OnPostTriballCopy(IZElement piElement, ref bool pvbOverride)
        {
            MessageBox.Show("deselect");
            // throw new NotImplementedException();
        }
        #endregion
    }
}
