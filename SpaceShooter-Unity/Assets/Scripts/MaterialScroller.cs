/**** 
 * Created by: Bobby Ouyang
 * Date Created: April 11, 2022
 * 
 * Last Edited by: Bobby Ouyang 
 * Last Edited: April 11, 2022
 * 
 * Description: Scroll material
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroller : MonoBehaviour
{
    private Material goMat; //the game object's material
    private Renderer goRenderer; //reference to object's mesh renderer

    public Vector2 scrollSpeed = new Vector2(0, 0);
    private Vector2 offset; //the offset of scroll  

    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMat = goRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime); //set offset value over time
        goMat.mainTextureOffset += offset; //set texture offeset
    }
}
