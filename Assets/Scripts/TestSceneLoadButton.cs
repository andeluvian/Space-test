using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneLoadButton : MonoBehaviour
{
      [SerializeField]
        private string GOToFind;

       public void Button(){

            Debug.Log("BUTTON BETWEEN SCENES WORKS");
            GameObject.Find(GOToFind);
            

        }



}
