using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour, InteractionHandler
{
    Animator _doorAnim;

    public void Activate()
    {

        
        
        if(_doorAnim.GetBool("isOpen") == true)
        {
            Debug.Log("Door is closing");
            _doorAnim.SetBool("isOpen",false);
        }
        else
        {
            Debug.Log("Door is opening");
            _doorAnim.SetBool("isOpen",true);
        }
        
        
    }
    public void Read(){}

    // Start is called before the first frame update
    void Start()
    {
        _doorAnim = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
