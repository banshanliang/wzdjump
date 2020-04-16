using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class enermy_jinstartwork : MonoBehaviour 
{
    private Animator ani;
    private Rigidbody2D rbody;
    //生成数量
    public int num = 0;

    //玩家
    public Transform target;
    //出生点和玩家之间的距离
    float distance;
    //敌人的预支体
    public Transform enermy;
    //敌人生成器
    protected Transform jin_transform;
    //消息提示
    private bool WindowShow = false;

    

    private void Start()
    {
        jin_transform = this.transform;
      
    }

    private void Update()
    {

        distance = Vector2.Distance(gameObject.transform.position,target.transform.position);
        if (distance <= 12)
        {
                num++;
            if (num == 1)
                WindowShow = true;
            
            if (num > 1)
            {
                return;
            }
            Transform transformenermy = (Transform)Instantiate(enermy, jin_transform.position, Quaternion.identity);
        }


    }
    //当进入碰撞之后，消息提示框消失
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        WindowShow = false;
    }

    //显示的窗口
    void MyWindow(int WindowID)

    {

        GUIStyle fontStyle = new GUIStyle();
        fontStyle.fontSize = 18;       //字体大小     
        GUI.Label(new Rect(30, 30, 250, 130), "不好！金爪神突然出现在火龙\n山谷，请空格键攻击击退他吧\n在这段路程中，您将无法通过\n跳跃进行躲避", fontStyle);

    }

    void OnGUI()

    {
        if (WindowShow == true)
        {
            GUI.Window(0, new Rect(30, 30, 300, 130), MyWindow, "dangerous");
        }

    }
}
