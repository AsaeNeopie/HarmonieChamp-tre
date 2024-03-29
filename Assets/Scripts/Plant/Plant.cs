using System.Collections;
using UnityEngine;

public class Plant : MonoBehaviour
{
    /// <summary>
    /// Permet de faire poussez une plante
    /// </summary>
    [SerializeField] float _timeToGrow;
    [field: HideInInspector] public bool CanHarvest { get; set; }
    [field :SerializeField] public bool IsCarrot {  get; private set; }
    [field: SerializeField] public bool IsTomato { get; private set; }
    public Field Field { get; set; }


    void Start()
    {
        StartCoroutine(Grow());
        CanHarvest = false;       
    }
    
    IEnumerator Grow() // modifie la position en y temps que _timeToGrow n'est pas arrivé a 0
    {
        Vector3 basePosition = transform.position;
        Vector3 endPosition = transform.position + Vector3.up;
        float endTime = Time.time + _timeToGrow;
        while (Time.time < endTime)
        {
            float alpha = 1 - (endTime - Time.time) / _timeToGrow;
            transform.position = Vector3.Lerp(basePosition, endPosition, alpha);
            yield return 0;
        }
        transform.position = endPosition;
        CanHarvest = true;
    } 
}
