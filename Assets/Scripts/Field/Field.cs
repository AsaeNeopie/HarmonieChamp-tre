using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject Carrot;
    [HideInInspector] public int maxCarrot = 1;

   public void TryToPlantAt(Vector3 point)
    {
        Debug.Log("ScriptLanc�");
        if (maxCarrot <= 5)         
        {
            Instantiate(Carrot, point, Quaternion.identity);
            maxCarrot++;
        }         
    }
}
