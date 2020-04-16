using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage6 : MonoBehaviour 
{
    public bool WindowShow = false;//显示消息框


    void OnGUI()

    {

        if (WindowShow)

            GUI.Window(0, new Rect(30, 30, 350, 130), MyWindow, "等级提示");

    }

    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "虽然未找到急速锋，但是您成功与力元\n霸成为了同伴！lv.4->lv.5\n请继续加油，前往能源之城救助吧", fontStyle);
    }


    private void OnCollisionEnter2D(Collision2D collision)//有碰撞发生时则显示消息框
    {
        WindowShow = true;

    }

    private void OnCollisionExit2D(Collision2D collision)//碰撞离开时消息框消失
    {

        WindowShow = false;
    }

}
