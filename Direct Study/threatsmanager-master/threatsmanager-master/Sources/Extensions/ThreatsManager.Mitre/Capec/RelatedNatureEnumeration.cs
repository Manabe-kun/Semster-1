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
/// The RelatedNatureEnumeration simple type defines the different values that can be used to define the nature of a related attack pattern. A ChildOf nature denotes a related attack pattern as a higher level of abstraction. A ParentOf nature denotes a related attack pattern as a lower level of abstraction. The CanPrecede and CanFollow relationships are used to denote attack patterns that are part of a chaining structure. The CanAlsoBe relationship denotes a attack pattern that, in the proper environment and context, can also be perceived as the target attack pattern. Note that the CanAlsoBe relationship is not necessarily reciprocal. The PeerOf relationship is used to show some similarity with the target attack pattern which does not fit any of the other types of relationships.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[XmlTypeAttribute(Namespace="http://capec.mitre.org/capec-3")]
public enum RelatedNatureEnumeration
{
    ChildOf,
    ParentOf,
    CanFollow,
    CanPrecede,
    CanAlsoBe,
    PeerOf,
}
}
#pragma warning restore
