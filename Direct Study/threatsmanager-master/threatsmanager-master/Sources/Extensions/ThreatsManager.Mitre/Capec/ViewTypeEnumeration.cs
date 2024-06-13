// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.2.97.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ThreatsManager.Mitre.Capec
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
/// The ViewTypeEnumeration simple type defines the different types of views that can be found within CAPEC. A graph is a hierarchical representation of attack patterns based on a specific vantage point that a user my take. The hierarchy often starts with a category, followed by a meta/standard attack pattern, and ends with a detailed attack pattern. An explicit slice is a subset of attack patterns that are related through some external factor. For example, a view may be used to represent mappings to external groupings like a Top-N list. An implicit slice is a subset of attack patterns that are related through a specific attribute. For example, a slice may refer to all attack patterns in draft status, or all existing meta attack patterns.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[XmlTypeAttribute(Namespace="http://capec.mitre.org/capec-3")]
public enum ViewTypeEnumeration
{
    Implicit,
    Explicit,
    Graph,
}
}
#pragma warning restore
