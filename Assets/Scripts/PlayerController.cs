using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 120f;
    
    [Header("Color Settings")]
    [SerializeField] private Color[] colors; // Массив цветов для смены
    private Material objectMaterial;
    private int currentColorIndex = 0;
    
    void Start()
    {
        // Получаем материал объекта
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            objectMaterial = renderer.material;
        }
        
        // Если цвета не заданы в инспекторе, создаем массив по умолчанию
        if (colors == null || colors.Length == 0)
        {
            colors = new Color[] { Color.white, Color.red, Color.green, Color.blue, Color.yellow };
        }
    }
    
    void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleColorChange();
    }
    
    void HandleMovement()
    {
        // Движение вперед/назад по W/S
        float moveInput = 0f;
        
        if (Input.GetKey(KeyCode.W)) moveInput = 1f;
        if (Input.GetKey(KeyCode.S)) moveInput = -1f;
        
        Vector3 moveDirection = transform.forward * moveInput * moveSpeed * Time.deltaTime;
        transform.position += moveDirection;
    }
    
    void HandleRotation()
    {
        // Вращение влево/вправо по A/D
        float rotationInput = 0f;
        
        if (Input.GetKey(KeyCode.A)) rotationInput = -1f;
        if (Input.GetKey(KeyCode.D)) rotationInput = 1f;
        
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);
    }
    
    void HandleColorChange()
    {
        // Смена цвета по нажатию C
        if (Input.GetKeyDown(KeyCode.C) && objectMaterial != null && colors.Length > 0)
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            objectMaterial.color = colors[currentColorIndex];
        }
    }
}