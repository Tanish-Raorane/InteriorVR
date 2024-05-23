using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public Renderer wallRenderer;

    public Material [] materials ;
    
    void Start()
    {
        
    }

    public void OnPress1()
    {
        wallRenderer.material = materials[0];
    }

    public void OnPress2()
    {
        wallRenderer.material = materials[1];
    }

    public void OnPress3()
    {
        wallRenderer.material = materials[2];
    }

    public void OnPress4()
    {
        wallRenderer.material = materials[3];
    }

    public void OnPress5()
    {
        wallRenderer.material = materials[4];
    }

    public void OnPress6()
    {
        wallRenderer.material = materials[5];
    }

    void Update()
    {
        
    }
}
