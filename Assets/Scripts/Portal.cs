using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        //GameManager.instance.ShowText()
        if (coll.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    
}
