using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float horizontalClamp = 8f;
    [SerializeField] private float fireRate = 0.1f;
    
    private float nextFireTime;
    private Vector3 moveDirection = Vector3.zero;

    private void OnValidate()
    {
        if (bulletPrefab == null) Debug.LogWarning("Bullet prefab not assigned!");
    }

    private void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    private void HandleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal");
        moveDirection = Vector3.right * moveInput;
        
        Vector3 newPos = transform.position + moveDirection * moveSpeed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, -horizontalClamp, horizontalClamp);
        transform.position = newPos;
    }

    private void HandleShooting()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Fire();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void Fire()
    {
        if (bulletPrefab == null)
        {
            Debug.LogError("Bullet prefab is not assigned!");
            return;
        }

        Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
    }
}