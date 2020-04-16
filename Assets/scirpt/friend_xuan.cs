using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class friend_xuan : MonoBehaviour
{
    //刚体组件
    private Rigidbody2D rBody;
    //动画组件
    private Animator ani;

    public Transform target;

    private bool WindowShow=false;

    private void Start()
    {

        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        Vector2 pos = transform.position;
        Vector2 postarget = target.position;

        if ((postarget.x - pos.x) > 2)
        {
            WindowShow = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ani.SetBool("ground",true );
        if (collision.tag == "jin2") 
        {
            WindowShow = true ;

            Destroy(GetComponent<Collider2D>());
            Destroy(GetComponent<Rigidbody2D>());
        }
    }

    void OnGUI()
    {
        if (WindowShow)
            GUI.Window(0, new Rect(30, 30, 270, 160), MyWindow, "等级提示");
    }

    void MyWindow(int WindowID)
    {
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "由于逆风旋的及时出手相救,\n青甲兽没能偷袭 成功。\n您试图拉拢逆风旋，但很遗\n憾被拒绝了。\n战斗等级lv.5->lv.6", fontStyle);
    }

}
