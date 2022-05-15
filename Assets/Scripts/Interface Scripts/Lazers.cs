using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazers : MonoBehaviour, IShootable, IReloadable, IChangable // IShootable is relaying back to the attack interface script
{

    public void Shoot() // i must add what's inside that scripts area for no errors
    {
        Debug.Log("P P P piew piew");
    }

    public void Reload()
    {

    }

    public void Changable()
    {

    }
}