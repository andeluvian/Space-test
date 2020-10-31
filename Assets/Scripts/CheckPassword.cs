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

[SerializeField] private GameObject parent;



public void checkanswer(){

if (username.text.ToUpper() == usernameInput.text.ToUpper() && password.text.ToUpper() == passwordInput.text.ToUpper()){
    
    Debug.Log("Username and Password is correct!");
    parent.GetComponent<PasswordPuzzle>().complete();

}else{
Debug.Log("Username and Password is incorrect!");

}
}


}
