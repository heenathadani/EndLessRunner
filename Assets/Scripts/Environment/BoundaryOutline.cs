using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryOutline : MonoBehaviour
{
    public static float left = -4f;
    public static float right = 4f;
    public static float down = 14.7f;
    public float leftIn;
    public float rightIn;  
    void Update()
    {
        leftIn = left;
        rightIn = right;
    }
} 
