using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class control : MonoBehaviour
{
    //刚体组件
    private Rigidbody2D rBody;
    //动画组件
    private Animator ani;
    //血量
    private int Hp = 1;
    //num1计算进入碰撞体时候的次数
    private int num = 0;

    private bool isGround;

    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Hp <= 0)
        {
            ani.SetBool("death", true);
        return;
        }
        

        //移动
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0 && num < 1)
        {
            Vector2 v = rBody.velocity;
            v.x = horizontal * 5;
            rBody.velocity = v;
            GetComponent<SpriteRenderer>().flipX = horizontal > 0 ? false : true;//左右翻转
            //播放动画
            ani.SetBool("iswalk", true);

        }
        else if (num == 2)
        {
            Destroy(GetComponent<Rigidbody2D>());
        }
        else
        {
            ani.SetBool("iswalk", false);
        }

        //跳跃
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGround == true)
        {
            rBody.AddForce(Vector2.up * 400);

            ani.SetBool("isjump", true);

            isGround = false;

        }

        //攻击动画
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("isbattle", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ani.SetBool("isbattle", false);
        }

        


    }

    //触碰出发
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //当触碰体是地面或者障碍物时能够进行跳跃
        if (collision.tag == "ground" || collision.tag == "bareel")
        {
            isGround = true;
        }
        //当触碰体是地刺时
        else if (collision.tag == "enermy")
        {
            Hp--;
        }
        //当碰见在月神殿途中的金将军时
        else if (collision.tag == "jin")
        {
            Hp--;

            rBody.velocity = Vector2.zero;
        }
        //当碰见在火龙山谷并且把金将军推到山谷边缘时
        else if (collision.tag == "jin2")
        {
            num = 1;
            if (num == 1)
            {
                ani.SetBool("death", true);
            }

        }
        //当旋旋与雷霆见面时
        else if (collision.tag == "Finish")
        {
            num = 0;
            ani.SetBool("death", false);
        }
        //在山崖边被王上打下去时
        else if (collision.tag == "tiger")
        {
            //禁止跳跃
            isGround = false;
            num = 1;
        }
        //当进入王上的碰撞体时
        else if (collision.tag == "effort")
        {
            rBody.AddForce(Vector2.right * 400);
            num = 0;
        }
        //遇见小急
        else if (collision.tag == "xiaoji")
        {
            ani.SetBool("ishand", true);
            num = 2;
        }
            ani.SetBool("isjump", false );
       
    }
    
}
