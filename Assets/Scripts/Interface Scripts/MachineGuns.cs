using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGuns : MonoBehaviour, IShootable, IReloadable // IShootable is relaying back to the attack interface script
{

    public void Shoot() // i must add what's inside that scripts area for no errors
    {
        Debug.Log("Piew piew");
    }

    public void Reload()
    {
       
    }

  
}                                            

