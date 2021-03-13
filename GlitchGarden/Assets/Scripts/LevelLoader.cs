using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    
    void Start()
    {
        StartCoroutine("StartScreenLoader");
    }
    IEnumerator StartScreenLoader()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene("StartScreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
