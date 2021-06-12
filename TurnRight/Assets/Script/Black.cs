using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{
    private Animator ani;
    
    void Start()
    {
        ani = GetComponent<Animator>();
        
    }

    public void Upblack()
    {
        ani.SetBool("UP", true);

    }
    public void Downblack()
    {
  

    }
}
