using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
public delegate bool MessageHandler(Message args);

public class Message
{
    //protected MessageHandler handler;



}

public interface MessageSender
{
    Message content { get; set; }
}