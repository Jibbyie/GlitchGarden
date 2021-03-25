using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)]
    [SerializeField] float walkSpeed = 1f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
}
