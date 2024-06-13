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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
public partial class Structured_Text_Type
{
    #region Private fields
    private object[] _items;
    private ItemsChoiceType1[] _itemsElementName;
    #endregion
    
    [XmlElement("Block", typeof(Block))]
    [XmlElement("Code", typeof(string))]
    [XmlElement("Code_Example_Language", typeof(Language_Type))]
    [XmlElement("Comment", typeof(string))]
    [XmlElement("Image", typeof(Structured_Text_TypeImage))]
    [XmlElement("Text", typeof(string))]
    [XmlElement("Text_Title", typeof(string))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return _items;
        }
        set
        {
            _items = value;
        }
    }
    
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType1[] ItemsElementName
    {
        get
        {
            return _itemsElementName;
        }
        set
        {
            _itemsElementName = value;
        }
    }
}
}
#pragma warning restore
