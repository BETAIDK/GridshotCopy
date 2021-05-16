using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject shootPoint, bullet;
    public float shootSpeed = 10;
    public Rigidbody bulletrb;
    public Camera cam;
    public Transform target;
    
    private int x, y;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        //GameObject the_bullet = Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation);
        //bulletrb.AddForce(new Vector3(shootSpeed * 23f, 0, 0), ForceMode.Impulse);
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.transform.position, shootPoint.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform.name == "Target(Clone)")
            {
                Destroy(hit.transform.gameObject);
                SpawnRandom();
            }
        }
    }
    
    void SpawnRandom()
    {
        x = Random.Range(-1, 3);
        y = Random.Range(1, 3);
        Instantiate(target, new Vector3(x, y, 2), target.rotation);
    }
}
