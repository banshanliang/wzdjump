using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class enermy_tiger : MonoBehaviour 
{
    //刚体组件
    private Rigidbody2D rBody;
    //动画组件
    private Animator ani;

    private void Start()
    {

        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    //落到地上
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "ground")
            ani.SetBool("isstand", true);
    }

}
