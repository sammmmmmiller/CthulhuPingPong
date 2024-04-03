using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPaddle : MonoBehaviour
{
    //[SerializeField]
    //public GameObject paddle;
    // Start is called before the first frame update
    [SerializeField]
    public Camera camera;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.y = transform.position.y;
        print(mouseWorldPosition);
        transform.position = mouseWorldPosition;
    }
}
