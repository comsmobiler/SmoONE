using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;
using System.Drawing;

namespace SmoONE.UI.Layout
{
    [System.ComponentModel.ToolboxItem(true)]
    partial class ImageButton : Smobiler.Core.Controls.MobileUserControl
    {
       
            /// <summary>
            /// 图像资源名称
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像资源名称")]
            public string ResourceID
            {
                get
                {
                    return this.imageEx1.ResourceID;
                }
                set
                {
                    this.imageEx1.ResourceID = value;
                }
            }
       
            /// <summary>
            /// 图像类型
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像类型")]
            public ImageEx.ImageStyle ImageType
            {
                get
                {
                    return this.imageEx1.ImageType;
                }
                set
                {
                    this.imageEx1.ImageType = value;
                }
            }

            /// <summary>
            /// 图像模式
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像模式")]
            public ImageSizeMode SizeMode
            {
                get
                {
                    return this.imageEx1.SizeMode;
                }
                set
                {
                    this.imageEx1.SizeMode = value;
                }
            }
          
       

            /// <summary>
            /// 文本
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("设置文本")]
            public string DisplayMember
            {
                get
                {
                    return this.label1.DisplayMember;
                }
                set
                {
                    this.label1 .DisplayMember = value;
                }
            }
            /// <summary>
            /// 文本
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("设置文本")]
            public string Text
            {
                get
                {
                    return this.label1.Text;
                }
                set
                {
                    this.label1.Text  = value;
                }
            }

            /// <summary>
            /// 文本颜色
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("设置文本颜色")]
            public Color ForeColor
            {
                get
                {
                    return this.label1.ForeColor;
                }
                set
                {
                    this.label1.ForeColor = value;
                }
            }

            /// <summary>
            /// 文本字体大小
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("设置文本字体大小")]
            public float FontSize
            {
                get
                {
                    return this.label1.FontSize;
                }
                set
                {
                    this.label1.FontSize = value;
                }
            }

        /// <summary>
        /// 图像资源颜色
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("图像资源颜色")]
        public System.Drawing.Color IconColor
        {
            get
            {
                return this.imageEx1.IconColor;
            }
            set
            {
                this.imageEx1.IconColor = value;
            }
        }

        /// <summary>
        /// 文本水平方式
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("设置文本字水平方向")]
            public HorizontalAlignment HorizontalAlignment
            {
                get
                {
                    return this.label1.HorizontalAlignment;
                }
                set
                {
                    this.label1.HorizontalAlignment = value;
                }
            }

            /// <summary>
            /// 在触摸操作激活时触发
            /// </summary>
            [Browsable(true), Category("Appearance"), DefaultValue(""), Description("在触摸操作激活时触发")]
            public event EventHandler Press;

         
           
            private void panel1_Press(object sender, EventArgs e)
            {
                if (Press != null) Press(this, EventArgs.Empty);
            }
        }

       
  

}