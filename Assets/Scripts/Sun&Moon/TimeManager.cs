using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float _amplitude, _frequency, offset;
    Vector3 basePose;

    private void Start()
    {
        basePose = transform.position;
    }
    private void Update()
    {
        float alpha = Mathf.Sin(Time.time*_frequency+offset) * _amplitude;
        transform.position = basePose+Vector3.up*alpha;
    }
}
