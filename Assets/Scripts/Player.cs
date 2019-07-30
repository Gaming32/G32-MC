using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform head;
    private int view = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Toggle Perspective"))
        {
            Transform setValue;
            Transform child = transform.GetChild(0);
            view++; view %= 3;
            if (view == 0)
                setValue = child.GetChild(1);
            else if (view == 1)
                setValue = child.GetChild(2);
            else
                setValue = child.GetChild(3);
            Camera.main.transform.localPosition = setValue.localPosition;
            Camera.main.transform.localRotation = setValue.localRotation;
            Camera.main.transform.localScale = setValue.localScale;
        }
        if (transform.position.y < 0)
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
        else
            Camera.main.clearFlags = CameraClearFlags.Skybox;
        if (Input.GetButton("Sneak"))
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
