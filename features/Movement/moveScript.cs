using UnityEngine;
using System.Collections;
using System.Threading;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Reflection;

public class targetmove : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 target;
    public Animator anim;
    private bool Walking;
    public bool canWalk = true;





    // Update is called once per frame
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //Get mouse position
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
                Vector3 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            }
            //Figue out where to walk
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            Vector3 direction = (target - transform.position).normalized;

            //Animate walk
            if (transform.position == target)
            {
                Walking = false;
                anim.SetBool("right", false);
                anim.SetBool("left", false);
                anim.SetBool("up", false);
                anim.SetBool("down", false);
            }
            else
            {
                Walking = true;
            }
            if (Walking == true)
            {
                if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                {
                    if (direction.x > 0)
                    {
                        //Right Animation
                        anim.SetBool("right", true);
                        anim.SetBool("left", false);
                        anim.SetBool("up", false);
                        anim.SetBool("down", false);
                    }
                    else
                    {
                        //Left Animation
                        anim.SetBool("right", false);
                        anim.SetBool("left", true);
                        anim.SetBool("up", false);
                        anim.SetBool("down", false);
                    }
                }
                else
                {
                    if (direction.y > 0)
                    {
                        //Up Animation
                        anim.SetBool("right", false);
                        anim.SetBool("left", false);
                        anim.SetBool("up", true);
                        anim.SetBool("down", false);
                    }
                    else
                    {
                        //Down Animation
                        anim.SetBool("right", false);
                        anim.SetBool("left", false);
                        anim.SetBool("up", false);
                        anim.SetBool("down", true);
                    }
                }
            }

        }
}
