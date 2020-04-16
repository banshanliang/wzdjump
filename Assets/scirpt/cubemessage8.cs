using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cubemessage8 : MonoBehaviour 
{

    public bool WindowShow = false;//显示消息框

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision .tag =="Player")
        WindowShow = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        WindowShow = false;
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
        GUI.Label(new Rect(30, 30, 250, 130), "虽然被虎煞天袭击坠落下岩\n浆，但您意外发现了能源紫水\n晶矿！但是似乎需要钥匙。\n战斗等级lv.6->lv.8", fontStyle);
    }

}
