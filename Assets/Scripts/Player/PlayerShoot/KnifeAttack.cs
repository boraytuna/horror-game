// using UnityEngine;

// public class KnifeAttack : MonoBehaviour
// {
//     Animator anim;

//     // Start is called before the first frame update
//     void Start()
//     {
//         anim = GetComponentInParent<Animator>();    
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         // Check if the inventory UI is not active before processing attack
//         if (!InventoryUI.isUIActive)
//         {
//             if(Input.GetButtonDown("Fire1"))
//                 anim.SetBool("attacking", true);
//             if(Input.GetButtonUp("Fire1"))
//                 anim.SetBool("attacking", false);
//         }
//     }
// }
using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
    Animator anim;
    public bool isAttacking = false;  // Public to be accessed by ZombieGetDamage

    void Start()
    {
        anim = GetComponentInParent<Animator>();    
    }

    void Update()
    {
        if (!InventoryUI.isUIActive)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                anim.SetBool("attacking", true);
                isAttacking = true;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                anim.SetBool("attacking", false);
                isAttacking = false;
            }
        }
    }
}
