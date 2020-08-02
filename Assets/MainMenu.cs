using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayLevel()
    {

        string level = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("loading level:" + level);
        SceneManager.LoadScene(level);
    }
public void QuitGame ()
    {
        Debug.Log("Thank you for playing!");
        Application.Quit();

    }
}
