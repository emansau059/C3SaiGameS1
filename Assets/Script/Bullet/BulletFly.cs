using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : ParentFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this._moveSpeed = 7;
    }
}
