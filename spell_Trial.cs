using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell_Trial : MonoBehaviour

{

   
    // Start is called before the first frame update
    private void Awake()
    {

        StartCoroutine(KYS());
    }

    // Update is called once per frame
    IEnumerator KYS()
    {
        yield return new WaitForSeconds(1);

        Object.Destroy(this.gameObject);
    }
}
