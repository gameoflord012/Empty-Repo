using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AgentMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
    }
}
