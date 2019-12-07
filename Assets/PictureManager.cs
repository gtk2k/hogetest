using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureManager : MonoBehaviour
{
    public GameObject PictureParts;
    public Text txt;
    public Camera cam;
    private CameraInOut[] parts;

    private void Awake()
    {

    }

    void Start()
    {
        var ps = new List<CameraInOut>();
        for (var x = 0f; x < 30f; x += 1f)
        {
            for (var y = 0f; y < 21f; y += 1f)
            {
                var go = Instantiate(PictureParts);
                go.transform.localPosition = new Vector3(1.5f / 30f * x, 1.07235f / 21f * y, 0);
                go.transform.localScale = new Vector3(1.5f / 30f, 1.07235f / 21f);
                ps.Add(go.GetComponent<CameraInOut>());
                if ((ps.Count % 2) == 0)
                    go.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
        }
        parts = ps.ToArray();
    }

    void Update()
    {
        var lp = cam.transform.localPosition;
        if (Input.GetKey(KeyCode.UpArrow))
            lp.z += 0.01f;
        else if (Input.GetKey(KeyCode.DownArrow))
            lp.z -= 0.01f;
        cam.transform.localPosition = lp;

        var cnt = 0;
        foreach (var p in parts)
            if (p.Visible)
                cnt++;
        txt.text = $"{cnt}";
    }

}
