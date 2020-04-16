using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class enermy_jin : MonoBehaviour
{
    private int dir =- 1;
    private Animator ani;
    private Rigidbody2D body;

    public bool WindowShow = false;


    private void Start()
    {
        ani = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

    }
    
    private void Update()
    {
        transform.Translate(Vector2.right * dir * 2f * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "bareel")
        {
            dir = -dir;
            if (dir < 0)
            {
                ani.SetBool("dir", true);
                ani.SetBool("stand", false);
            }
            else
            {
                ani.SetBool("dir", false);
                ani.SetBool("stand", false);
            }

            }
        if (collision.tag == "Player")
        {
            dir = 0;
            WindowShow = true;
            ani.SetBool("stand", true);
        }
        
    }

    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "您被金爪神拦截在通往月\n神殿的路途中，游戏结束", fontStyle);

    }

    void OnGUI()

    {
        if (WindowShow==true)
        {
            GUI.Window(0, new Rect(30, 30, 250, 130), MyWindow, "sorry to the end");
        }

    }
}
    
