using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{
    [SerializeField] private BoxCollider2D Attackcolider;
    private SpriteRenderer PlayerSprite;
    public Animator animator;
    private void Awake()
    {
        PlayerSprite = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           
            animator.Play("Attack");
            Invoke(nameof(turnoncolider), 0.9f);
        }
        if (PlayerSprite.flipX)
        {
            Attackcolider.transform.localScale = new Vector3(-1, 1, 1);

        }
        else
        {
            Attackcolider.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    private void turnoncolider()
    {
        Attackcolider.gameObject.SetActive(true);
        Invoke(nameof(turnoffcolider), 0.1f);

    }
    private void turnoffcolider()
    {
        Attackcolider.gameObject.SetActive(false);
    }
}