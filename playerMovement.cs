using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    public InputAction leftRight;
    public InputAction upDown;
    private Vector3 movement;

    private void Start()
    {
        leftRight.Enable();
        upDown.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float magnitude = Mathf.Sqrt(Mathf.Pow(leftRight.ReadValue<float>(), 2) + Mathf.Pow(upDown.ReadValue<float>(), 2));
        if (magnitude != 0)
        {
            movement = new Vector3(leftRight.ReadValue<float>() / magnitude, upDown.ReadValue<float>() / magnitude, 0) * Time.deltaTime * movementSpeed;
        }
        else
        {
            movement = new Vector3(0, 0, 0);
        }
            this.gameObject.transform.position = this.gameObject.transform.position + movement;
    }
}
