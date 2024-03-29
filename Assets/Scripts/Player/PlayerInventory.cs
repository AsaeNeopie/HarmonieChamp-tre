using UnityEngine;


public class PlayerInventory : MonoBehaviour
{
    public int Gold { get; set; }
    public int CarrotSeed { get; set; }
    public int Carrot { get; set; }
    public int TomatoSeed { get; set; }
    public int Tomato {  get; set; }

    private void Start()
    {
        Gold = 3;
    }
}
