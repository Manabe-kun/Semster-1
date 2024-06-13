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
/// DataTypeEnum is a (non-exhaustive) enumeration of data types.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
[Serializable]
[XmlType(Namespace="http://cybox.mitre.org/common-2")]
public enum DatatypeEnum
{
    /// <summary>
    /// Specifies the string datatype as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#string for more information.
    /// </summary>
    @string,
    /// <summary>
    /// Specifies the int datatype as it applies to the W3C standard for int. See http://www.w3.org/TR/xmlschema-2/#int for more information.
    /// </summary>
    @int,
    /// <summary>
    /// Specifies the float datatype as it apples to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#float for more information.
    /// </summary>
    @float,
    /// <summary>
    /// Specifies a date, which is usually in the form yyyy-mm--dd as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#date for more information.
    /// </summary>
    date,
    /// <summary>
    /// Specifies a positive integer in the infinite set {1,2,...} as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#positiveInteger for more information.
    /// </summary>
    positiveInteger,
    /// <summary>
    /// Specifies an unsigned integer, which is a nonnegative integer in the set {0,1,2,...,4294967295} as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#unsignedInt for more information.
    /// </summary>
    unsignedInt,
    /// <summary>
    /// Specifies a date in full format including both date and time as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#dateTime for more information.
    /// </summary>
    dateTime,
    /// <summary>
    /// Specifies a time as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#time for more information.
    /// </summary>
    time,
    /// <summary>
    /// Specifies a boolean value in the set {true,false,1,0} as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#boolean for more information.
    /// </summary>
    boolean,
    /// <summary>
    /// Specifies a name (which represents XML Names) as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#Name and http://www.w3.org/TR/2000/WD-xml-2e-20000814#dt-name for more information.
    /// </summary>
    name,
    /// <summary>
    /// Specifies a long integer, which is an integer whose maximum value is 9223372036854775807 and minimum value is -9223372036854775808 as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#long for more information.
    /// </summary>
    @long,
    /// <summary>
    /// Specifies an unsigned long integer, which is an integer whose maximum value is 18446744073709551615 and minimum value is 0 as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#unsignedLong for more information.
    /// </summary>
    unsignedLong,
    /// <summary>
    /// Specifies a length of time in the extended format PnYn MnDTnH nMnS, where nY represents the number of years, nM the number of months, nD the number of days, 'T' is the date/time separator, nH the number of hours, nM the number of minutes and nS the number of seconds, as it applies to the W3 standard. See http://www.w3.org/TR/xmlschema-2/#duration for more information.
    /// </summary>
    duration,
    /// <summary>
    /// Specifies a decimal of datatype double as it is patterned after the IEEE double-precision 64-bit floating point type (IEEE 754-1985) and as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#double for more information.
    /// </summary>
    @double,
    /// <summary>
    /// Specifies a non-negative integer in the infinite set {0,1,2,...} as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#nonNegativeInteger for more information.
    /// </summary>
    nonNegativeInteger,
    /// <summary>
    /// Specifies arbitrary hex-encoded binary data as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#hexBinary for more information.
    /// </summary>
    hexBinary,
    /// <summary>
    /// Specifies a Uniform Resource Identifier Reference (URI) as it applies to the W3C standard and to RFC 2396, as amended by RFC 2732. See http://www.w3.org/TR/xmlschema-2/#anyURI for more information.
    /// </summary>
    anyURI,
    /// <summary>
    /// Specifies base64-encoded arbitrary binary data as it applies to the W3C standard. See http://www.w3.org/TR/xmlschema-2/#base64Binary for more information.
    /// </summary>
    base64Binary,
    /// <summary>
    /// Specifies an IPV4 address in dotted decimal form. CIDR notation is also accepted.
    /// </summary>
    [XmlEnum("IPv4 Address")]
    IPv4Address,
    /// <summary>
    /// Specifies an IPV6 address, which is represented by eight groups of 16-bit hexadecimal values separated by colons (:) in the form a:b:c:d:e:f:g:h. CIDR notation is also accepted.
    /// </summary>
    [XmlEnum("IPv6 Address")]
    IPv6Address,
    /// <summary>
    /// Specifies a host name. For compatibility reasons, this could be any string. Even so, it is best to use the proper notation for the given host type. For example, web hostnames should be written as fully qualified hostnames in practice.
    /// </summary>
    [XmlEnum("Host Name")]
    HostName,
    /// <summary>
    /// Specifies a MAC address, which is represented by six groups of 2 hexdecimal digits, separated by hyphens (-) or colons (:) in transmission order.
    /// </summary>
    [XmlEnum("MAC Address")]
    MACAddress,
    /// <summary>
    /// Specifies a domain name, which is represented by a series of labels concatenated with dots conforming to the rules in RFC 1035, RFC 1123, and RFC 2181.
    /// </summary>
    [XmlEnum("Domain Name")]
    DomainName,
    /// <summary>
    /// Specifies a Uniform Resource Identifier, which identifies a name or resource and can act as a URL or URN.
    /// </summary>
    URI,
    /// <summary>
    /// Specifies a timezone in UTC notation (UTC+number).
    /// </summary>
    TimeZone,
    /// <summary>
    /// Specifies arbitrary octal (base-8) encoded data.
    /// </summary>
    Octal,
    /// <summary>
    /// Specifies arbitrary binary encoded data.
    /// </summary>
    Binary,
    /// <summary>
    /// Specifies arbitrary data encoded in the Mac OS-originated BinHex format.
    /// </summary>
    BinHex,
    /// <summary>
    /// Specifies a subnet mask in IPv4 or IPv6 notation.
    /// </summary>
    [XmlEnum("Subnet Mask")]
    SubnetMask,
    /// <summary>
    /// Specifies a globally/universally unique ID represented as a 32-character hexadecimal string. See ISO/IEC 11578:1996 Information technology -- Open Systems Interconnection -- Remote Procedure Call - http://www.iso.ch/cate/d2229.html.
    /// </summary>
    [XmlEnum("UUID/GUID")]
    UUIDGUID,
    /// <summary>
    /// Specifies data represented as a container of multiple data of a shared elemental type.
    /// </summary>
    Collection,
    /// <summary>
    /// Specifies a CVE ID, expressed as CVE- appended by a four-digit integer, a - and another four-digit integer, as in CVE-2012-1234.
    /// </summary>
    [XmlEnum("CVE ID")]
    CVEID,
    /// <summary>
    /// Specifies a CWE ID, expressed as CWE- appended by an integer.
    /// </summary>
    [XmlEnum("CWE ID")]
    CWEID,
    /// <summary>
    /// Specifies a CAPEC ID, expressed as CAPEC- appended by an integer.
    /// </summary>
    [XmlEnum("CAPEC ID")]
    CAPECID,
    /// <summary>
    /// Specifies a CCE ID, expressed as CCE- appended by an integer.
    /// </summary>
    [XmlEnum("CCE ID")]
    CCEID,
    /// <summary>
    /// Specifies a CPE Name. See http://cpe.mitre.org/specification/archive/version2.0/cpe-specification_2.0.pdf for more information.
    /// </summary>
    [XmlEnum("CPE Name")]
    CPEName,
}
}
#pragma warning restore
