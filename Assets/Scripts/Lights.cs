using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour, InteractionHandler
{

private bool LightsOn = false;

public void Read(){}
public void Activate(){


if (LightsOn == false){

    gameObject.SetActive(true);
    LightsOn = true;

}
else{
gameObject.SetActive(false);
LightsOn = false;
}

 }
}
