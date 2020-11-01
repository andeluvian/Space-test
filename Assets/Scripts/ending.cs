using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ending : MonoBehaviour, InteractionHandler
{
    [SerializeField] private GameObject Player;
    // Start is called before the first frame update

 void OnCollisionEnter(Collider other){
         //other.name should equal the root of your Player object
         if (other.tag == "Player") {
             //The scene number to load (in File->Build Settings)
             SceneManager.LoadScene (0);
             Application.LoadLevel("menu");
         }
     }


 void OnTriggerEnter(Collider coll)
 {
          //other.name should equal the root of your Player object
         if (coll.tag == "Player") {
             //The scene number to load (in File->Build Settings)
             SceneManager.LoadScene (0);
             Application.LoadLevel("menu");
         }
     }

public void Activate(){

    //  SceneManager.LoadScene (0);
             Application.LoadLevel("menu");
}

public void Read(){}
 }

