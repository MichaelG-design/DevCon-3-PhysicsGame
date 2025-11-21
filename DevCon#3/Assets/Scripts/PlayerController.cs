using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController cc;

    public float speed = 5f;
    public Transform cam;
    public float sensitivity = 2f;

    float xRot = 0f;

    void Start()
    {
        cc = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cc.Move(move * speed * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(0, mouseX, 0);

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -80f, 80f);
        cam.localRotation = Quaternion.Euler(xRot, 0, 0);
    }
}
