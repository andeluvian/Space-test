using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCodePuzzle : MonoBehaviour
{


    [Header("Keypad Settings")]
    public string curPassword = "222";
    public string input;
    public Text displayText;
    public AudioSource audioData;

    //Local private variables
    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;
    [SerializeField] private GameObject[] TurnOnObjects;
    
    [SerializeField] private GameObject[] TurnOffObjects;




// Start is called before the first frame update
    void Start()
    {
        btnClicked = 0; // No of times the button was clicked
        numOfGuesses = curPassword.Length; // Set the password length.
    }

    // Update is called once per frame
    void Update()
    {
        if (btnClicked == numOfGuesses)
        {
            if (input == curPassword)
            {
                //Load the next scene
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
                // LOG message that password is correct
                Debug.Log("Correct Password!");
                input = ""; //Clear Password
                btnClicked = 0;

            }
            else
            {
                //Reset input varible
                input = "";
                displayText.text = input.ToString();
                audioData.Play();
                btnClicked = 0;
            }

        }

    }
 public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                
                foreach(GameObject o in TurnOffObjects){
o.SetActive(false);
}
                foreach(GameObject o in TurnOnObjects){
o.SetActive(true);
}
                btnClicked = 0;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }


    }
}
