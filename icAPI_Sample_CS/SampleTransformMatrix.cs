using AdvancedDataGridView;
using interop.ICApiIronCAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ICApiAddin.icAPI_Sample_CS
{
    [ComVisible(false)]
    public partial class SampleTransformMatrix : Form
    {
        private IZBaseApp _baseApp;
        private IZDoc _doc;
        private IZSceneDoc _sceneDoc;

        /// <summary>
        /// combobox表示用データ
        /// </summary>
        public class comboBoxData
        {
            public string ElementUserName { get; set; }
            public IZElement Element { get; set; }
            public comboBoxData()
            {
                this.ElementUserName = string.Empty;
                this.Element = null;
            }
            public comboBoxData(string elementUserName, IZElement element)
            {
                this.ElementUserName = elementUserName;
                this.Element = element;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="app"></param>
        /// <param name="izDoc"></param>
        public SampleTransformMatrix(IZBaseApp app, IZDoc izDoc)
        {
            InitializeComponent();
            this._baseApp = app;
            this._doc = izDoc;
            this._sceneDoc = izDoc as IZSceneDoc;

            /* パーツアセンブリのデータを取得しComboBoxに表示する */
            List<comboBoxData> elementList = new List<comboBoxData>();
            GetSceneTreeElement(this._sceneDoc.GetTopElement(), ref elementList);
            comboBoxAllElement.DisplayMember = "ElementUserName";
            comboBoxAllElement.ValueMember = "Element";
            comboBoxAllElement.DataSource = elementList;
        }

        /// <summary>
        /// シーンファイルのElementを取得する
        /// </summary>
        /// <param name="currElem">現在のアセンブリ/パーツ Element</param>
        /// <param name="elementList"></param>
        /// <returns></returns>
        public static bool GetSceneTreeElement(IZElement currElem, ref List<comboBoxData> elementList)
        {
            try
            {
                if ((currElem.Type != eZElementType.Z_ELEMENT_PART) &&
                    (currElem.Type != eZElementType.Z_ELEMENT_ASSEMBLY) &&
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
                        string name = childElem.Name;
                        elementList.Add(new comboBoxData(name, childElem));
                        GetSceneTreeElement(childElem, ref elementList);
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
        /// 閉じるボタンクリック イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 現在のMatrixを取得するボタンクリック イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetCurrentMatrix_Click(object sender, EventArgs e)
        {
            ShowSelectedElementMatrix();
        }


        /// <summary>
        /// comboBoxAllElementの変更 イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAllElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            IZElement elem = comboBoxAllElement.SelectedValue as IZElement;
            if (elem == null)
            {
                return;
            }
            IZSelectionMgr selectionMgr = this._sceneDoc.SelectionMgr;
            selectionMgr.RemoveAllFromSelection();
            selectionMgr.AddElementToSelection(elem, true);
            ShowSelectedElementMatrix();
        }


        /// <summary>
        /// 選択しているElementのMatrixを表示する
        /// </summary>
        /// <returns></returns>
        private bool ShowSelectedElementMatrix()
        {
            IZSceneElement element = GetSelectedOneElement();
            if (element == null)
            {
                MessageBox.Show("Elementが選択されていません。");
                return false;
            }
            ZMathMatrix matrix = element.GetPositionTransform();
            ShowCurrentElementMatrix(matrix);
            return true;
        }


        /// <summary>
        /// 変更後のMatrixを適用するボタンクリック イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTransform_Click(object sender, EventArgs e)
        {
            IZSceneElement element = GetSelectedOneElement();
            if (element == null)
            {
                MessageBox.Show("Elementが選択されていません。");
                return;
            }
            ZMathMatrix matrix = GetTransformMatrix();
            element.SetPositionTransform(matrix);
            this._sceneDoc.UpdateGraphics(0);
            ResetAngle(true, true, true);
            ShowCurrentElementMatrix(matrix);
        }


        /// <summary>
        /// 回転をリセットボタンクリック イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetRotate_Click(object sender, EventArgs e)
        {
            textBoxMatrix11_1.Text = "1";
            textBoxMatrix21_1.Text = "0";
            textBoxMatrix31_1.Text = "0";
            textBoxMatrix41_1.Text = "0";
            textBoxMatrix12_1.Text = "0";
            textBoxMatrix22_1.Text = "1";
            textBoxMatrix32_1.Text = "0";
            textBoxMatrix42_1.Text = "0";
            textBoxMatrix13_1.Text = "0";
            textBoxMatrix23_1.Text = "0";
            textBoxMatrix33_1.Text = "1";
            textBoxMatrix43_1.Text = "0";
        }


        /// <summary>
        /// 変更後のMatrixを計算し表示する
        /// </summary>
        private void CalcAndShowTransformMatrix()
        {
            IZSceneElement element = GetSelectedOneElement();
            if (element == null)
            {
                return;
            }

            /* 変更後のMatrixを取得 */
            ZMathMatrix transformMatrix = CalcTransformMatrix(element);

            /* 変更後のMatrixに表示する */
            ShowTransformMatrix(transformMatrix);
        }


        /// <summary>
        /// 変更後のMatrixを計算する
        /// </summary>
        /// <returns></returns>
        private ZMathMatrix CalcTransformMatrix(IZSceneElement element)
        {
            ZMathMatrix currentMatrix = element.GetPositionTransform();
            ZMathMatrix matrixX = currentMatrix.Copy();
            ZMathMatrix matrixY = currentMatrix.Copy();
            ZMathMatrix matrixZ = currentMatrix.Copy();
            double x, y, z;

            /* X, Y, Zを取得 */
            currentMatrix.GetTranslation(out x, out y, out z);

            /* 角度を取得 */
            double angleX = double.Parse(textBoxAngleX.Text);
            double angleY = double.Parse(textBoxAngleY.Text);
            double angleZ = double.Parse(textBoxAngleZ.Text);

            /* 行列を計算 */
            matrixX.SetRotation(1, angleX, false);
            matrixY.SetRotation(2, angleY, false);
            matrixZ.SetRotation(3, angleZ, false);

            /* 現在のMatrixに掛ける */
            currentMatrix.MultiplyBy(matrixX);
            currentMatrix.MultiplyBy(matrixY);
            currentMatrix.MultiplyBy(matrixZ);
            currentMatrix.SetTranslation(x, y, z);

            return currentMatrix;
        }


        /// <summary>
        /// 選択しているElementを取得（最初の1つだけ）
        /// </summary>
        /// <returns></returns>
        private IZSceneElement GetSelectedOneElement()
        {
            IZSceneElement element = null;
            IZSceneDoc sceneDoc = this._doc as IZSceneDoc;
            IZSelectionMgr iZselectionMgr = sceneDoc.SelectionMgr;
            if (iZselectionMgr != null)
            {
                object elements = iZselectionMgr.GetSelectedElements();
                List<IZElement> list = Addin.ConvertObjectToElementArray(elements);
                foreach (IZElement izEle in list)
                {
                    element = izEle as IZSceneElement;
                    break;
                }
            }
            return element;
        }


        /// <summary>
        /// 現在のMatrixに表示する
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private void ShowCurrentElementMatrix(ZMathMatrix matrix)
        {
            Double[] doubleArray = matrix.Data;
            textBoxMatrix11.Text = doubleArray[0].ToString();
            textBoxMatrix21.Text = doubleArray[1].ToString();
            textBoxMatrix31.Text = doubleArray[2].ToString();
            textBoxMatrix41.Text = doubleArray[3].ToString();
            textBoxMatrix12.Text = doubleArray[4].ToString();
            textBoxMatrix22.Text = doubleArray[5].ToString();
            textBoxMatrix32.Text = doubleArray[6].ToString();
            textBoxMatrix42.Text = doubleArray[7].ToString();
            textBoxMatrix13.Text = doubleArray[8].ToString();
            textBoxMatrix23.Text = doubleArray[9].ToString();
            textBoxMatrix33.Text = doubleArray[10].ToString();
            textBoxMatrix43.Text = doubleArray[11].ToString();
            textBoxMatrix14.Text = doubleArray[12].ToString();
            textBoxMatrix24.Text = doubleArray[13].ToString();
            textBoxMatrix34.Text = doubleArray[14].ToString();
            textBoxMatrix44.Text = doubleArray[15].ToString();
            return;
        }


        /// <summary>
        /// 変更後のMatrixに表示する
        /// </summary>
        /// <param name="matrix"></param>
        private void ShowTransformMatrix(ZMathMatrix matrix)
        {
            Double[] doubleArray = matrix.Data;
            textBoxMatrix11_1.Text = doubleArray[0].ToString();
            textBoxMatrix21_1.Text = doubleArray[1].ToString();
            textBoxMatrix31_1.Text = doubleArray[2].ToString();
            textBoxMatrix41_1.Text = doubleArray[3].ToString();
            textBoxMatrix12_1.Text = doubleArray[4].ToString();
            textBoxMatrix22_1.Text = doubleArray[5].ToString();
            textBoxMatrix32_1.Text = doubleArray[6].ToString();
            textBoxMatrix42_1.Text = doubleArray[7].ToString();
            textBoxMatrix13_1.Text = doubleArray[8].ToString();
            textBoxMatrix23_1.Text = doubleArray[9].ToString();
            textBoxMatrix33_1.Text = doubleArray[10].ToString();
            textBoxMatrix43_1.Text = doubleArray[11].ToString();
            textBoxMatrix14_1.Text = doubleArray[12].ToString();
            textBoxMatrix24_1.Text = doubleArray[13].ToString();
            textBoxMatrix34_1.Text = doubleArray[14].ToString();
            textBoxMatrix44_1.Text = doubleArray[15].ToString();
        }


        /// <summary>
        /// 表示している変更後のMatrixを取得する
        /// </summary>
        /// <returns></returns>
        private ZMathMatrix GetTransformMatrix()
        {
            IZMathUtility util = _baseApp as IZMathUtility;
            ZMathMatrix matrix = null;
            Double[] doubleArray = new double[16];
            doubleArray[0] = double.Parse(textBoxMatrix11_1.Text);
            doubleArray[1] = double.Parse(textBoxMatrix21_1.Text);
            doubleArray[2] = double.Parse(textBoxMatrix31_1.Text);
            doubleArray[3] = double.Parse(textBoxMatrix41_1.Text);
            doubleArray[4] = double.Parse(textBoxMatrix12_1.Text);
            doubleArray[5] = double.Parse(textBoxMatrix22_1.Text);
            doubleArray[6] = double.Parse(textBoxMatrix32_1.Text);
            doubleArray[7] = double.Parse(textBoxMatrix42_1.Text);
            doubleArray[8] = double.Parse(textBoxMatrix13_1.Text);
            doubleArray[9] = double.Parse(textBoxMatrix23_1.Text);
            doubleArray[10] = double.Parse(textBoxMatrix33_1.Text);
            doubleArray[11] = double.Parse(textBoxMatrix43_1.Text);
            doubleArray[12] = double.Parse(textBoxMatrix14_1.Text);
            doubleArray[13] = double.Parse(textBoxMatrix24_1.Text);
            doubleArray[14] = double.Parse(textBoxMatrix34_1.Text);
            doubleArray[15] = double.Parse(textBoxMatrix44_1.Text);
            object res = (object)doubleArray;
            matrix = util.CreateMathMatrix(res);
            return matrix;
        }


        /// <summary>
        /// 設定角度をリセットする
        /// </summary>
        /// <param name="resetX"></param>
        /// <param name="resetY"></param>
        /// <param name="resetZ"></param>
        private void ResetAngle(bool resetX, bool resetY, bool resetZ)
        {
            if (resetX == true)
            {
                textBoxAngleX.Text = "0";
                trackBarAngleX.Value = 0;
            }
            if (resetY == true)
            {
                textBoxAngleY.Text = "0";
                trackBarAngleY.Value = 0;
            }
            if (resetZ == true)
            {
                textBoxAngleZ.Text = "0";
                trackBarAngleZ.Value = 0;
            }
            CalcAndShowTransformMatrix();
        }


        #region TextBox角度 変更イベント
        /// <summary>
        /// TextBox(X)のテキスト変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAngleX_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            bool parse = Int32.TryParse(textBoxAngleX.Text, out value);
            if(parse != true)
            {
                return;
            }
            trackBarAngleX.Value = value;
            CalcAndShowTransformMatrix();
        }


        /// <summary>
        /// TextBox(Y)のテキスト変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAngleY_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            bool parse = Int32.TryParse(textBoxAngleY.Text, out value);
            if (parse != true)
            {
                return;
            }
            trackBarAngleY.Value = value;
            CalcAndShowTransformMatrix();
        }


        /// <summary>
        /// TextBox(Z)のテキスト変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAngleZ_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            bool parse = Int32.TryParse(textBoxAngleZ.Text, out value);
            if (parse != true)
            {
                return;
            }
            trackBarAngleZ.Value = value;
            CalcAndShowTransformMatrix();
        }
        #endregion TextBox角度 変更イベント

        #region TrackBarスクロールイベント
        /// <summary>
        /// TrackBar(X)のスクロール イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            textBoxAngleX.Text = trackBarAngleX.Value.ToString();
            CalcAndShowTransformMatrix();
        }


        /// <summary>
        /// TrackBar(T)のスクロール イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarAngleY_Scroll(object sender, EventArgs e)
        {
            textBoxAngleY.Text = trackBarAngleY.Value.ToString();
            CalcAndShowTransformMatrix();
        }


        /// <summary>
        /// TrackBar(Z)のスクロール イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarAngleZ_Scroll(object sender, EventArgs e)
        {
            textBoxAngleZ.Text = trackBarAngleZ.Value.ToString();
            CalcAndShowTransformMatrix();
        }
        #endregion TrackBarスクロールイベント

        #region リセットボタン
        /// <summary>
        /// Xをリセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetAngleX_Click(object sender, EventArgs e)
        {
            ResetAngle(true, false, false);
        }


        /// <summary>
        /// Yをリセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetAngleY_Click(object sender, EventArgs e)
        {
            ResetAngle(false, true, false);
        }


        /// <summary>
        /// Zをリセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetAngleZ_Click(object sender, EventArgs e)
        {
            ResetAngle(false, false, true);
        }
        #endregion リセットボタン


    }
}
