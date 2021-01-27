using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private bool attacking;
    private float attackingTimer;
    private float attackingCountdown;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("attacking", false);

        attacking = false;
        attackingTimer = 1;
        attackingCountdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("attacking");
            //if (attacking == false) {
            //    anim.SetBool("attacking", true);
            //    attacking = true;
            //    attackingCountdown = attackingTimer;
            //}
            
        }
        //if (attackingCountdown > 0) {
        //    attackingCountdown -= Time.deltaTime;
        //} else
        //{
        //    if (attacking == true)
        //    {
        //        attacking = false;
        //        anim.SetBool("attacking", false);
        //    }
        //}
        
        
    }
}
