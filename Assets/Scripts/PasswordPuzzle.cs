using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPuzzle : MonoBehaviour
{


    [SerializeField] private GameObject[] TurnOnObjects;

    
public void startPuzzle(){

foreach(GameObject o in TurnOnObjects){
o.SetActive(true);
}

}
}

