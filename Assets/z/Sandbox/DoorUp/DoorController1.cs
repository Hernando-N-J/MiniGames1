using UnityEngine;

public class DoorController1 : MonoBehaviour
{
    public bool enterBool = false;
    public bool exitBool = false;
    public float doorSpeed;

    private void Start()
    {
        // * OnDoorwayTriggerEnter says to OnDoorwayOpen: Add me to your list of subscribed events
        // * When I activate (When I be dispatched), as you are listening to me
        // * I'll tell you: I am going... and you should execute your code
        GameEvents.instance.OnDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.instance.OnDoorwayTriggerExit += OnDoorwayClosed;
    }

    private void Update()
    {
        Time.timeScale = 1.5f;

        float moveSp = doorSpeed * Time.deltaTime;

        if (enterBool)
        {
            Debug.Log("1st enter cap");
            Debug.Log("local: " + transform.localPosition);
            Debug.Log("global: " + transform.position);
            transform.position = Vector3.Lerp(transform.position, Vector3.up * 2, moveSp);
            Debug.Log("2nd enter cap");
            Debug.Log("local: " + transform.localPosition);
            Debug.Log("global: " + transform.position);
        }


        if (exitBool)
        {
            Debug.Log("1st exit cap");
            Debug.Log("local: " + transform.localPosition);
            Debug.Log("global: " + transform.position);
            transform.position = Vector3.Lerp(transform.position, Vector3.down * 2, moveSp);

            Debug.Log("2nd exit cap");
            Debug.Log("local: " + transform.localPosition);
            Debug.Log("global: " + transform.position);

        }

    }

    // methods executed when their events are dispatched
    public void OnDoorwayOpen() { enterBool = true; exitBool = false; }
    public void OnDoorwayClosed() { exitBool = true; enterBool = false; }
}

// Update method
//  Vector3 tr = transform.position;

//    float a = doorSpeed * Time.deltaTime;
// -- Here the startPos variable is not being updated, so it will keep the same
// besides, the only 1 bool variable conflict
// And second line has not a good algorithm
// in next frame, the object returns to startPos because its value is not updated
// if (enterBool) 
// transform.position = Vector3.Lerp(startPos, Vector3.up * 2, a);
// else transform.position = Vector3.Lerp(Vector3.up * 2, startPos, a);

// -- possible solution, but the 1 bool variable issue still remains
// if (enterBool)
// {
//     transform.position = Vector3.Lerp(startPos, Vector3.up * 2, a);
//     startPos = transform.position;
// }
// else
// {
//     transform.position = Vector3.Lerp(Vector3.up * 2, startPos, a);
//     startPos = transform.position;
// }

// -- Here there code doesn't work properly... 2 events that need 2 bool variables, 1 for each other
// The code is executing the event (the else line) before entering on trigger area
// if (enterBool)
//     transform.position = Vector3.Lerp(transform.position, Vector3.up, a);
// else
//     transform.position = Vector3.Lerp(transform.position, Vector3.down, a);
//  if (enterBool)
// {
//     tr = Vector3.Lerp(tr, Vector3.up * 2, a);

//     transform.position = Vector3.Lerp(transform.position, Vector3.up * 2, doorSpeed * Time.deltaTime);
// }
// if (exitBool)
// {
//     tr = Vector3.Lerp(tr, Vector3.down * 2, a);
//     transform.position = Vector3.Lerp(transform.position, Vector3.down * 2, doorSpeed * Time.deltaTime);
// }

// with this lines trigger is not executed
// if (enterBool) tr = Vector3.Lerp(tr, Vector3.up * 2, moveSp);
// if (exitBool) tr = Vector3.Lerp(tr, Vector3.down * 2, moveSp);

//