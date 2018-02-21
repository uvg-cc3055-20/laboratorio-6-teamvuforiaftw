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
    public AudioClip electroSong;

    private VirtualButtonBehaviour btn;
    private int hopDir = 1;

    private void Start()
    {
        btn = GetComponent<VirtualButtonBehaviour>();
        btn.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audio.clip = electroSong;
        audio.Play();
        StartCoroutine(hopCoroutine());
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        audio.Stop();
        StopCoroutine(hopCoroutine());
    }

    private IEnumerator hopCoroutine()
    {
        while (true)
        {
            anim.SetInteger("hop" , hopDir);
            hopDir = (hopDir + 1) % 4;
            yield return new WaitForSeconds(0.5f);   
        }
    }
}
