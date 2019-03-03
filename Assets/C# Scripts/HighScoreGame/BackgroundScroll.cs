using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    MeshRenderer MeshRend;
    float ScrollSpeed = 0.05f;

    public int xVelocity, yVelocity;

    private void Awake()
    {
        MeshRend = GetComponent<MeshRenderer>();
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = ScrollSpeed * Time.time;
        Vector2 offset = new Vector2(x, 0);
        MeshRend.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
