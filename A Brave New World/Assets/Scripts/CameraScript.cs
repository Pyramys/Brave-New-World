using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform newTransform;
    [SerializeField] private float flt_distance;
    [SerializeField] private float flt_xSpeed = 125;
    [SerializeField] private bool bool_rightClicked;
    [SerializeField] private float flt_x = 0;


    // Start is called before the first frame update
    void Start()
    {
        var angles = transform.eulerAngles;
        flt_x = angles.y;
        newTransform = transform.parent.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            bool_rightClicked = true;
        }
        else
        {
            bool_rightClicked = false;
        }
    }

    void LateUpdate()
    {
        if (newTransform && bool_rightClicked == true)
        {
            flt_x += (float)(Input.GetAxis("Mouse X") * flt_xSpeed * flt_distance * 0.02);
            var rotation = Quaternion.Euler(0, flt_x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -flt_distance) + newTransform.position;
            transform.rotation = rotation;
            transform.position = position;
        }
    }
}