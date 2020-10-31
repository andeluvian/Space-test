using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
[SerializeField] private GameObject currentObjective;
[SerializeField] private string currentPuzzle;

public bool solved = false;


public void startPuzzle(){

gameObject.GetComponent<AlarmPuzzle>().startPuzzle();



   
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
