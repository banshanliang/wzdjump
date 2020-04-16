using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage2 : MonoBehaviour 
{
    private Rigidbody2D rCube;
    public bool WindowShow = false;
    private int num = 0;

    private void Start()
    {
        rCube = GetComponent<Rigidbody2D>();
    }
    void OnGUI()

    {

        if (WindowShow)

            GUI.Window(0, new Rect(30, 30, 250, 130), MyWindow, "等级提示");

    }

    void MyWindow(int WindowID)

    {
        GUIStyle  fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30,30, 300, 130), "您成功登上了断龙台\n战斗等级lv.1 -> lv.2", fontStyle);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            Debug.Log("show");

            WindowShow = true;
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        WindowShow = false;
    }



}
