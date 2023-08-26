using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 2;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.transform.position = transform.position + new Vector3(0f, -1f * speed * Time.fixedDeltaTime, 0f);
    }

}
