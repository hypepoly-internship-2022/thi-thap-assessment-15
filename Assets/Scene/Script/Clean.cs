using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clean : MonoBehaviour
{
    [SerializeField] private GameObject done;

    private Rigidbody body;
    private int Rock;

    private void Start()
    {
        Rock = 10;
    }

    private void Update()
    {
        if(Rock == 0) 
        {
            done.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
