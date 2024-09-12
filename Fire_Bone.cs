using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fire_Bone : MonoBehaviour
{
    public int hurtvalue = 1;
    public int collisionCount = 0;

    public GameObject targetEnemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collisionCount++;

            GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in allEnemies)
            {
                if (enemy.GetComponent<isHit>().getHurt() == true)
                {
                    enemy.GetComponent<Health>().Damage(hurtvalue);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
}
  