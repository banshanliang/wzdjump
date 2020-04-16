using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage7 : MonoBehaviour 
{
    public bool WindowShow = false;//显示消息框

    public Transform friend;
    private Transform xuanxuan;
    private int num = 0;

    private void Start()
    {
        xuanxuan = this.transform;
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
        GUI.Label(new Rect(30, 30, 250, 130), "很不幸，您最终没能战胜金\n爪神，并且被他制服住了.\n但是似乎...有谁前来了？", fontStyle);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            WindowShow = true;
            num++;
            if (num > 1)
            {
                return;
            }
            Transform transformenermy = (Transform)Instantiate(friend , xuanxuan.position, Quaternion.identity);
           
        }

        if (collision.tag == "friend")
        {
            WindowShow = false;
            Destroy(GetComponent<Collider2D>());
        }
    }


}
