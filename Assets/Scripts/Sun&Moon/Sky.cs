using UnityEngine;

public class Sky : MonoBehaviour
{
    /// <summary>
    /// permet de pouvoir modifier la couleur du material "sky" en fonction du script "TimeManager"
    /// </summary>
    [field:SerializeField] public Gradient gradient { get ; private set; }
    [SerializeField] TimeManager timeManager;
    [SerializeField] Material mat;
    [SerializeField] Light _light;

    void Update()
    {
        float alpha = Mathf.Sin(Time.time * timeManager._frequency + timeManager.offset);
        alpha = (alpha + 1) * 0.5f;
        mat.SetColor("_BaseColor", gradient.Evaluate(alpha));
        _light.color = gradient.Evaluate(alpha);
    }
}
