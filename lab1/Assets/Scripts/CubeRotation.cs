using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the cube around its y-axis continuously
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
