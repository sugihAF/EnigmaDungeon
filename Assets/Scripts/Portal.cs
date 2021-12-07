using UnityEngine;

public class Portal : Collidable
{
    public string sceneName;
    protected override void OnCollide(Collider2D coll)
    {
        //GameManager.instance.ShowText()
        if (coll.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
    
}
