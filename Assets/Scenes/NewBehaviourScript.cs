
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 mouselook;
    Vector2 smoothv;

    public float Sensitivity = 5.0f;
    public float smoothing = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    GameObject charecter;

    // Use this for initialization
    void Start()
    {
        charecter = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(Sensitivity * smoothing, Sensitivity * smoothing));
        smoothv.x=Mathf.Lerp(smoothv.x,md.x,1f / smoothing);
        smoothv.y = Mathf.Lerp(smoothv.y, md.y, 1f / smoothing);
        mouselook += smoothv;

        transform.localRotation = Quaternion.AngleAxis(-mouselook.y, Vector3.right);
        charecter.transform.localRotation = Quaternion.AngleAxis(mouselook.x, charecter.transform.up);

    }
}