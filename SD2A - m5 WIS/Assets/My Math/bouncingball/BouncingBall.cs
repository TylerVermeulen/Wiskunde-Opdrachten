using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    private Vector3 velocity;
    private Vector3 acceleration;
    private Vector3 direction = new Vector3(1,1,0);
    private float speed = 3;
    Vector2 min, max;
    // Start is called before the first frame update
    void Start()
    {
        min = Camera.main.ScreenToWorldPoint(Vector2.zero);
        max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        acceleration = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        direction = direction.normalized;
        velocity += acceleration;
        velocity = speed * direction;

        this.transform.position += velocity * Time.deltaTime;

        if(this.transform.position.y > max.y)
        {
            direction = new Vector3(direction.x, -direction.y, 0);
        }

        if (this.transform.position.x > max.x)
        {
            direction = new Vector3(-direction.x, direction.y, 0);
        }

        if (this.transform.position.y < min.y)
        {
            direction = new Vector3(direction.x, -direction.y, 0);
        }

        if (this.transform.position.x < min.x)
        {
            direction = new Vector3(-direction.x, direction.y, 0);
        }
    }
}
