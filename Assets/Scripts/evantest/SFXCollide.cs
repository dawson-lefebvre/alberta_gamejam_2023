using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXCollide : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;

    [SerializeField] int delayFramesDefault = 30;
    int delayFrames;

    private void Awake()
    {
        //source.playOnAwake = false; doeant work like that, just turn it off
        delayFrames = delayFramesDefault;
        source.clip = clip;
    }

    private void FixedUpdate()
    {
        delayFrames--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (delayFrames <= 0) { source.Play(); delayFrames = delayFramesDefault; };
        
    }
}
