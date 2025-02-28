using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 1f;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
