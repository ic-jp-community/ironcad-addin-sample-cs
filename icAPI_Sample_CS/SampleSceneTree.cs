using AdvancedDataGridView;
using ICApiAddin.icAPI_Sample_CS.Properties;
using interop.ICApiIronCAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICApiAddin.icAPI_Sample_CS
{
    public partial class SampleSceneTree : Form
    {
        private IZDoc _doc = null;

        #region CONST_SCENE_DATATYPE 
        public const string SCENE_DATATYPE_ASSEMBLY = "ASSEMBLY";
        public const string SCENE_DATATYPE_PART = "PARTS";
        public const string SCENE_DATATYPE_PART_SOLID = "PARTS_SOLID";
        public const string SCENE_DATATYPE_PART_SHEET = "PARTS_SHEET";
        public const string SCENE_DATATYPE_PART_UNKNOWN = "PARTS_UNKNOWN";
        public const string SCENE_DATATYPE_PART_WIRE = "PARTS_WIRE";
        public const string SCENE_DATATYPE_PART_EMPTY = "PARTS_EMPTY";
        public const string SCENE_DATATYPE_WIRE = "WIRE";
        public const string SCENE_DATATYPE_PROFILE = "PROFILE";
        public const string SCENE_DATATYPE_SHEETMETAL_PART = "SHEETMETAL_PARTS";
        public const string SCENE_DATATYPE_LINKED_ASSEMBLY = "LINKED_ASSEMBLY";
        public const string SCENE_DATATYPE_LINKED_PART = "LINKED_PARTS";
        public const string SCENE_DATATYPE_LINKED_PART_SOLID = "LINKED_PARTS_SOLID";
        public const string SCENE_DATATYPE_LINKED_PART_SHEET = "LINKED_PARTS_SHEET";
        public const string SCENE_DATATYPE_LINKED_PART_UNKNOWN = "LINKED_PARTS_UNKNOWN";
        public const string SCENE_DATATYPE_LINKED_PART_WIRE = "LINKED_PARTS_WIRE";
        public const string SCENE_DATATYPE_LINKED_PART_EMPTY = "LINKED_PARTS_EMPTY";
        public const string SCENE_DATATYPE_LINKED_WIRE = "LINKED_WIRE";
        public const string SCENE_DATATYPE_LINKED_PROFILE = "LINKED_PROFILE";
        public const string SCENE_DATATYPE_LINKED_SHEETMETAL_PART = "LINKED_SHEETMETAL_PARTS";
        public const string SCENE_DATATYPE_SCENE = "SCENE";
        public const string SCENE_DATATYPE_FILE = "FILE";
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="sceneDoc"></param>
        public SampleSceneTree(IZDoc doc)
        {
            InitializeComponent();
            this._doc = doc;
        }

        /// <summary>
        /// ロード イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SampleSceneTree_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ImageList imageList = new ImageList();
            getImageListAssemblyParts(new Size(18, 18), ref imageList);
            treeGridViewScene.ImageList = imageList;
            getTreeGridView(this._doc);
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// SceneTreeを取得する
        /// </summary>
        private void getTreeGridView(IZDoc doc)
        {
            TreeGridView tgv = treeGridViewScene;
            tgv.ShowLines = true;
            IZSceneDoc sceneDoc = doc as IZSceneDoc;
            int treeNodeHeight = 21;
            string userName = string.Empty;
            string systemName = string.Empty;
            string elementId = string.Empty;
            int currentDepth = 0;

            TreeGridNode topNode = tgv.Nodes.Add(Path.GetFileName(this._doc.Name), systemName, elementId, SCENE_DATATYPE_SCENE, currentDepth, this._doc.Name);
            topNode.ImageIndex = getImageIndexAssemblyParts(SCENE_DATATYPE_SCENE);
            topNode.Height = (int)(treeNodeHeight * getScalingFactor());
            topNode.Expand();
            int depth = 1;
            GetSceneTreeInfo(sceneDoc.GetTopElement(), treeNodeHeight, ref topNode, ref depth);
            TreeGridNodeCollection nodes = topNode.Nodes;
            ExpandTreeGridViewTreeNodes(ref nodes);
        }

        /// <summary>
        /// アセンブリ/パーツのツリー表示用の画像を取得する
        /// </summary>
        /// <param name="size"></param>
        /// <param name="imageList"></param>
        public static void getImageListAssemblyParts(Size size, ref ImageList imageList)
        {
            imageList = new ImageList();
            imageList.Images.Add(Resources.ImageNone);
            imageList.Images.Add(Resources.Assembly);
            imageList.Images.Add(Resources.LinkAssembly);
            imageList.Images.Add(Resources.Parts);
            imageList.Images.Add(Resources.LinkParts);
            imageList.Images.Add(Resources.Scene);
            imageList.Images.Add(Resources.Profile);
            imageList.Images.Add(Resources.LinkedProfile);
            imageList.Images.Add(Resources.Wire);
            imageList.Images.Add(Resources.LinkedWire);
            imageList.Images.Add(Resources.SheetMetal);
            imageList.Images.Add(Resources.LinkedSheetMetal);
            imageList.Images.Add(Resources.PartsSheet);
            imageList.Images.Add(Resources.LinkedPartsSheet);
            imageList.ImageSize = size;
            imageList.ColorDepth = ColorDepth.Depth32Bit;
        }

        /// <summary>
        /// TreeGridViewのNodeを全て展開する
        /// </summary>
        /// <param name="nodes"></param>
        public static void ExpandTreeGridViewTreeNodes(ref TreeGridNodeCollection nodes)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].Expand();
                TreeGridNodeCollection childNodes = nodes[i].Nodes;
                ExpandTreeGridViewTreeNodes(ref childNodes);
            }
        }

        /// <summary>
        /// シーンファイルのツリー表示を作成する(TreeGridView用) 再帰処理
        /// </summary>
        /// <param name="currElem">現在のアセンブリ/パーツ Element</param>
        /// <param name="nodeHeight">各ノードの高さ</param>
        /// <param name="currNode">現在のノード</param>
        /// <param name="currDepth">現在の深さ</param>
        /// <returns></returns>
        public static bool GetSceneTreeInfo(IZElement currElem, int nodeHeight, ref TreeGridNode currNode, ref int currDepth)
        {
            try
            {
                if ((currElem.Type != eZElementType.Z_ELEMENT_PART) &&
                    (currElem.Type != eZElementType.Z_ELEMENT_ASSEMBLY) &&
                    //                    (elem.Type != eZElementType.Z_ELEMENT_WIRE) &&
                    //                    (elem.Type != eZElementType.Z_ELEMENT_PROFILE) &&
                    (currElem.Type != eZElementType.Z_ELEMENT_SHEETMETAL_PART) &&
                    (currElem.Type != eZElementType.Z_ELEMENT_UNKNOWN))
                {

                    return false;
                }
                ZArray childs = currElem.GetChildrenZArray();
                int count = 0;
                childs.Count(out count);
                for (int i = 0; i < count; i++)
                {
                    object obj;
                    IZElement childElem;
                    childs.Get(i, out obj);
                    childElem = obj as IZElement;
                    if ((childElem.Type == eZElementType.Z_ELEMENT_PART) ||
                        (childElem.Type == eZElementType.Z_ELEMENT_ASSEMBLY) ||
                        (childElem.Type == eZElementType.Z_ELEMENT_WIRE) ||
                        (childElem.Type == eZElementType.Z_ELEMENT_PROFILE) ||
                        (childElem.Type == eZElementType.Z_ELEMENT_SHEETMETAL_PART))
                    {
                        /* パーツ/アセンブリの情報 */
                        IZDoc doc = childElem.OwningDoc;
                        IZSceneDoc scene = doc as IZSceneDoc;
                        string dataType = string.Empty;
                        bool link = false;
                        string linkStr = string.Empty;
                        string dispName = string.Empty;
                        switch (childElem.Type)
                        {
                            case eZElementType.Z_ELEMENT_ASSEMBLY:
                                IZAssembly asm = childElem as IZAssembly;
                                linkStr = asm.GetExternallyLinkedInfo(out link);
                                dataType = GetInnerDataType(childElem.Type, link, eZBodyType.Z_BODY_EMPTY);
                                break;
                            case eZElementType.Z_ELEMENT_PART:
                            case eZElementType.Z_ELEMENT_WIRE:
                            case eZElementType.Z_ELEMENT_PROFILE:
                            case eZElementType.Z_ELEMENT_SHEETMETAL_PART:
                                IZPart part = childElem as IZPart;
                                eZBodyType body = eZBodyType.Z_BODY_EMPTY;
                                linkStr = part.GetExternallyLinkedInfo(out link);
                                if (childElem.Type == eZElementType.Z_ELEMENT_PART)
                                {
                                    part.GetBodyType(ref body);
                                }
                                dataType = GetInnerDataType(childElem.Type, link, body);
                                break;
                            default:
                                break;
                        }
                        dispName = childElem.Name;

                        TreeGridNode childNode = null;
                        childNode = currNode.Nodes.Add(childElem.Name, childElem.SystemName, childElem.Id, dataType, currDepth, linkStr);
                        childNode.ImageIndex = getImageIndexAssemblyParts(dataType);
                        childNode.Height = (int)(nodeHeight * getScalingFactor());
                        currDepth++;
                        GetSceneTreeInfo(childElem, nodeHeight, ref childNode, ref currDepth);
                        currDepth--;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }


        /// <summary>
        /// element種類からicVaultのデータ種類を取得する
        /// </summary>
        /// <param name="elemType">elementの種類</param>
        /// <param name="isLinked">外部リンク有無 true;外部リンクあり false:外部リンクなし</param>
        /// <param name="body">elementのボディー種別</param>
        /// <returns></returns>
        public static string GetInnerDataType(eZElementType elemType, bool isLinked, eZBodyType body)
        {
            string dataType = string.Empty;
            switch (elemType)
            {
                case eZElementType.Z_ELEMENT_PART:
                    if (isLinked == true)
                    {
                        dataType = SCENE_DATATYPE_LINKED_PART;
                        switch (body)
                        {
                            case eZBodyType.Z_BODY_SHEET:
                                dataType = SCENE_DATATYPE_LINKED_PART_SHEET;
                                break;
                            case eZBodyType.Z_BODY_SOLID:
                                dataType = SCENE_DATATYPE_LINKED_PART_SOLID;
                                break;
                            case eZBodyType.Z_BODY_WIRE:
                                dataType = SCENE_DATATYPE_LINKED_PART_WIRE;
                                break;
                            case eZBodyType.Z_BODY_EMPTY:
                                dataType = SCENE_DATATYPE_LINKED_PART_EMPTY;
                                break;
                            case eZBodyType.Z_BODY_UNKNOWN:
                                dataType = SCENE_DATATYPE_LINKED_PART_UNKNOWN;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        dataType = SCENE_DATATYPE_PART;
                        switch (body)
                        {
                            case eZBodyType.Z_BODY_SHEET:
                                dataType = SCENE_DATATYPE_PART_SHEET;
                                break;
                            case eZBodyType.Z_BODY_SOLID:
                                dataType = SCENE_DATATYPE_PART_SOLID;
                                break;
                            case eZBodyType.Z_BODY_WIRE:
                                dataType = SCENE_DATATYPE_PART_WIRE;
                                break;
                            case eZBodyType.Z_BODY_EMPTY:
                                dataType = SCENE_DATATYPE_PART_EMPTY;
                                break;
                            case eZBodyType.Z_BODY_UNKNOWN:
                                dataType = SCENE_DATATYPE_PART_UNKNOWN;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case eZElementType.Z_ELEMENT_ASSEMBLY:
                    if (isLinked == true)
                    {
                        dataType = SCENE_DATATYPE_LINKED_ASSEMBLY;
                    }
                    else
                    {
                        dataType = SCENE_DATATYPE_ASSEMBLY;
                    }
                    break;
                case eZElementType.Z_ELEMENT_WIRE:
                    if (isLinked == true)
                    {
                        dataType = SCENE_DATATYPE_LINKED_WIRE;
                    }
                    else
                    {
                        dataType = SCENE_DATATYPE_WIRE;
                    }
                    break;
                case eZElementType.Z_ELEMENT_PROFILE:
                    if (isLinked == true)
                    {
                        dataType = SCENE_DATATYPE_LINKED_PROFILE;
                    }
                    else
                    {
                        dataType = SCENE_DATATYPE_PROFILE;
                    }
                    break;
                case eZElementType.Z_ELEMENT_SHEETMETAL_PART:
                    if (isLinked == true)
                    {
                        dataType = SCENE_DATATYPE_LINKED_SHEETMETAL_PART;
                    }
                    else
                    {
                        dataType = SCENE_DATATYPE_SHEETMETAL_PART;
                    }
                    break;
                default:
                    break;
            }
            return dataType;
        }


        /// <summary>
        /// アセンブリ/パーツ種別からツリー用の画像Indexを取得する
        /// </summary>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public static int getImageIndexAssemblyParts(string dataType)
        {
            int index = 0;
            switch (dataType)
            {
                case SCENE_DATATYPE_ASSEMBLY:
                    index = 1;
                    break;
                case SCENE_DATATYPE_LINKED_ASSEMBLY:
                    index = 2;
                    break;
                case SCENE_DATATYPE_PART:
                case SCENE_DATATYPE_PART_EMPTY:
                case SCENE_DATATYPE_PART_UNKNOWN:
                case SCENE_DATATYPE_PART_SOLID:
                    index = 3;
                    break;
                case SCENE_DATATYPE_LINKED_PART:
                case SCENE_DATATYPE_LINKED_PART_EMPTY:
                case SCENE_DATATYPE_LINKED_PART_UNKNOWN:
                case SCENE_DATATYPE_LINKED_PART_SOLID:
                    index = 4;
                    break;
                case SCENE_DATATYPE_SCENE:
                    index = 5;
                    break;
                case SCENE_DATATYPE_PROFILE:
                    index = 6;
                    break;
                case SCENE_DATATYPE_LINKED_PROFILE:
                    index = 7;
                    break;
                case SCENE_DATATYPE_WIRE:
                    index = 8;
                    break;
                case SCENE_DATATYPE_LINKED_WIRE:
                    index = 9;
                    break;
                case SCENE_DATATYPE_SHEETMETAL_PART:
                    index = 10;
                    break;
                case SCENE_DATATYPE_LINKED_SHEETMETAL_PART:
                    index = 11;
                    break;
                case SCENE_DATATYPE_PART_SHEET:
                    index = 12;
                    break;
                case SCENE_DATATYPE_LINKED_PART_SHEET:
                    index = 13;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        #region
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,
            LOGPIXELSY = 90
        }

        /// <summary>
        /// 表示スケールを取得する
        /// </summary>
        /// <returns></returns>
        public static float getScalingFactor()
        {
            float scale = 1;
            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr desktop = g.GetHdc();
                int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
                int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);
                int logpixelsy = GetDeviceCaps(desktop, (int)DeviceCap.LOGPIXELSY);
                float screenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;
                float dpiScalingFactor = (float)logpixelsy / (float)96;

                if (screenScalingFactor > dpiScalingFactor)
                {
                    scale = screenScalingFactor;
                }
                else
                {
                    scale = dpiScalingFactor;
                }
            }
            return scale;
        }
        #endregion

        private void treeGridViewScene_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
