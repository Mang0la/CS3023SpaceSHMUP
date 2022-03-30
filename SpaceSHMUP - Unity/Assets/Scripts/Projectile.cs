/**** 
 * Created by: Thomas Nguyen
 * Date Created: March 30, 2022
 * 
 * Last Edited by: Thomas Nguyen
 * Last Edited: March 30, 2022
 * 
 * Description: Projectile behaviors
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /***VARIABLES***/
    private BoundsCheck bndCheck; //reference to the bounds check

    private void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    } //end Awake()


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bndCheck.offUp)
        {
            Destroy(gameObject);
        }
    } //end Update()
}
