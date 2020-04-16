using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage3 : MonoBehaviour 
{
    public bool WindowShow = false;//显示消息框
    private int num = 0;
    
    
    void OnGUI()

    {

        if (WindowShow)

            GUI.Window(0, new Rect(30, 30, 250, 130), MyWindow, "等级提示");

    }

    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30,30, 250, 130), "您成功回到了时光之城\n并与师父汇合\n战斗等级lv.3 -> lv.4", fontStyle);
    }


    private void OnCollisionEnter2D(Collision2D collision)//有碰撞发生时则显示消息框
    {
        num++;
        if (num == 1) { 

        WindowShow = true;
    }
    }

    private void OnCollisionExit2D(Collision2D collision)//碰撞离开时消息框消失
    {

        WindowShow = false;
    }

}
