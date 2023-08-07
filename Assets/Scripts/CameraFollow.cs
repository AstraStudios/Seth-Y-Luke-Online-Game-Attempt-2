using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GLSLVectors;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject followPoint;
    [SerializeField] GameObject player;
    [SerializeField] float camFollowSpeed = 7f;
    [SerializeField] float playerFollowSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the camera
        Vector3 followVector = F.vec3(followPoint.transform.position.x, transform.position.y, followPoint.transform.position.z - 5f);

        transform.position = Vector3.Lerp(transform.position, followVector.xyz(), camFollowSpeed * Time.deltaTime);

        // Move the follow point
        Vector3 playerVector = F.vec3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        followPoint.transform.position = Vector3.Lerp(followPoint.transform.position, playerVector.xyz(), playerFollowSpeed * Time.deltaTime);
    }
}
