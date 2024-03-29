using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] private GameObject vegeteable;
    [field: SerializeField] public int MaxVegeteable {  get; private set; }
    public int NbVegeteable { get;  set; }
    [field: SerializeField] public bool IsCarrotField { get; set; }
    [field: SerializeField] public bool IsTomatoField { get; set; }


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
