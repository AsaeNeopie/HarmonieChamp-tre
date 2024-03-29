using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] GameObject _respawnPoint;
    private void OnTriggerEnter(Collider other)
    {       
        Debug.Log(other.name);
        other.gameObject.transform.position = _respawnPoint.transform.position;       
    }
}
