using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform head;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
        else
            Camera.main.clearFlags = CameraClearFlags.Skybox;
        if (Input.GetButton("Strafe"))
            transform.position += 2f * Time.deltaTime * Vector3.down;
        if (Input.GetButton("Jump"))
            transform.position += 2f * Time.deltaTime * Vector3.up;
        //float x = Mathf.Sin(head.rotation.y) * 2f * Input.GetAxis("Horizontal") * Time.deltaTime;
        //float y = Mathf.Cos(head.rotation.y) * 2f * Input.GetAxis("Vertical") * Time.deltaTime;
        Vector3 movement;
        movement = 2f * Input.GetAxis("Horizontal") * Time.deltaTime * head.right;
        movement.y = 0;
        transform.position += movement;
        movement = 2f * Input.GetAxis("Vertical") * Time.deltaTime * head.forward;
        movement.y = 0;
        transform.position += movement;
    }
}
