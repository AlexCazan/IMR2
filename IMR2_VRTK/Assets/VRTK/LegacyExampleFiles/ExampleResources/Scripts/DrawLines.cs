using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DrawLines : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public GameObject creta;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject drawing = Instantiate(creta);
            lineRenderer = drawing.GetComponent<LineRenderer>();
            drawing.GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetMouseButton(1))
        {
            Draw();
        }
    }

    void Draw()
    {
        lineRenderer.startWidth = 0.2f;
        lineRenderer.endWidth = 0.2f;
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount-1, creta.transform.position);
    }
}
