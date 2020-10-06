using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour , InteractionHandler
{


    [SerializeField]
    private Color activeColor;
    [SerializeField]
    private Color inactiveColor;
    [SerializeField]
    private Material material; // currently does not work, TO-DO come back to fix later
    private bool activated;

    // Start is called before the first frame update
    void Start()
    {
        material.SetColor("_EmissionColor", inactiveColor);
    }

    // Update is called once per frame

    public void Activate()
    {
        Debug.Log("Switch has been activated");
        activated = !activated;
        if (activated)
        {
            material.SetColor("_EmissionColor", activeColor);
        }
        else
        {
            material.SetColor("_EmissionColor", inactiveColor);
        }

    }
    public void Read()
    {
        Debug.Log("Hey im reading a cube too");

    }
}
