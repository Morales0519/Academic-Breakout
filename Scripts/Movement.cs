﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int Move_Speed = 10;
    Vector3 mousePosition;
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        transform.position = transform.position + movement * Move_Speed * Time.deltaTime;
        mousePosition = Input.mousePosition;
        transform.LookAt(mousePosition);
    }
}
