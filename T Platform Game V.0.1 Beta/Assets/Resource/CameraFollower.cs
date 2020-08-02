using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

        Vector3 playerPosition = GameObject.Find("RobotPlayer").transform.position;
        
        transform.position = new Vector3(Mathf.Clamp(playerPosition.x,-2.5f,22.0f),Mathf.Clamp(playerPosition.y,0,2),-10);
  
    }

}
