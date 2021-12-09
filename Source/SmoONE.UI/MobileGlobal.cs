using Smobiler.Core;
using Smobiler.Core.Controls;
using SmoONE.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 全局类
/// </summary>
public class MobileGlobal
{
    /// <summary>
    /// 在服务启动时触发
    /// </summary>
    /// <param name="server"></param>
    public static void OnServerStart(MobileServer server)
    {//若是使用Smobiler Service部署，请去除下面注释
     // AutomapperConfig.Init();
    }
    /// <summary>
    /// 在服务停止时触发
    /// </summary>
    /// <param name="server"></param>
    public static void OnServerStop(MobileServer server)
    {

    }

    /// <summary>
    /// 在客户端会话第一次开始时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionStart(object sender, SmobilerSessionEventArgs e)
    {

    }
    /// <summary>
    /// 在客户端会话结束时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionStop(object sender, SmobilerSessionEventArgs e)
    {

    }
    /// <summary>
    /// 在客户端会话重新连接时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnSessionConnect(object sender, SmobilerSessionEventArgs e)
    {
    
    }
    /// <summary>
    /// 在回调推送被客户端点击时触发
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OnPushCallBack(object sender, ClientPushOpenedEventArgs e)
    {
     
    }
}
