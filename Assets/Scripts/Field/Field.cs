using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public GameObject vegeteable;
    public int maxVegeteable = 5;
    [HideInInspector] public int nbVegeteable;
    public bool isCarrotField;
    public bool isTomatoField;
    public bool isCabbageField;
    public bool isTrompinnetteField;


    public void TryToPlantAt(Vector3 point)
    {
        if (nbVegeteable <= maxVegeteable)         
        {
            GameObject plantObject = Instantiate(vegeteable, point, Quaternion.identity);
            Plant plant = plantObject.GetComponent<Plant>();
            plant.Field = this;
            maxVegeteable++;
        }         
    }

    public void FreeSlot()
    {
        maxVegeteable--;
        Debug.Log(maxVegeteable);
    }
}
