using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEditor;
using UnityEngine;

public class Direction_point : MonoBehaviour
{
    bool fireState=false;
    public Transform firePoint;
    public GameObject bullet;

    public float bulletZoom = 5f;

    Vector2 directionOFBullet;
    float lookAngle;

    private Rigidbody2D rb;

    private void Start()
    {
       
    }

    


    // Update is called once per frame
    void Update()
    {

        directionOFBullet = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        directionOFBullet = new Vector2(directionOFBullet.x - transform.position.x, directionOFBullet.y - transform.position.y);
        lookAngle = Mathf.Atan2(directionOFBullet.y, directionOFBullet.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

    }

    private void FixedUpdate()
    {
        
        
         if (Input.GetKey(KeyCode.Space) && fireState==false)
         {
            fireState = true;
            GameObject cloneShot = Instantiate(bullet);
            cloneShot.transform.position = firePoint.position;
            cloneShot.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
            cloneShot.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletZoom;
          


         }
         else if (Input.GetKey(KeyCode.Space) && fireState == true)
        {



        }

         else
        {
            fireState= false;
        }
        


    }
    

}


    