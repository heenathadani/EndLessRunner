using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float playerSpeed = 6;
    public float horizontalSpeed = 2;
    static public bool canMove = true;
    

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World); 

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > BoundaryOutline.left)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }        
        } 
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x < BoundaryOutline.right)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            }
        } 
    }
    
}
