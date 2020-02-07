using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align {

    //SteeringOutput target;
    Vector3 direction;

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        direction = target.transform.eulerAngles - character.transform.eulerAngles;

        if (direction.magnitude == 0)
        {
            return result;
        }
        //target = explicitTarget; //I don't know what this line does
        result.angular = Mathf.Atan2(-direction.x, direction.z) * Mathf.Rad2Deg;
        return result;
    }
}
