// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.2.0.44
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#pragma warning disable
namespace ThreatsManager.Extensions.Panels.ThreatSources.Capec
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType=true, Namespace="http://capec.mitre.org/capec-2")]
public partial class Attack_PatternTypeExampleInstance
{
    #region Private fields
    private Structured_Text_Type _exampleInstance_Description;
    private List<Structured_Text_Type> _exampleInstance_Related_Vulnerabilities;
    #endregion
    
    /// <summary>
    /// Attack_PatternTypeExampleInstance class constructor
    /// </summary>
    public Attack_PatternTypeExampleInstance()
    {
        _exampleInstance_Related_Vulnerabilities = new List<Structured_Text_Type>();
        _exampleInstance_Description = new Structured_Text_Type();
    }
    
    [XmlElement("Example-Instance_Description")]
    public Structured_Text_Type ExampleInstance_Description
    {
        get => _exampleInstance_Description;
        set => _exampleInstance_Description = value;
    }
    
    [XmlArray("Example-Instance_Related_Vulnerabilities")]
    [XmlArrayItem("Example-Instance_Related_Vulnerability", IsNullable=false)]
    public List<Structured_Text_Type> ExampleInstance_Related_Vulnerabilities
    {
        get => _exampleInstance_Related_Vulnerabilities;
        set => _exampleInstance_Related_Vulnerabilities = value;
    }
}
}
#pragma warning restore