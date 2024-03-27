using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject Carrot;
    [HideInInspector] public int _maxCarrot = 1;

   public void TryToPlantAt(Vector3 point)
    {
        Debug.Log("ScriptLancé");
        if (_maxCarrot <= 5)         
        {
            Instantiate(Carrot, point, Quaternion.identity);
            _maxCarrot++;
        }         
    }
}
