using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// because this is for interface it doesn't need monobehaviour

public interface IShootable  // standing for interface and shootable
{
    public void Shoot();

}

public interface IReloadable
{
    public void Reload();
}

public interface IChangable
{
    public void Changable();
}