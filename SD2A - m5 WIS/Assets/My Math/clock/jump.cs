using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class jump : MonoBehaviour
{
    float t;
    float timer;
    float t0 = 0f;
    [SerializeField] TextMeshProUGUI myText;
    [SerializeField] GameObject rutger;
    Vector3 velocity;
    Vector3 acceleration;
    [SerializeField]private Animator animator;
    float y0;
    enum State {
        wait,active,finished
        };
    State myState = State.wait;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = t0.ToString();
        y0 = rutger.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
     if (myState == State.wait)
        {
            if(Input.GetMouseButtonDown(0))
            {
                velocity = new Vector3(0, 5, 0);
                acceleration = new Vector3(0, -2, 0);
                myState = State.active;
            }
        }
     if(myState == State.active)
        {
            animator.ResetTrigger("IsIdle");
            animator.SetTrigger("IsJumping");
            velocity += acceleration * Time.deltaTime;
            rutger.transform.position += velocity * Time.deltaTime;
            t += Time.deltaTime;
            timer = t;

            myText.text = timer.ToString("F2");
            //if (Input.GetMouseButtonDown(1))
            //{
            //    myState = State.finished;
            //}
            if (rutger.transform.position.y < y0)
            {
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                myState = State.finished;
                rutger.transform.position = new Vector3(rutger.transform.position.x, y0, -1);
            }
        }
     if (myState == State.finished)
        {
            animator.ResetTrigger("IsJumping");
            animator.SetTrigger("IsIdle");
            t = t0;
            myState = State.wait;
        }
    }
}
