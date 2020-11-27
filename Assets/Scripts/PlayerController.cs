using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Animator animator;
    public GameObject projectilePrefab;
    private GameObject projectileClone;
    private float mouseSpeed = 10;
    private AudioSource shoot;
    private AudioController mute;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        shoot = GetComponent<AudioSource>();
        mute = GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

       
        float hitdist = 0.0f;
        
        if (playerPlane.Raycast(ray, out hitdist))
        {
            
            Vector3 targetPoint = ray.GetPoint(hitdist);

            
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

            
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, mouseSpeed * Time.deltaTime);
        }





            if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);
            animator.SetTrigger("Move_Trig");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
            animator.SetTrigger("Move_Trig");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            animator.SetTrigger("Move_Trig");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            animator.SetTrigger("Move_Trig");
        }
        if (Input.GetMouseButtonDown(0))
        {
            
            projectileClone = Instantiate(projectilePrefab, transform.position, transform.rotation);
            Destroy(projectileClone, 3);
            
            
                shoot.Play();
            


        }
    }
   

}
    


