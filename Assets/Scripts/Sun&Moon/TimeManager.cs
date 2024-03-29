using UnityEngine;

public class TimeManager : MonoBehaviour
{
    /// <summary>
    /// fonction sinusoïdale qui permet de faire monter et descendre le soleil et la lune
    /// </summary>
    [field: SerializeField] public float _amplitude, _frequency, offset;
    Vector3 _basePose;

    private void Start()
    {
        _basePose = transform.position;
    }
    private void Update()
    {
        float alpha = Mathf.Sin(Time.time*_frequency+offset) * _amplitude;
        transform.position = _basePose+Vector3.up*alpha;
    }
}
