using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollider : MonoBehaviour
{
    //If a character jump on the head of a robot, the robot must die
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == LayerMask.NameToLayer("Characters")){
            FindObjectOfType<Robot>().RobotDie();            
        }
    }
}
