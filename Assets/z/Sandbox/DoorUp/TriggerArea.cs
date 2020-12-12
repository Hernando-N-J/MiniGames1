using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{

    public DoorController dc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // the called method DoorwayTriggerEnter dispatches an event 
            // that will be listened by other script, which will execute a code
            GameEvents.instance.DoorwayTriggerEnter();
            Debug.Log("ontrigger enter called");
            Debug.Log("enterbool = " + dc.enterBool);
            Debug.Log("exitbool = " + dc.exitBool);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // the called method DoorwayTriggerEnter dispatches an event 
            // that will be listened by other script, which will execute a code
            GameEvents.instance.DoorwayTriggerExit();
            Debug.Log("ontrigger exit called");
            Debug.Log("enterbool = " + dc.enterBool);
            Debug.Log("exitbool = " + dc.exitBool);
        }

    }



}
