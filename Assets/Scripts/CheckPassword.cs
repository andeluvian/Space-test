using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckPassword : MonoBehaviour
{

public Text username;
public Text password;
public InputField usernameInput;
public InputField passwordInput;

    [SerializeField] private GameObject[] TurnOnObjects;
    [SerializeField] private GameObject[] TurnOffObjects;
    [SerializeField] private GameObject[] DisableObjects;
    [SerializeField] private GameObject[] EnableObjects;



public void checkanswer(){

if (username.text.ToUpper() == usernameInput.text.ToUpper() && password.text.ToUpper() == passwordInput.text.ToUpper()){
    
    Debug.Log("Username and Password is correct!");
    complete();

}else{
Debug.Log("Username and Password is incorrect!");

}
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
