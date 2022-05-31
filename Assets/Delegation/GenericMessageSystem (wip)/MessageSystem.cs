using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public static class MessageSystem
{
    private static Dictionary<Message, MessageHandler> MessageBus =
        new Dictionary<Message, MessageHandler>();

    public static void Raise(Message message)
    {
        if (message is not null)
        {
            if (MessageBus.TryGetValue(message, out MessageHandler handler))
                handler.Invoke(message);
        }
    }

    public static void RegisterMessage(Message message)
    {
        if (message is not null)
        {
            if (!MessageBus.ContainsKey(message))
            {
                MessageHandler handler = null;
                MessageBus.Add(message, handler);
            }
        }
    }

    /*public static void RegisterHandler(MessageHandler handler)
    {
        if (handler is not null)
        {

            MessageBus?.ContainsKey(handler.Method.GetType().Name);
            if (MessageBus.TryGetValue(message, out List<MessageHandler> handlers))
                handlers.Add(handler);
        }
        else
        {
            List<MessageHandler> handlers = new List<MessageHandler>();
            handlers.Add(handler);
            MessageBus.Add(message, handlers);

        }
    }

    public static void UnregisterHan(Message message)
    {
        if (message is not null)
        {
            MessageBus?.ContainsKey(message);
            if (MessageBus.TryGetValue(message, MessageHandler handlers))
                handlers.Remove(handler);
        }
    }*/
}
