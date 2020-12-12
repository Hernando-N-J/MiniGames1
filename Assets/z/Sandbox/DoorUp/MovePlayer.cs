using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float moveV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        Vector3 movePlayer = new Vector3(moveH, 0, moveV);
        transform.position += movePlayer;
    }
}
