using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pellet : MonoBehaviour
{
    public int points = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if((1 << collision.gameObject.layer & LayerMask.GetMask("Pacman")) != 0)
        {
            Eat();
        }
    }

    public virtual void Eat()
    {
        GameManager.Instance.PelletEaten(this);
    }
}
