using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmPuzzle : MonoBehaviour
{


    [SerializeField] private GameObject[] TurnOnObjects;
    [SerializeField] private GameObject[] TurnOffObjects;
    [SerializeField] private GameObject[] DisableObjects;
    [SerializeField] private GameObject[] EnableObjects;


public void startPuzzle(){
    complete();
}


public void complete(){
TurnOn();
TurnOff();
DisableGameObject();
EnableGameObject();
gameObject.GetComponent<Puzzle>().setSolved();
}

public void TurnOn(){

foreach(GameObject o in TurnOnObjects){
o.SetActive(true);
}

}
public void TurnOff(){

foreach(GameObject o in TurnOffObjects){
o.SetActive(false);
}
}
public void DisableGameObject(){
foreach(GameObject o in DisableObjects){
o.GetComponent<BoxCollider>().enabled = false;
}
}

public void EnableGameObject(){
foreach(GameObject o in EnableObjects){

//o.GetComponent<DoorControl>().enabled = true;
o.GetComponent<Collider>().enabled = true;
}
}

}
