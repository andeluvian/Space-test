using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* InteractionController
 * 
 *This controller is attached to the player gameObject camera.
 *The controller works by shooting rays from the player on gameObjects to determin if they are interactable or not.
*/

public class InteractionController : MonoBehaviour
{

    [SerializeField]
    private float minInteractionDistance;

    [SerializeField]
    private GameObject rayOrigin;


    private Ray ray;

    private bool isInteractable;

    private Interactables interact;


    private void Start()
    {

    }

    void Update()
    {
        CheckRaycast();
        if (isInteractable)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
               if(interact.gameObject.tag == "InteractiveObject")interact.Activate();
               if(interact.gameObject.tag == "Clue")interact.Read();
               if(interact.gameObject.tag == "test") Debug.Log("TEST");

            }

        }

    }
    private void CheckRaycast()
    {
        ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {


            if (hit.distance < minInteractionDistance)
            {


                interact = hit.transform.gameObject.GetComponent<Interactables>();

                if (interact != null)
                {

                   // Debug.Log(interact.GetInteractionMessage());

                    isInteractable = true;

                }
                else
                {
                    isInteractable = false;
                }
            }
        }


    }

}

