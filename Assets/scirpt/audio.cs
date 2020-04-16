using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class audio : MonoBehaviour 
{
    public static audio Instance;
    private AudioSource player;

    private void Start()
    {
        Instance = this;
        player = GetComponent<AudioSource>();
    }

    private void PlaySound(string name)//播放声音
    {
        AudioClip clip= Resources.Load<AudioClip>(name);
        player.PlayOneShot(clip);
    }

    private void StopSound()
    {
        player.Stop();
    }


}
