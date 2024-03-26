using UnityEngine;

public class GoSell : MonoBehaviour
{
    [SerializeField] GameObject _sellPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _sellPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _sellPanel.SetActive(false);
        }
    }
}
