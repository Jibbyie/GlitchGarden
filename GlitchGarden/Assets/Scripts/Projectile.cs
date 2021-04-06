using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;
    [SerializeField] float rotationSpeed = 5f;
 
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
        transform.Rotate(Vector2.right * rotationSpeed * Time.deltaTime);
    }
}
