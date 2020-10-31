using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour , InteractionHandler
{

    [SerializeField] private GameObject previousPuzzle = null;
    [SerializeField] private GameObject nextPuzzle;


    


public void Activate(){


    if(previousPuzzle.GetComponent<Puzzle>().GetStatus() == true || gameObject == previousPuzzle || previousPuzzle == null){
        Debug.Log("This puzzle is ready for you!");
        /*gameObject.GetComponent<AlarmPuzzle>().TurnOn();
        gameObject.GetComponent<AlarmPuzzle>().TurnOff();
        gameObject.GetComponent<AlarmPuzzle>().DisableGameObject();
        gameObject.GetComponent<AlarmPuzzle>().EnableGameObject();
        gameObject.GetComponent<Puzzle>().setSolved();*/
        gameObject.GetComponent<Puzzle>().startPuzzle();

    }
   else
    {
        Debug.Log("The previous puzzle was not solved!");
    }
}

public void Read()
{
    Debug.Log("I can Read");
}


}
