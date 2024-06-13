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
/// A category in CAPEC is a collection of attack patterns based on some common characteristic. More specifically, it is an aggregation of attack patterns based on effect/intent. (as opposed to actions or mechanisms, such an aggregation would be a meta attack pattern) An aggregation based on effect/intent is not an actionable attack and as such is not a pattern of attack behavior. Rather, it is a grouping of patterns based on some common criteria.
/// </summary>
/// <summary>
/// The required Summary element should be short and limited to the key points that define the category. The optional Relationships element is used to define relationships with attack patterns, categories, and views. The optional Taxonomy_Mappings element is used to relate this category to similar categories in taxomomies outside of CAPEC. The optional References element is used to provide further reading and insight into this category. This should be used when the category is based on external sources or projects. The optional Notes element is used to provide any additional comments that cannot be captured using the other elements of the category. The optional Content_History element is used to keep track of the original author of the category and any subsequent modifications to the content. This provides a means of contacting the authors and modifiers for clarifying ambiguities, merging overlapping contributions, etc.
/// </summary>
/// <summary>
/// The required ID attribute provides a unique identifier for the category. It is meant to be static for the lifetime of the category. In the event that the category becomes deprecated, the identifier should not be reused and a placeholder for the deprecated category should be left in the catalog. The required Name attribute provides a descriptive title used to give the reader an idea of what characteristic this category represents. All words in the name should be capitalized except for articles and prepositions unless they begin or end the name. The required Status attribute defines the status level for this category. Please refer to the StatusEnumeration simple type for a list of valid values and their meanings.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DebuggerStepThrough]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="http://capec.mitre.org/capec-3")]
public partial class CategoryType
{
    private static XmlSerializer _serializer;
    
        public StructuredTextType Summary { get; set; }
        public RelationshipsType Relationships { get; set; }
        [XmlArrayItemAttribute("Taxonomy_Mapping", IsNullable=false)]
        public List<TaxonomyMappingsTypeTaxonomy_Mapping> Taxonomy_Mappings { get; set; }
        [XmlArrayItemAttribute("Reference", IsNullable=false)]
        public List<ReferencesTypeReference> References { get; set; }
        [XmlArrayItemAttribute("Note", IsNullable=false)]
        public List<NotesTypeNote> Notes { get; set; }
        public ContentHistoryType Content_History { get; set; }
        [XmlAttribute(DataType="integer")]
        public string ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public StatusEnumeration Status { get; set; }
    
    /// <summary>
    /// CategoryType class constructor
    /// </summary>
    public CategoryType()
    {
        Content_History = new ContentHistoryType();
        Notes = new List<NotesTypeNote>();
        References = new List<ReferencesTypeReference>();
        Taxonomy_Mappings = new List<TaxonomyMappingsTypeTaxonomy_Mapping>();
        Relationships = new RelationshipsType();
        Summary = new StructuredTextType();
    }
    
    private static XmlSerializer SerializerXML
    {
        get
        {
            if ((_serializer == null))
            {
                _serializer = new XmlSerializerFactory().CreateSerializer(typeof(CategoryType));
            }
            return _serializer;
        }
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serialize CategoryType object
    /// </summary>
    /// <returns>XML value</returns>
    public virtual string Serialize()
    {
        StreamReader streamReader = null;
        MemoryStream memoryStream = null;
        try
        {
            memoryStream = new MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            SerializerXML.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes CategoryType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output CategoryType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out CategoryType obj, out Exception exception)
    {
        exception = null;
        obj = default(CategoryType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out CategoryType obj)
    {
        Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public static CategoryType Deserialize(string input)
    {
        StringReader stringReader = null;
        try
        {
            stringReader = new StringReader(input);
            return ((CategoryType)(SerializerXML.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static CategoryType Deserialize(Stream s)
    {
        return ((CategoryType)(SerializerXML.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current CategoryType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, out Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName);
            return true;
        }
        catch (Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual void SaveToFile(string fileName)
    {
        StreamWriter streamWriter = null;
        try
        {
            string dataString = Serialize();
            FileInfo outputFile = new FileInfo(fileName);
            streamWriter = outputFile.CreateText();
            streamWriter.WriteLine(dataString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an CategoryType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output CategoryType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, out CategoryType obj, out Exception exception)
    {
        exception = null;
        obj = default(CategoryType);
        try
        {
            obj = LoadFromFile(fileName);
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out CategoryType obj)
    {
        Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static CategoryType LoadFromFile(string fileName)
    {
        FileStream file = null;
        StreamReader sr = null;
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(file);
            string dataString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(dataString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
}
}
#pragma warning restore