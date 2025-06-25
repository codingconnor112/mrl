using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(new Vector2(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed)+rb.position);
    }
}
