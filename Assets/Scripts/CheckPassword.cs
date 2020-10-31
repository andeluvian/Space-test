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


public void checkanswer(){

if (username.text.ToUpper() == usernameInput.text.ToUpper()){
    Debug.Log("Username is correct!");
    

if (password.text.ToUpper() == passwordInput.text.ToUpper()){
    Debug.Log("Password is correct!");
    gameObject.GetComponent<Puzzle>().setSolved();
}
}
}
}
