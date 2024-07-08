using UnityEngine;

public class PowerPellet: MonoBehaviour
{
    public bool stop = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            EatPowerPellet();
            FindObjectOfType<GameManager>().updateScore();
            //gameObject.SetActive(false);
        }
    }
    public void EatPowerPellet()
    {
        gameObject.SetActive(false);
        stop = true;
    }

}
