/**** 
 * Created by: Bobby Ouyang
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Bobby Ouyang 
 * Last Edited: April 6, 2022
 * 
 * Description: Projectile Behaviors
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /***VARIABLES***/
    private BoundsCheck bndCheck; //reference to bounds check

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            gameObject.SetActive(false);
            bndCheck.offUp = false; //reset the boundary settings
        }
    }
}
