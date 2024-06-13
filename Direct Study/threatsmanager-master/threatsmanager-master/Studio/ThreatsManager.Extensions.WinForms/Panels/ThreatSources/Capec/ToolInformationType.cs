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
    /// <summary>
/// The ToolInformationType is intended to characterize the properties of a hardware or software tool, including those related to instances of its use.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace="http://cybox.mitre.org/common-2")]
public partial class ToolInformationType
{
    #region Private fields
    private string _name;
    private List<ControlledVocabularyStringType> _type;
    private StructuredTextType _description;
    private List<ToolReferenceType> _references;
    private string _vendor;
    private string _version;
    private string _service_Pack;
    private ToolSpecificDataType _tool_Specific_Data;
    private List<HashType> _tool_Hashes;
    private ToolConfigurationType _tool_Configuration;
    private ExecutionEnvironmentType _execution_Environment;
    private List<ErrorType> _errors;
    private List<MetadataType> _metadata;
    private CompensationModelType _compensation_Model;
    private System.Xml.XmlQualifiedName _id;
    private System.Xml.XmlQualifiedName _idref;
    #endregion
    
    /// <summary>
    /// ToolInformationType class constructor
    /// </summary>
    public ToolInformationType()
    {
        _compensation_Model = new CompensationModelType();
        _metadata = new List<MetadataType>();
        _errors = new List<ErrorType>();
        _execution_Environment = new ExecutionEnvironmentType();
        _tool_Configuration = new ToolConfigurationType();
        _tool_Hashes = new List<HashType>();
        _references = new List<ToolReferenceType>();
        _description = new StructuredTextType();
        _type = new List<ControlledVocabularyStringType>();
    }
    
    /// <summary>
    /// This field contains the name of the tool leveraged.
    /// </summary>
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    /// <summary>
    /// This field contains the type of the tool leveraged.
    /// </summary>
    /// <summary>
    /// This field is implemented through the xsi:type controlled vocabulary extension mechanism. No default vocabulary type has been defined for CybOX 2.0. Users may either define their own vocabulary using the type extension mechanism (by specifying a vocabulary name and/or reference using the vocab_name and vocab_reference attributes, respectively) or simply use this as a free string field. Additionally, locations where the ToolInformationType is used may define default vocabularies for this field.
    /// </summary>
    [XmlElement("Type")]
    public List<ControlledVocabularyStringType> Type
    {
        get => _type;
        set => _type = value;
    }
    
    /// <summary>
    /// This field contains general descriptive information for this tool.
    /// </summary>
    public StructuredTextType Description
    {
        get => _description;
        set => _description = value;
    }
    
    /// <summary>
    /// This field contains references to instances or additional information for this tool.
    /// </summary>
    [XmlArrayItem("Reference", IsNullable=false)]
    public List<ToolReferenceType> References
    {
        get => _references;
        set => _references = value;
    }
    
    /// <summary>
    /// This field contains information identifying the vendor organization for this tool.
    /// </summary>
    public string Vendor
    {
        get => _vendor;
        set => _vendor = value;
    }
    
    /// <summary>
    /// This field contains an appropriate version descriptor of this tool.
    /// </summary>
    public string Version
    {
        get => _version;
        set => _version = value;
    }
    
    /// <summary>
    /// This field contains an appropriate service pack descriptor for this tool.
    /// </summary>
    public string Service_Pack
    {
        get => _service_Pack;
        set => _service_Pack = value;
    }
    
    /// <summary>
    /// This is an abstract type provided to a flexible mechanism for enabling tool-specific data to be included.
    /// </summary>
    public ToolSpecificDataType Tool_Specific_Data
    {
        get => _tool_Specific_Data;
        set => _tool_Specific_Data = value;
    }
    
    /// <summary>
    /// This field contains a hash value computed on the tool file content in order to verify its integrity.
    /// </summary>
    [XmlArrayItem("Hash", IsNullable=false)]
    public List<HashType> Tool_Hashes
    {
        get => _tool_Hashes;
        set => _tool_Hashes = value;
    }
    
    /// <summary>
    /// This field contains information describing the configuration and usage of the tool.
    /// </summary>
    public ToolConfigurationType Tool_Configuration
    {
        get => _tool_Configuration;
        set => _tool_Configuration = value;
    }
    
    /// <summary>
    /// This field contains information describing the execution environment of the tool.
    /// </summary>
    public ExecutionEnvironmentType Execution_Environment
    {
        get => _execution_Environment;
        set => _execution_Environment = value;
    }
    
    /// <summary>
    /// This field captures any errors generated during the run of the tool.
    /// </summary>
    [XmlArrayItem("Error", IsNullable=false)]
    public List<ErrorType> Errors
    {
        get => _errors;
        set => _errors = value;
    }
    
    /// <summary>
    /// This field captures other relevant metadata including tool-specific fields.
    /// </summary>
    [XmlElement("Metadata")]
    public List<MetadataType> Metadata
    {
        get => _metadata;
        set => _metadata = value;
    }
    
    /// <summary>
    /// This field contains the name of the compensation model used for the tool.
    /// </summary>
    public CompensationModelType Compensation_Model
    {
        get => _compensation_Model;
        set => _compensation_Model = value;
    }
    
    /// <summary>
    /// The id field specifies a unique ID for this Tool.
    /// </summary>
    [XmlAttribute]
    public System.Xml.XmlQualifiedName id
    {
        get => _id;
        set => _id = value;
    }
    
    /// <summary>
    /// The idref field specifies reference to a unique ID for this Tool.
    /// </summary>
    /// <summary>
    /// When idref is specified, the id attribute must not be specified, and any instance of this type should not hold content unless an extension of the type allows it.
    /// </summary>
    [XmlAttribute]
    public System.Xml.XmlQualifiedName idref
    {
        get => _idref;
        set => _idref = value;
    }
}
}
#pragma warning restore
