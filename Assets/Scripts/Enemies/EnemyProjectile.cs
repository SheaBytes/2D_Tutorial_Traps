using UnityEngine;

public class EnemyProjectile : EnemyDamage //Will damage the player every time they touch 
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;
    public void ActiveProjectile()
    {
        lifetime = 0;
        gameObject.SetActive(true);
    }

    private void Update()
    {
        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > resetTime)
            gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision); //Excute logic from parent script first 
        gameObject.SetActive(false); //when this hits any object deactivate arrow
    }
}
