using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
[SerializeField] private GameObject currentObjective;
[SerializeField] private int currentPuzzle;


public bool solved = false;


public void startPuzzle(){

switch(currentPuzzle){

case 0:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;
case 1:
gameObject.GetComponent<PasswordPuzzle>().startPuzzle();
break;
case 2:
gameObject.GetComponent<KeyCodePuzzle>().startPuzzle();
break;
case 3:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;
case 4:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;
case 5:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;
case 6:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;
default:
gameObject.GetComponent<AlarmPuzzle>().startPuzzle();
break;


}




   
}

public bool GetStatus()
{
    if(solved == true){

        currentObjective.GetComponent<Toggle>().isOn = true;

    }


    return solved;
}

public void setSolved(){

    solved = true;
    currentObjective.GetComponent<Toggle>().isOn = true;
}

public void setUnsolved(){

    solved = false;
}

}
