using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBase : MonoBehaviour
{
    public Texture topTexture, bottomTexture, sideTexture;
    private Material topMaterial, bottomMaterial, sideMaterial;
    private Transform topObj, bottomObj;
    private Transform[] sideObjs = new Transform[4];

    // Start is called before the first frame update
    void Start()
    {
        topObj = transform.GetChild(4);
        bottomObj = transform.GetChild(5);
        sideObjs[0] = transform.GetChild(0);
        sideObjs[1] = transform.GetChild(1);
        sideObjs[2] = transform.GetChild(2);
        sideObjs[3] = transform.GetChild(3);

        topMaterial = new Material(Shader.Find("Standard"));
        topMaterial.mainTexture = topTexture;
        topMaterial.SetFloat("_Metallic", 0f);
        topMaterial.SetFloat("_Glossiness", 0f);
        topMaterial.SetFloat("_SpecularHighlights", 0f);
        topMaterial.SetFloat("_GlossyReflections", 0f);

        bottomMaterial = new Material(Shader.Find("Standard"));
        bottomMaterial.mainTexture = bottomTexture;
        bottomMaterial.SetFloat("_Metallic", 0f);
        bottomMaterial.SetFloat("_Glossiness", 0f);
        bottomMaterial.SetFloat("_SpecularHighlights", 0f);
        bottomMaterial.SetFloat("_GlossyReflections", 0f);

        sideMaterial = new Material(Shader.Find("Standard"));
        sideMaterial.mainTexture = sideTexture;
        sideMaterial.SetFloat("_Metallic", 0f);
        sideMaterial.SetFloat("_Glossiness", 0f);
        sideMaterial.SetFloat("_SpecularHighlights", 0f);
        sideMaterial.SetFloat("_GlossyReflections", 0f);

        topObj.GetComponent<MeshRenderer>().material = topMaterial;
        bottomObj.GetComponent<MeshRenderer>().material = bottomMaterial;
        foreach (Transform sideObj in sideObjs)
            sideObj.GetComponent<MeshRenderer>().material = sideMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
