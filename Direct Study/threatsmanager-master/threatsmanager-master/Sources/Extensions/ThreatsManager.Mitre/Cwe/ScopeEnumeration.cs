// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.2.97.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ThreatsManager.Mitre.Cwe
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// The ScopeEnumeration simple type defines the different areas of security that can be affected by exploiting a weakness.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[XmlTypeAttribute(Namespace="http://cwe.mitre.org/cwe-6")]
public enum ScopeEnumeration
{
    Confidentiality,
    Integrity,
    Availability,
    [XmlEnumAttribute("Access Control")]
    AccessControl,
    Accountability,
    Authentication,
    Authorization,
    [XmlEnumAttribute("Non-Repudiation")]
    NonRepudiation,
    Other,
}
}
#pragma warning restore
