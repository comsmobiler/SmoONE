using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmFileUpLayout1 : Smobiler.Core.Controls.MobileUserControl
    {
        private void tpFileOpen_Press(object sender, EventArgs e)
        {
            //文件打开
            this.Client.File.Open(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj1, args1) => {
                if (args1.isError == true)
                {
                    throw new Exception(args1.error);
                }
            });
        }
        
        
        /// <summary>
        /// 文件打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Press(object sender, EventArgs e)
        {
            try
            {
                //文件打开
                this.Client.File.Open(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj1, args1) => {
                    if (args1.isError == true)
                    {
                        throw new Exception(args1.error);
                    }
                });

            }

            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Press(object sender, EventArgs e)
        {
            try
            {
                //文件上传
                this.Client.File.Upload((obj, args) => {
                    if (args.isError == false)
                    {
                        try
                        {
                            args.SaveFile(args.ResourceID, MobileResourceManager.DefaultDocumentPath);
                            this.Form.Toast("上传成功！",ToastLength.SHORT );
                        }
                        catch (Exception ex)
                        {
                            this.Form.Toast(ex.Message, ToastLength.SHORT);
                        }
                    }
                }
                );
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }
        }
        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Press(object sender, EventArgs e)
        {
            try
            {

                this.Client.File.Exists(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj, args) => {
                    if (args.Exists == true)
                    {
                        //删除手机上文件
                        this.Client.File.Delete(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj1, args1) => {
                            if (args1.isError == true  )
                            {
                                throw new Exception(args1.error);
                            }
                            else
                            {
                                ListViewRow row = this.Tag as ListViewRow;
                                ((FileUp.frmFileDetail)(this.Form)).RemoveRow(row);//删除当前列表行项
                               

                            }
                        });
                    }
                    else
                    {
                        this.Form.Toast("文件不存在，请下载文件到手机！");
                    }
                });

            }

            catch (Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }
        }
    }
}