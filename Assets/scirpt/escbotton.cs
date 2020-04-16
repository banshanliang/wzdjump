using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class escbotton : MonoBehaviour 
{
    private Button butt;
    
    public void Click_text()
    {
#if UNITY_EDITOR
        if (UnityEditor.EditorUtility.DisplayDialog("退出游戏", "您确认要退出游戏？", "是", "错"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
        Application.Quit();
#endif 
        
    }
    
}
