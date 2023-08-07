using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [Header("Gun Aspects")]
    // Add all invidual aspects in editor
    public float damage;
    public float range;
    public float fireRate;
    public float impactForce;

    private float nextTimeToFire = 0f;

    [Header("Fire Points and Particle Effects")]
    [SerializeField] Transform firePoint;
    // Particle effects later

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            if (hit.rigidbody != null)
                hit.rigidbody.AddForce(-hit.normal * impactForce);
        }
    }
}
