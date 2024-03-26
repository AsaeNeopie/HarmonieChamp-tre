using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject Carrot;
    

   public void TryToPlantAt(Vector3 point)
    {
        //regarder si le champ est pas plein (connard)
        // add 1 a carrot
        Instantiate(Carrot, point, Quaternion.identity);
    }
}
