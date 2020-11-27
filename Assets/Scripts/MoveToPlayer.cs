using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    private Transform target;
    private float speed = 3;
    public bool isDead2 = false;
    public bool spawnProtection;
    [SerializeField] private float timeDelay = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        spawnProtection = true;
       

        
    }

    // Update is called once per frame
    void Update()
    {

        timeDelay -= Time.deltaTime;
        if (timeDelay <= 0)
        {
            spawnProtection = false;
        }
        if (isDead2 == true)
        {
            speed = 0;
        }
        if (isDead2 == false)
        {
            transform.LookAt(target);
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
