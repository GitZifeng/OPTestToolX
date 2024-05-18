﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptTestTools.View.Setting
{
    public partial class FrmDraw : Form
    {

        public FrmDraw()
        {
            InitializeComponent();
        }
        public int GetHwnd()
        {
            try
            {
                return int.Parse(Handle.ToString());
            }
            catch
            {
            }
            return 0;
        }
        //public static FrmDraw GetWindow()
        //{
        //    return StaticData.Draw.frmDraw;
        //}
        public void SetWindowSize(int width,int height)
        {
            this.Show();
            this.Width = width;
            this.Height = height;
            this.Update();
            this.Refresh();
        }
        
        public void CloseWindow()
        {
            this.Close();
        }

        public void MoveWindow(int x,int y)
        {
            this.MoveWindow(x, y);
        }

        private const uint WS_EX_LAYERED = 0x80000; //不可随便修改

        private const int WS_EX_TRANSPARENT = 0x20;

        private const int GWL_EXSTYLE = (-20);

        private string Var_genre = "";//记录当前操作的类型



        #region 在窗口结构中为指定的窗口设置信息

        /// <summary>
        /// 在窗口结构中为指定的窗口设置信息
        /// </summary>
        /// <param name="hwnd">欲为其取得信息的窗口的句柄</param>
        /// <param name="nIndex">欲取回的信息</param>
        /// <param name="dwNewLong">由nIndex指定的窗口信息的新值</param>
        /// <returns></returns>

        [DllImport("user32", EntryPoint = "SetWindowLong")] //重写SetWindowLong函数

        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        //hWnd为窗口句柄及间接给出的窗口所属的类

        //nIndex

        #endregion

        #region 从指定窗口的结构中取得信息

        /// <summary>
        /// 从指定窗口的结构中取得信息
        /// </summary>
        /// <param name="hwnd">欲为其获取信息的窗口的句柄</param>
        /// <param name="nIndex">欲取回的信息</param>
        /// <returns></returns>
        [DllImport("user32", EntryPoint = "GetWindowLong")] //重写GetWindowLong函数

        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        #endregion

        #region 使窗口有鼠标穿透功能

        /// <summary>
        /// 使窗口有鼠标穿透功能
        /// </summary>

        private void CanPenetrate() //将当前窗口的句柄和其他信息传递过去
        { //this.Handle当前窗口句柄

            uint intExTemp = GetWindowLong(this.Handle, GWL_EXSTYLE);

            uint oldGWLEx = SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);

        }

        #endregion

        private void FrmDraw_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;//窗体不出现在Windows任务栏中
            CanPenetrate();
            this.TopMost = true;//使窗体始终在其它窗体之上
        }

    }
}
