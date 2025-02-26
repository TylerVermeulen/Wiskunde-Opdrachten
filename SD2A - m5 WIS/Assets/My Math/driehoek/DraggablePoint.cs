using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggablePoint : MonoBehaviour
{
    private bool isdragged;
    [SerializeField]public Color nwcolor;
    SpriteRenderer spriterenderer;
    
    private void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
       nwcolor = spriterenderer.color;
    }
    private void Update()
    {
        spriterenderer.color = nwcolor;
    }
    private void OnMouseDown()
    {
        
        if (isdragged == true)
        {
            isdragged = false;
        }
        else if (isdragged == false)
        {
            isdragged = true;
        }
    }
    private void OnMouseUp() 
    {
        isdragged = false;
    }
    private void OnMouseDrag()
    {
        if (isdragged == true)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
