using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*interactables
*This controller is attached to gameobjects that can be interacted with.
*Handler contains two functions Read and Activate.
*Read function activates a dialogue box for the player to read lore or get clues to solve puzzles.
*Activate function opens doors or operates computers.
*/
[RequireComponent(typeof(Collider))]
public class Interactables : MonoBehaviour
{


        [SerializeField]
        private string interactMessage;

        [SerializeField]
        private GameObject[] objectsWithActions;


        public void Activate()
        {

            foreach (GameObject o in objectsWithActions)
            {
                o.GetComponent<InteractionHandler>().Activate();
            }

        }

        public void Read()
        {

            foreach (GameObject o in objectsWithActions)
            {
                o.GetComponent<InteractionHandler>().Read();
            }

        }


        public string GetInteractionMessage()
        {
            return interactMessage;
        }
    }
