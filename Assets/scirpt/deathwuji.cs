using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class deathwuji : MonoBehaviour 
{
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("ismessage4", false);
    }


                
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ani.SetBool("ismessage4", true);
        }
    }

}
