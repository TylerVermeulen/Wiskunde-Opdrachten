using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = new Vector3[]{
            new Vector3(3, -1,0 ),
            new Vector3(0, -1, 0),
            new Vector3(0, 1, 0),
            new Vector3(3, 1, 0),
            new Vector3(3, 2, 0),
            new Vector3(3, -2, 0),
            new Vector3(5, 0, 0)

        };
        mesh.triangles = new int[]
        {
            0,1,2,
            3,2,0,
            4,5,6
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
