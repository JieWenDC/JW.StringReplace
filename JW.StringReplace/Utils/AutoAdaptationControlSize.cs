using System.Collections.Generic;
using System.Windows.Forms;

namespace JW.StringReplace.Utils
{
    /// <summary>
    /// 自适应控件大小
    /// </summary>
    public class AutoAdaptationControlSize
    {
        /// <summary>
        /// 控件初始信息
        /// </summary>
        public List<ControlRect> oldControl = new List<ControlRect>();

        /// <summary>
        /// 记录控件初始信息
        /// </summary>
        public class ControlRect
        {
            public string Name { get; set; }
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        /// <summary>
        /// 初始化控件记录
        /// 记录控件的初始位置、大小等信息
        /// </summary>
        /// <param name="control"></param>
        public void ControllInitializeSize(Control control)
        {
            RecordControlRect(control);
            var controls = FindControl(control);
            foreach (var item in controls)
            {
                RecordControlRect(item);
            }
        }

        /// <summary>
        /// 记录指定控件的信息
        /// </summary>
        /// <param name="control"></param>
        private void RecordControlRect(Control control)
        {
            ControlRect cR = new ControlRect()
            {
                Name=control.Name,
                Left = control.Left,
                Top = control.Top,
                Width = control.Width,
                Height = control.Height,
            };
            oldControl.Add(cR);
        }

        /// <summary>
        /// 查找指定控件内的控件
        /// </summary>
        /// <param name="control"></param>
        private List<Control> FindControl(Control control)
        {
            var ret = new List<Control>();
            foreach (Control control_item in control.Controls)
            {
                ret.Add(control_item);
                ret.AddRange(FindControl(control_item));
            }
            return ret;
        }

        /// <summary>
        /// 改变控件大小
        /// </summary>
        /// <param name="control"></param>
        public void ChangeControlSize(Control control)
        {
            float wScale = (float)control.Width / (float)oldControl[0].Width;
            float hScale = (float)control.Height / (float)oldControl[0].Height;
            AutoScaleControl(control, wScale, hScale);
        }

        /// <summary>
        /// 自动缩放控件
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="wScale"></param>
        /// <param name="hScale"></param>
        private void AutoScaleControl(Control ctl, float wScale, float hScale)
        {
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            //int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始
            foreach (Control c in ctl.Controls)
            {
                var olf_control = oldControl.Find(row => row.Name == c.Name);
                if (olf_control == null)
                {
                    continue;
                }
                ctrLeft0 = olf_control.Left;
                ctrTop0 = olf_control.Top;
                ctrWidth0 = olf_control.Width;
                ctrHeight0 = olf_control.Height;
                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1
                c.Top = (int)((ctrTop0) * hScale);//
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);
                c.Height = (int)(ctrHeight0 * hScale);//
                if (c.Controls.Count > 0)
                {
                    AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                }
                if (ctl is DataGridView)
                {
                    DataGridView dgv = ctl as DataGridView;
                    Cursor.Current = Cursors.WaitCursor;

                    int widths = 0;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);  // 自动调整列宽  
                        widths += dgv.Columns[i].Width;   // 计算调整列后单元列的宽度和                       
                    }
                    if (widths >= ctl.Size.Width)  // 如果调整列的宽度大于设定列宽  
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  // 调整列的模式 自动  
                    else
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // 如果小于 则填充  

                    Cursor.Current = Cursors.Default;
                }
            }


        }
    }
}
