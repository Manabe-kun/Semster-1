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
namespace ThreatsManager.Extensions.Panels.ThreatSources.Cwe
{
    /// <summary>
/// This element identifies a single
/// Architectural_Paradigm in which this entry may exist
/// and with what frequency in the specified paradigm.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType=true)]
public partial class CategoryApplicable_PlatformsArchitectural_Paradigm
{
    #region Private fields
    private CategoryApplicable_PlatformsArchitectural_ParadigmArchitectural_Paradigm_Name _architectural_Paradigm_Name;
    private Frequency_Type _prevalence;
    #endregion
    
    /// <summary>
    /// This subelement identifies
    /// paradigms in which this weakness is likely to
    /// exist.
    /// </summary>
    [XmlAttribute]
    public CategoryApplicable_PlatformsArchitectural_ParadigmArchitectural_Paradigm_Name Architectural_Paradigm_Name
    {
        get
        {
            return _architectural_Paradigm_Name;
        }
        set
        {
            _architectural_Paradigm_Name = value;
        }
    }
    
    /// <summary>
    /// This attribute identifies the
    /// prevalence with which this weakness may occur
    /// within code that runs on the specified
    /// paradigm.
    /// </summary>
    [XmlAttribute]
    public Frequency_Type Prevalence
    {
        get
        {
            return _prevalence;
        }
        set
        {
            _prevalence = value;
        }
    }
}
}
#pragma warning restore
