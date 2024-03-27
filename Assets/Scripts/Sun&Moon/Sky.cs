using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public Gradient mesboules;
    [SerializeField] TimeManager timeManager;
    [SerializeField] Material mat;
    [SerializeField] Light _light;
    void Update()
    {
        float alpha = Mathf.Sin(Time.time * timeManager._frequency + timeManager.offset);
        alpha = (alpha + 1) * 0.5f;
        mat.SetColor("_BaseColor", mesboules.Evaluate(alpha));
        _light.color = mesboules.Evaluate(alpha);
    }
}
