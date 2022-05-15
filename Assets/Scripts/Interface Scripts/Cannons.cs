using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannons : MonoBehaviour, IShootable, IReloadable, IChangable // IShootable is relaying back to the attack interface script
{

    public void Shoot() // i must add what's inside that scripts area for no errors
    {
        Debug.Log("Boom");
    }

    public void Reload()
    {

    }

    public void Changable()
    {

    }
}