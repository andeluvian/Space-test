using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
[SerializeField] private GameObject currentObjective;
public bool solved = false;

public bool GetStatus()
{
    if(solved == true){

        currentObjective.GetComponent<Toggle>().isOn = true;

    }


    return solved;
}


}
