using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class GoldDragNShoot : MonoBehaviour
{
    private Vector3 mouseDownPos;
    private Vector3 mouseUpPos;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        mouseDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseUpPos = Input.mousePosition;
        Shoot();
    }

    void Shoot()
    {
        Vector3 f = mouseUpPos - mouseDownPos;
        rb.AddForce(new Vector3(f.x, f.y, f.magnitude) * 10);
    }
}
