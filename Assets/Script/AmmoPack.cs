using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour, IItem
{
    public int ammo = 30; // 장전할 총알 수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Use(GameObject target)
    {
        Shot shot = target.GetComponent<Shot>();

        if(shot != null && shot.gun != null)
        {
            shot.gun.ammoRemain += ammo;
        }

        Destroy(gameObject);
    }
}
 //test
 