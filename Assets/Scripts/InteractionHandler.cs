using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* InteractionHandler
 * 
 *This controller connects to all gameobjects that can be interacted with , clues , buttons and computers
 *
 *
*/
public interface InteractionHandler
{
    /* Activate FUNCTION
    *This function activates switches 
    *
    */



    void Activate();

    /* READ FUNCTION
    *This function prompts clues and dialogue from journals
    *
    */
    void Read();


}


