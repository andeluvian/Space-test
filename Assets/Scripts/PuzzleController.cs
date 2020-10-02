using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour , InteractionHandler
{

    [SerializeField] private GameObject previousPuzzle;
    [SerializeField] private GameObject nextPuzzle;
    


public void Activate(){


    if(previousPuzzle.GetComponent<Puzzle>().GetStatus() == true){
        Debug.Log("This puzzle is ready for you!");
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

    private void isSolved()
    {

        if (previousPuzzle.name != previousPuzzle.name)
        {
          
            Debug.Log(previousPuzzle.name);
            Debug.Log(nextPuzzle.name);
        }
       
    }





}
