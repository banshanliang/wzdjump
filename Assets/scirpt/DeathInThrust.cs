using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class DeathInThrust : MonoBehaviour 
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
        {
            GUI.Window(0, new Rect(30, 30, 250, 130), MyWindow, "sorry to the end");
        }

    }

    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;
        GUI.Label(new Rect(30,30, 300, 130), "很不幸，您掉进了地刺\n游戏结束", fontStyle);

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
