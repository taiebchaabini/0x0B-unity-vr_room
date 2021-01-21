using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairUI : MonoBehaviour
{   
    // Laser default Length
    public float laserLength = 3.0f;
    // Crosshair Gameobject
    public GameObject crosshair;
    private int ignoreLayer = 2;
    private Vector3 endPoint;
    

    private LineRenderer lineRenderer = null;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();   
    }

    private void Update()
    {
        UpdateLength();
        UpdatePosition();
    }

    private void UpdateLength()
    {
        endPoint = GetEnd();

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPoint);
    }

    private void UpdatePosition()
    {
        crosshair.transform.position = endPoint;
    }

    private Vector3 GetEnd()
    {
        RaycastHit hit = RayCast();
        Vector3 endPos = DefaultEnd(laserLength);

        if (hit.collider)
        {
            Debug.Log(hit.collider.name);
            endPos = hit.point;
        }

        return endPos;
    }

    private RaycastHit RayCast()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        Physics.Raycast(ray, out hit, laserLength, ignoreLayer);

        return hit;
    }

    private Vector3 DefaultEnd(float length)
    {
        return transform.position + (transform.forward * length);
    }

}
