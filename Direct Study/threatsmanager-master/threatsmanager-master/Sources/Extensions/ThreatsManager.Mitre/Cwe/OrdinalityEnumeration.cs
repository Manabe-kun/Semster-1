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
/// The OrdinalityEnumeration simple type contains a list of values used to indicates potential ordering relationships with other weaknesses. A primary relationship means the weakness exists independent of other weaknesses, while a resultant relationship is when a weakness exists only in the presence of some other weaknesses. An indirect relationship means the weakness does not directly lead to security-relevant weaknesses but is a quality issue that might indirectly make it easier to introduce security-relevant weaknesses or make them more difficult to detect.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[XmlTypeAttribute(Namespace="http://cwe.mitre.org/cwe-6")]
public enum OrdinalityEnumeration
{
    Indirect,
    Primary,
    Resultant,
}
}
#pragma warning restore
