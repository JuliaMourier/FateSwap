using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public Character Henrik;
    private Rigidbody2D m_rigidbody;

    private void Awake() {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.Equals(Henrik.gameObject) || (other.gameObject.GetComponent<Box>() != null)){ //if only one character can switch the switch, check if the collision is dur to this character
            if(Henrik.isPowerActivate){ //if Henrik is capable of switch the switch
                m_rigidbody.mass = 1;
            }
        }        
    }

    private void OnCollisionExit2D(Collision2D other) {
        StopAllCoroutines();
        StartCoroutine(SetMassAfter20ms());
    }

    private IEnumerator SetMassAfter20ms(){ 

        float duration = 0.2f; //Duration of the disability
        float elapsed = 0.0f;

        // wait
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            yield return null; //do nothing while waiting
        }

        m_rigidbody.mass = 99; //The switch is back to available

    }
}
