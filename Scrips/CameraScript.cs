using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetBird;

  
    void LateUpdate()
    {
        transform.position = new Vector3(
            targetBird.position.x,
            transform.position.y, 
            transform.position.z);  
    }
}
