using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotatiion : MonoBehaviour
{
   public float FanrotationSpeed = 30f; 

    void Update()
    {

        transform.Rotate(Vector3.right, FanrotationSpeed * Time.deltaTime);
    
    }
}
