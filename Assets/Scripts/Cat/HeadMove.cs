using UnityEngine;

public class HeadMove : MonoBehaviour
{
    [SerializeField] GameObject _player;

    private void FixedUpdate()
    {
        transform.LookAt(_player.transform.position);
    }
}
