using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private VirtualButtonBehaviour btn;
    public Animator anim;

    private void Start()
    {
        btn = GetComponent<VirtualButtonBehaviour>();
        btn.RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
         {
             anim.SetTrigger("worried");
         }
     
         public void OnButtonReleased(VirtualButtonBehaviour vb)
         {
             anim.SetTrigger("die");
         }
}
