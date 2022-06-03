using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderScript1 : MonoBehaviour, MessageSender
{
    public Message content { get; set; }

    private void OnEnable()
    {
        MessageSystem.RegisterMessage(content);
    }

    private void OnDisable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
