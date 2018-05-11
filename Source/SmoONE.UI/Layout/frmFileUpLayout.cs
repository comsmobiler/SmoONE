using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmoONE.UI.Layout
{
    partial class frmFileUpLayout : Smobiler.Core.Controls.MobileUserControl
    {
      
        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Press(object sender, EventArgs e)
        {
            try
            {
              
                this.Client.File.Exists(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj, args) => {
                    if (args.Exists == false)
                    {
                        //文件下载
                        this.Client.File.Download(lblFile.BindDisplayValue.ToString(), MobileResourceManager.DefaultDocumentResourceName, (obj1, args1) => {
                            if (args1.isError == true)
                            {
                                throw new Exception(args1 .error );
                            }
                        });
                    }
                    else
                    {
                        this.Form.Toast("文件已存在，请打开！");
                    }
                });
               
            }
           
            catch(Exception ex)
            {
                this.Form.Toast(ex.Message, ToastLength.SHORT);
            }

        }      
    }
}