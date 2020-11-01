using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPuzzle : MonoBehaviour
{

    [SerializeField] private GameObject Puzzle;
    [SerializeField] private GameObject[] TurnOnObjects;
    [SerializeField] private GameObject[] TurnOnObjectsDelay;
    [SerializeField] private GameObject[] TurnOffObjects;
    [SerializeField] private GameObject[] DisableObjects;
    [SerializeField] private GameObject[] EnableObjects;
    public float timer = 0.0f;
    public float wait = 5.0f;
public void startPuzzle(){


Puzzle.SetActive(true);


}

public void complete(){
TurnOn();
TurnOnDelay();
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
public void TurnOnDelay(){
new WaitForSeconds(6);
foreach(GameObject o in TurnOnObjectsDelay){
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

