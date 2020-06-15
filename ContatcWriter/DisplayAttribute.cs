﻿using System;

namespace ContatcWriter
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DisplayAttribute : Attribute
    {
        public DisplayAttribute(string label, ConsoleColor color = ConsoleColor.White)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }

        public string Label { get; }
        public ConsoleColor Color { get; }
    }
}
