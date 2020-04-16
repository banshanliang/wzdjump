using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class cameralcontrol : MonoBehaviour 
{
    //跟随目标
    public Transform target;
    private float MinX;
    private float MaxX;
    private float MaxY;
    private float MinY;
    

    private void Update()
    {
        Vector3 v = transform.position;
            v.x = target.position.x;

        if (v.x > 135&&v.x<163)
        {
            MinX = (float)140.41;
            MinY = (float)-32.7;
            MaxX = (float)156.79;
        }
        else
        {

            MinX = (float)-42.8;
            MaxX = (float)188;
            MaxY = (float)8.1;
            MinY = (float)-3.96;
        }

        if (v.x < MinX)
        {
            v.x = MinX;
        }
        else if (v.x > MaxX)
        {
            v.x = MaxX;
        }
        
        if (target.position .y  > MinY  )
        {
            v.y = target.position.y;
            if (v.y > MaxY)
            {
                v.y = MaxY;
            }   
        }
        

        transform.position = v;
    }

}
