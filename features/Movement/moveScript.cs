using UnityEngine;
using System.Collections;
using System.Threading;
using System.Security.Cryptography;

public class targetmove : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 target;
    public Vector2 Direction;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;

            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

}

            

       

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.up = Direction;
    }
}