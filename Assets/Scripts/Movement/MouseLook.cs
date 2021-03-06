using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float rotationX = 0f;
    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
