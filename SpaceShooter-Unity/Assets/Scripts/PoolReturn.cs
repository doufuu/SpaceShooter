/**** 
 * Created by: Bobby Ouyang
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Bobby Ouyang 
 * Last Edited: April 6, 2022
 * 
 * Description: return objects back to the pool
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; //reference to pool

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        if (pool != null) 
        {
            pool.ReturnObjects(this.gameObject); //return this object to the pool
        }
    }



}
