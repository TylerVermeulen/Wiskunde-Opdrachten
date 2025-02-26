using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linearfunction
{
    public float slope;
    public float intercept;
    public linearfunction(float slope, float intercept) 
    { 
        this.slope = slope;
        this.intercept = intercept;
    }

    public float getY(float x)
    {
        return slope * x + intercept;
    }

}
