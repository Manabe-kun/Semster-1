// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.44
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Xml.Serialization;

#pragma warning disable
namespace ThreatsManager.Extensions.Panels.ThreatSources.Capec
{
    /// <summary>
/// NoisinessEnum is a (non-exhaustive) enumeration of potential levels of noisiness for a given observable pattern.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[XmlType(Namespace="http://cybox.mitre.org/cybox-2")]
public enum NoisinessEnum
{
    /// <summary>
    /// Specifies that this observable has a high level of noisiness meaning a potentially high level of false positives.
    /// </summary>
    High,
    /// <summary>
    /// Specifies that this observable has a medium level of noisiness meaning a potentially medium level of false positives.
    /// </summary>
    Medium,
    /// <summary>
    /// Specifies that this observable has a low level of noisiness meaning a potentially low level of false positives.
    /// </summary>
    Low,
}
}
#pragma warning restore
