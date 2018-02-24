using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Vuforia;

public class VirtualButtonHop : MonoBehaviour,
    IVirtualButtonEventHandler
{
    public Animator anim;
    public AudioSource audio;

    private VirtualButtonBehaviour btn;

    private void Start()
    {
        btn = GetComponent<VirtualButtonBehaviour>();
        btn.RegisterEventHandler(this);
        anim.SetInteger("hop", -1);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audio.Play();
        anim.SetTrigger("peck");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}
