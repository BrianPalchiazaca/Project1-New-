using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private UnityEngine.AI.NavMeshAgent agent;
    public Transform Player;
    public float Speed;
    public int EnHealth;

    void Start()
    {
        GetRefrence();
        EnHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
        agent.SetDestination(Player.position);
        LookAtPlayer();

        if (EnHealth == 0)
        {
            Dead();
        }
    }

    private void LookAtPlayer()
    {
        transform.LookAt(Player);
        Vector3 direction = Player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    }

    private void GetRefrence()
    {
        Player = NewPlayerMovement.Clone;
    }

    public void Dead()
    {
        Destroy(gameObject);
        Debug.Log("Die");
    }

    public void Damaged()
    {
        EnHealth = EnHealth - 1;
    }
}
