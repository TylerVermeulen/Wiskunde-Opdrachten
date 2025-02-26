using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myline : MonoBehaviour
{
    linearfunction f = new linearfunction(0.5f,0);
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] DraggablePoint a;
    void Start()
    {
        lineRenderer.SetPosition(0, new Vector3(-3, f.getY(-3)));
        lineRenderer.SetPosition(1, new Vector3(3, f.getY(3)));
    }
    private void Update()
    {
        if (a.transform.position.y < a.transform.position.x * f.slope + f.intercept)
        {
            a.nwcolor = Color.green;
        }
        else
        {
            a.nwcolor = Color.red;
        }
    }
}
