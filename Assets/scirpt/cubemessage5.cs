using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage5 : MonoBehaviour 
{
    public bool WindowShow = false;//显示消息框


    void OnGUI()

    {

        if (WindowShow)

            GUI.Window(0, new Rect(30, 30, 250, 130), MyWindow, "危险提示");

    }

    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "小心！前方有金爪神的埋\n伏,您现在尚不是他的对手，\n记得避开他", fontStyle);
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
