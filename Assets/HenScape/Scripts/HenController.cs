﻿using UnityEngine;

public class HenController : MonoBehaviour
{
    // TODO modify script with command pattern when animations are available
    [SerializeField] private float moveSp = 5f;

    private void Start() 
    { 

    }
   

    void Update() { InputMov(); }

    public void InputMov()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveH, 0, moveV) * moveSp * Time.deltaTime;
        transform.Translate(mov);
    }
}
