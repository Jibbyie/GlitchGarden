using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    // Member Variables
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        DefenderSpawn();
    }

    private void DefenderSpawn()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity) as GameObject;
    }
}
