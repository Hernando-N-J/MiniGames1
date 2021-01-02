﻿using UnityEngine;

public class HenController : MonoBehaviour
{
    private float moveSp = 5f;

    void Update()
    {
        InputMov();
    }

    public void InputMov()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveH, 0, moveV) * moveSp * Time.deltaTime;
        transform.Translate(mov);
    }
}
