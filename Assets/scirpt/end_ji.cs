using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class end_ji : MonoBehaviour 
{
    private Animator ani;
    public bool WindowShow = false;//显示消息框

    private void Start()
    {
        ani = GetComponent<Animator >();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            WindowShow = true;
            ani.SetBool("isstand", true);
        }
    }

    void OnGUI()
    {
        if (WindowShow)
            GUI.Window(0, new Rect(30, 30, 270, 130), MyWindow, "等级提示");
    }

    void MyWindow(int WindowID)
    {
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "恭喜您，成功在能源之城与您\n唯一心意相通之战友汇合。\n战斗等级lv.8->lv.10,游戏至此\n结束", fontStyle);
    }


}
