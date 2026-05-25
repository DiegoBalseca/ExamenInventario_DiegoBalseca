public class Interactableitem : MonoBehaviour
{
    public ScriptableItem item;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider collision)
    {
        Inventorymanager.Instance.AddItem(item);
        Destroy(gameObject);
    }

   
}
