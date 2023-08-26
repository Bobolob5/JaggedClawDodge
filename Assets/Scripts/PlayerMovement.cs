using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 startPosition;
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 7f;



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
            startPosition = rb.position;
        }
    }
    private void FixedUpdate()
    {
        rb.position = (Vector2)(transform.position + (mousePosition - startPosition).normalized * moveSpeed * Time.fixedDeltaTime);
    }

}
