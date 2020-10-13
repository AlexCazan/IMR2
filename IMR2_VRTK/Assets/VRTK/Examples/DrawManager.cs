using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrawManager : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public GameObject drawingPrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject drawing = Instantiate(drawingPrefab);
            drawing.GetComponent<Renderer>().enabled = false;
            lineRenderer = drawing.GetComponent<LineRenderer>();
        }

        if (Input.GetMouseButton(1))
        {
            FreeDraw();
        }
    }

    void FreeDraw()
    {
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount-1, drawingPrefab.transform.position);
    }
}
