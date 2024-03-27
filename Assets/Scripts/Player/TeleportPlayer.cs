using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {       
        Debug.Log(other.name);
        other.transform.position = new Vector3(20,1,0);       
    }
}
