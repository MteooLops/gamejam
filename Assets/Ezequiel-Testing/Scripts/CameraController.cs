using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera cam;
    
    [SerializeField]
    GameObject followTarget;

    [SerializeField]
    float distanceToTarget = 10f;
    [SerializeField]
    float springness = 1f; // TODO: Add soft camera effect



    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // Keep distance to object
        float dist = Vector3.Distance(transform.position, followTarget.transform.position);

        Vector3 dir = (transform.position - followTarget.transform.position).normalized;
        transform.position = followTarget.transform.position + dir * distanceToTarget;
    }
}
