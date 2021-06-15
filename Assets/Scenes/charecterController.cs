using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class charecterController : MonoBehaviour
{ public float speed = 10.0F;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical")*speed;
        float strafee = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        strafee *= Time.deltaTime;
        transform.Translate(strafee, 0, translation);
        if (Input.GetKeyDown("escape")) {
            Cursor.lockState = CursorLockMode.None;

        }

    }
}
