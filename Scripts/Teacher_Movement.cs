using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher_Movement : MonoBehaviour
{
    public int Y_Move = 1;
    public int X_Move = 1;
    public float Move_Speed = 10;
    
    // Update is called once per frame


    void Update()
    {
        Vector3 movement = new Vector3(X_Move, Y_Move, 0.0f);
        transform.position = transform.position + movement * Move_Speed * Time.deltaTime;
    }
}
