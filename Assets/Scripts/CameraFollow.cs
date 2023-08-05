using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GLSLVectors;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject followPoint;
    [SerializeField] float followSpeed = 5f;
    [SerializeField] float smoothingFactor = 2f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followVector = F.vec3(followPoint.transform.position.x, transform.position.y, followPoint.transform.position.z);

        //gameObject.transform.Translate(followVector.xz() * followSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, followVector.xyz(), followSpeed * Time.deltaTime);
        //rb.MovePosition(transform.position + followVector.xyz() * Time.deltaTime * followSpeed);
    }
}
