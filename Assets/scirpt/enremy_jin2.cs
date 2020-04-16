using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class enremy_jin2 : MonoBehaviour 
{
    //方向
    private int dir = -1;
    //动画组件
    private Animator ani;
    //金将军自身刚体组件
    private Rigidbody2D body;
    //金将军与雷霆之间的距离
    float distance;
    //雷霆目标
    public Transform target;
    

    //用于记录是否进入预设位置点并且停止行动
    private int num = 0;
    

    private void Start()
    {
        //获取刚体组件以及动画组件
        ani = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

      
    }

    private void Update()
    {
        Vector2 pos = transform.position;
        Vector2 postarget = target.position;
        //运动速度为2f
        if (num < 1)
        {
            transform.Translate(Vector2.right * dir * 2f * Time.deltaTime);

            if ((postarget.x -pos.x)>0)
            {
                dir = 1;
                ani.SetBool("isdir", true);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ani.SetBool("isbattle", true);
        }
        if (collision.tag == "jin3")
        {
                num++;
                ani.SetBool("iswin", true);
            Destroy(GetComponent<Rigidbody2D>());
            Destroy(GetComponent<Collider2D>());
            

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ani.SetBool("isbattle", false);
    }


}
