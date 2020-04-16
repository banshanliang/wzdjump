using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class enermy_tigerstartwork : MonoBehaviour 
{
    private Animator ani;
    private Rigidbody2D rbody;
    //生成数量
    public int num = 0;
    
    //敌人的预支体
    public Transform enermy;
    //敌人生成器
    protected Transform tiger_transform;
    //消息提示
    private bool WindowShow = false;



    private void Start()
    {
        tiger_transform = this.transform;
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //当主角走进碰撞体的时候开始生成王上
        if (collision.tag == "Player")
        {
            num++;
            if (num == 1)
                WindowShow = true;

            if (num > 1)
            {
                return;
            }
            Transform transformenermy = (Transform)Instantiate(enermy, tiger_transform.position, Quaternion.identity);
        }
    }


}
