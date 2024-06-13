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
namespace ThreatsManager.Extensions.Panels.ThreatSources.Cwe
{
    /// <summary>
/// This element specifies a reference to a specific
/// observed instance of this weakness in the real-world; Typically
/// this will be a CVE reference. Each Observed_Example element
/// represents a single example. This element should be filled out
/// for as many entries as possible.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType=true)]
public partial class CategoryObserved_Example
{
    #region Private fields
    private List<string> _observed_Example_Reference;
    private string _observed_Example_Description;
    private List<string> _observed_Example_Link;
    #endregion
    
    /// <summary>
    /// CategoryObserved_Example class constructor
    /// </summary>
    public CategoryObserved_Example()
    {
        _observed_Example_Link = new List<string>();
        _observed_Example_Reference = new List<string>();
    }
    
    /// <summary>
    /// This field should contain the
    /// identifier for the example being cited. For example,
    /// if a CVE is being cited it should be of the standard
    /// CVE identifier format, such as CVE-2005-1951 or
    /// CVE-1999-0046.
    /// </summary>
    [XmlElement("Observed_Example_Reference")]
    public List<string> Observed_Example_Reference
    {
        get
        {
            return _observed_Example_Reference;
        }
        set
        {
            _observed_Example_Reference = value;
        }
    }
    
    /// <summary>
    /// This field should contain a product
    /// independent description of the example being cited.
    /// The description should present an unambiguous
    /// correlation between the example being described and
    /// the weakness which it is meant to exemplify. It
    /// should also be short and easy to understand.
    /// </summary>
    public string Observed_Example_Description
    {
        get
        {
            return _observed_Example_Description;
        }
        set
        {
            _observed_Example_Description = value;
        }
    }
    
    /// <summary>
    /// This field should provide a valid URL
    /// where more information regarding this example can be
    /// obtained.
    /// </summary>
    [XmlElement("Observed_Example_Link")]
    public List<string> Observed_Example_Link
    {
        get
        {
            return _observed_Example_Link;
        }
        set
        {
            _observed_Example_Link = value;
        }
    }
}
}
#pragma warning restore
