using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public enum Team
{
    playerTeam,
    enemyTeam
}

public enum UnitState
{
    idle,
    walk,
    attack
}

public class Unit : MonoBehaviour
{
    public Team team;

    public Transform healthBar;
    private HealthBar healthBarScript;

    public DamagePopUp damagePopUpPrefab;
    private DamagePopUp damagePopUp;


    public float maxHealth;
    public float currentHealth;
    public float attackDamage;
    public float attackInterval;
    public float attackRange;
    public float speed;

    public Unit target;
    float nextAttackTime = 0f;
    
    UnitState state;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        healthBarScript = healthBar.GetComponent<HealthBar>();
        currentHealth = maxHealth;
        state = UnitState.idle;
    }

    void Update()
    {
        if(BattleManager.instance.isBattleEnded == true) return;

        Targetting();

        if (Vector3.Distance(transform.position, target.transform.position) > attackRange) {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            if (transform.position.x > target.transform.position.x) GetComponent<SpriteRenderer>().flipX = true;
            else GetComponent<SpriteRenderer>().flipX = false;

            if (state != UnitState.walk) ChangeToWalkState();
        }
        else{
            state = UnitState.attack;
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        if (Time.time > nextAttackTime) {
            animator.Play("Attack");
            nextAttackTime = Time.time + attackInterval;

            yield return new WaitForSeconds(0.25f);
            target.TakeDamage(attackDamage);
        }
    }

    void Targetting()
    {
        float distance = float.MaxValue;

        if (team == Team.playerTeam) 
        {
            foreach (Unit x in BattleManager.instance.enemyTeam)
            {
                if (distance > Vector3.Distance(transform.position, x.transform.position)) target = x;
            }
        }
        else if (team == Team.enemyTeam)
        {
            foreach (Unit x in BattleManager.instance.playerTeam)
            {
                if (distance > Vector3.Distance(transform.position, x.transform.position)) target = x;
            }
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBarScript.UpdateHealthBar(maxHealth, currentHealth);
        Instantiate(damagePopUpPrefab, transform.position, Quaternion.identity).SetDamageAmount(damage.ToString());
        if (currentHealth <= 0) Die();
    }

    public void Die()
    {
        BattleManager.instance.DestroyUnit(this);
        Destroy(gameObject);
    }

    void ChangeToWalkState()
    {
        state = UnitState.walk;
        animator.Play("Walk");
    }
}
