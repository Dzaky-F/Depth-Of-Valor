// using System.Collections;
// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;

// public class Movement : MonoBehaviour
// {
//     public Transform target;

//     float attackRange;
//     float speed;
//     float attackDamage;
//     float attackInterval;

//     float nextAttackTime = 0f;
//     bool attackMode = false;

//     void Awake()
//     {
//         attackRange = GetComponent<Stats>().attackRange;
//         speed = GetComponent<Stats>().speed;
//         attackInterval = GetComponent<Stats>().attackInterval;
//         attackDamage = GetComponent<Stats>().attackDamage;
//     }

//     void Update()
//     {
//         if (Vector3.Distance(transform.position, target.position) > attackRange) {
//             transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
//         }
//         else{
//             Attack();
//         }
//     }

//     void Attack()
//     {
//         if (Time.time > nextAttackTime) {
//             target.GetComponent<Stats>().currentHealth -= attackDamage;
            
//             nextAttackTime = Time.time + attackInterval;
//         }
//     }
// }
