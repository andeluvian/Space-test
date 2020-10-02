using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour , InteractionHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void Activate()
    {
        Debug.Log("Hey im activing a cube too");

    }
    public void Read()
    {
        Debug.Log("Hey im reading a cube too");

    }
}
