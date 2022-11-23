using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAM : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    public float sensMouse = 100f;//чувствительность
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensMouse * Time.deltaTime;
        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        transform.Rotate(mouseY * new Vector3(1, 0, 0));
    }
}
