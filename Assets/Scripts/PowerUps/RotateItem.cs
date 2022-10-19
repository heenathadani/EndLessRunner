using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour
{
    public int rSpeed = 1;

    void Update()
    {
        transform.Rotate(0, rSpeed, 0, Space.World);        
    }
}
