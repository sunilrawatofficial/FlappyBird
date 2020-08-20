using UnityEngine;

public class Dragger : MonoBehaviour
{



    float Ysensitivity=2f;
    float rotationY = 0f;

    void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");

        rotationY += Input.GetAxis("Mouse Y") * Ysensitivity;
        rotationY = Mathf.Clamp(rotationY, -60, 60);
        transform.localEulerAngles = new Vector3(rotationY, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
    private void OnMouseDown()
    {
        Debug.LogWarning("dbaa");
    }

}