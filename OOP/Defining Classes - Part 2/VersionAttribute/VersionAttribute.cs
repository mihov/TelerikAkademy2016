﻿namespace VersionAttribute
{
    using System;


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(Type component, string name, string version)
        {
            this.Component = component;
            this.Name = name;
            this.Version = version;
        }

        public enum Type
        {
            Class, Struct, Iterface, Enum, Method
        }


        public Type Component { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }




    }
}
