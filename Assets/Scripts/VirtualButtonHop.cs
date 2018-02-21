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
    private int hopDir = 0;

    private void Start()
    {
        btn = GetComponent<VirtualButtonBehaviour>();
        btn.RegisterEventHandler(this);
        anim.SetInteger("hop", -1);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        audio.clip = electroSong;
        audio.Play();
        StartCoroutine(WaitForAnimToEnd());
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        audio.Stop();
        anim.SetTrigger("die");
    }

    private IEnumerator WaitForAnimToEnd()
    {
        anim.SetInteger("hop", hopDir);
        hopDir = (hopDir + 1) % 4;
        yield return new WaitForSeconds(0.1f);
        anim.SetInteger("hop", -1);
    }
}
