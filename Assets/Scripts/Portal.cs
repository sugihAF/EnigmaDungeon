using UnityEngine;

public class Portal : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        //GameManager.instance.ShowText()
        if (coll.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene 1");
        }
    }
    
}
