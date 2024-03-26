using System.Collections;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] float _timeToGrow;
    [HideInInspector] public bool _canHarvest;
    void Start()
    {
        StartCoroutine(Grow());
        _canHarvest = false;
    }
    IEnumerator Grow() // boucle update jusqu'a la fin de la boucle while (une fois endTime depassé)
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
        _canHarvest = true;
        
    } 
}
