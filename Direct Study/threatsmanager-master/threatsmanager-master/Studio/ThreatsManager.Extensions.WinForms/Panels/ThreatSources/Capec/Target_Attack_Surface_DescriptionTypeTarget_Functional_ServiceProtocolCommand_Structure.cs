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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType=true, Namespace="http://capec.mitre.org/capec-2")]
public partial class Target_Attack_Surface_DescriptionTypeTarget_Functional_ServiceProtocolCommand_Structure
{
    #region Private fields
    private string _command_Description;
    private string _command_Type;
    private string _command_Group_Label;
    private string _id;
    private string _name;
    #endregion
    
    public string Command_Description
    {
        get => _command_Description;
        set => _command_Description = value;
    }
    
    public string Command_Type
    {
        get => _command_Type;
        set => _command_Type = value;
    }
    
    public string Command_Group_Label
    {
        get => _command_Group_Label;
        set => _command_Group_Label = value;
    }
    
    [XmlAttribute(DataType="integer")]
    public string ID
    {
        get => _id;
        set => _id = value;
    }
    
    [XmlAttribute]
    public string Name
    {
        get => _name;
        set => _name = value;
    }
}
}
#pragma warning restore
