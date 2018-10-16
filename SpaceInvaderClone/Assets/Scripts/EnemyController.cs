
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public GameObject shot;
    public Text winText;
    public float fireRate = 0.997f;
    private Transform enemyHolder;
    
	void Start ()
	{
	    this.winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
	    this.enemyHolder = GetComponent<Transform>();
	}



     void MoveEnemy()
     {
         this.enemyHolder.position += Vector3.right * this.speed;
         foreach (Transform enemy in enemyHolder)
         {
             if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
             {
                 this.speed = -this.speed;
                 this.enemyHolder.position += Vector3.down * 0.5f;
                 return;
             }

             if (Random.value > fireRate)
             {
                 Instantiate(this.shot, enemy.position, enemy.rotation);
                 
            }

             if (enemy.position.y <= -4)
             {
                 GameOver.isPlayerDead = true;
                 Time.timeScale = 0;
             }
         }

         if (this.enemyHolder.childCount == 1)
         {
             CancelInvoke();
             InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
         }

         if (this.enemyHolder.childCount == 0)
         {   
             this.winText.enabled = true;
         }
     }
}
