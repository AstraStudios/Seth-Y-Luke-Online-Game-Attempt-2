using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GLSLVectors;

public class MouseLook : MonoBehaviour
{
    void Update()
    {
        // shoot a ray from the mouse twords the plane that the player can move along
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("MousePositionCheck"))) print("Mouse input could not find hit plane. make sure you have one tagged MousePosiotionCheck");

        // face the impact point
        Vector3 direction = hit.point.xz() - transform.position.xz();
        float facingAngle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, -facingAngle + 90, 0);
    }

}
