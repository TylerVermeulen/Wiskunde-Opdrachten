using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LININGAWAY : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public LineRenderer ab;
    public LineRenderer bc;
    public LineRenderer ac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       ab.SetPosition(0, a.transform.position);
       ab.SetPosition(1, b.transform.position);

        bc.SetPosition(0, b.transform.position);
        bc.SetPosition(1, c.transform.position);

        ac.SetPosition(0, a.transform.position);
        ac.SetPosition(1, c.transform.position);
    }
}
