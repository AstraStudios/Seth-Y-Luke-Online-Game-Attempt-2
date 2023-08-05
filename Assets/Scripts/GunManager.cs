using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    [Header("Firing")]
    [SerializeField] GameObject firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FacePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    void FacePosition(Vector3 position)
    {
        Vector3 direction = position - transform.position;
        float facingAngle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, facingAngle + 180);
    }
}
