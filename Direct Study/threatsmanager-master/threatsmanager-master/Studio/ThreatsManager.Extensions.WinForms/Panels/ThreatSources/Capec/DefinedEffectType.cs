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
/// The DefinedEffectType is an abstract placeholder for various predefined Object Effect types (e.g. DataReadEffect, ValuesEnumeratedEffect or StateChangeEffect) that can be instantiated in its place through extension of the DefinedEffectType. This mechanism enables the specification of a broad range of types of potential complex action effects on Objects. The set of Defined_Effect types (extending the DefinedEffectType) are maintained as part of the core CybOX schema.
/// </summary>
[XmlInclude(typeof(SendControlCodeEffectType))]
[XmlInclude(typeof(ValuesEnumeratedEffectType))]
[XmlInclude(typeof(PropertiesEnumeratedEffectType))]
[XmlInclude(typeof(PropertyReadEffectType))]
[XmlInclude(typeof(DataReceivedEffectType))]
[XmlInclude(typeof(DataSentEffectType))]
[XmlInclude(typeof(DataWrittenEffectType))]
[XmlInclude(typeof(DataReadEffectType))]
[XmlInclude(typeof(StateChangeEffectType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace="http://cybox.mitre.org/cybox-2")]
public abstract partial class DefinedEffectType
{
    #region Private fields
    private EffectTypeEnum _effect_type;
    #endregion
    
    /// <summary>
    /// The effect_type field specifies the nature of the Defined Effect instantiated in the place of the Defined_Effect element.
    /// </summary>
    [XmlAttribute]
    public EffectTypeEnum effect_type
    {
        get => _effect_type;
        set => _effect_type = value;
    }
}
}
#pragma warning restore
