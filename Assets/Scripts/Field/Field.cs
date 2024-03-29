using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] private GameObject vegeteable;
    public int MaxVegeteable = 5;
    [HideInInspector] public int NbVegeteable;
    public bool IsCarrotField;// { get; set; }
    public bool IsTomatoField;// { get; set; }

    public void TryToPlantAt(Vector3 point)
    {
        if (NbVegeteable <= MaxVegeteable)         
        {
            GameObject plantObject = Instantiate(vegeteable, point, Quaternion.identity);
            Plant plant = plantObject.GetComponent<Plant>();
            plant.Field = this;
            MaxVegeteable++;
        }         
    }

    public void FreeSlot()
    {
        MaxVegeteable--;
        Debug.Log(MaxVegeteable);
    }
}
