// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.44
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#pragma warning disable
namespace ThreatsManager.Extensions.Panels.ThreatSources.Capec
{
    /// <summary>
/// The DataSizeType specifies the size of the data segment.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace="http://cybox.mitre.org/common-2")]
public partial class DataSizeType : StringObjectPropertyType
{
    #region Private fields
    private DataSizeUnitsEnum _units;
    #endregion
    
    /// <summary>
    /// This field represents the Units used in the object size element.
    /// </summary>
    [XmlAttribute]
    public DataSizeUnitsEnum units
    {
        get => _units;
        set => _units = value;
    }
}
}
#pragma warning restore
