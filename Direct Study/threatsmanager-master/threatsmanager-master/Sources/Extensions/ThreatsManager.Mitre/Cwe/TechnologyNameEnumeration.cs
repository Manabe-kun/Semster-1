// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.2.97.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ThreatsManager.Mitre.Cwe
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
/// The TechnologyNameEnumeration simple type contains a list of values corresponding to different technologies. A technology represents a generally accepted feature of a system and often refers to a high-level functional component within a system.
/// </summary>
/// <summary>
/// Within this context, "IP" stands for "Intellectual Property" and is the term used to distinguish unique blocks within a System on Chip, with each block potentially coming from a different source.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[XmlTypeAttribute(Namespace="http://cwe.mitre.org/cwe-6")]
public enum TechnologyNameEnumeration
{
    [XmlEnumAttribute("Web Server")]
    WebServer,
    [XmlEnumAttribute("Database Server")]
    DatabaseServer,
    /// <summary>
    /// IP dedicated to offload a specific workload to enhance performance: DSP, packet processing, mathematical, compression, etc.
    /// </summary>
    [XmlEnumAttribute("Accelerator IP")]
    AcceleratorIP,
    /// <summary>
    /// IP that controls/senses the electricals for communication which receives/transmits signals conditioned outside of a system’s digital domain.
    /// </summary>
    [XmlEnumAttribute("Analog and Mixed Signal IP")]
    AnalogandMixedSignalIP,
    /// <summary>
    /// IP designed to manipulate audio/video data: coders/decoders, speech recognition, format converters, etc.
    /// </summary>
    [XmlEnumAttribute("Audio/Video IP")]
    AudioVideoIP,
    /// <summary>
    /// IP implementing an interconnect among elements in a computing system: I2C, PCIe, DDR, MMC, USB, GPIO, NoC, etc.
    /// </summary>
    [XmlEnumAttribute("Bus/Interface IP")]
    BusInterfaceIP,
    /// <summary>
    /// IP reflecting the passage of time in oscillations or human units: Real Time Clock, Watchdog, Monotonic Counter, etc.
    /// </summary>
    [XmlEnumAttribute("Clock/Counter IP")]
    ClockCounterIP,
    /// <summary>
    /// IP designed to transmit/receive information: Modulator/Demodulator, GPS, 802.11, Bluetooth, CDMA/DSM, etc.
    /// </summary>
    [XmlEnumAttribute("Communication IP")]
    CommunicationIP,
    /// <summary>
    /// IP circuit hard-wired (e.g., an FSM) to react in a closed-loop control system or other limited context, to control another entity: Arbiter, APIC, USB, Peripheral, Memory, Storage, etc.
    /// </summary>
    [XmlEnumAttribute("Controller IP")]
    ControllerIP,
    /// <summary>
    /// IP implementing volatile (transient) data storage: DRAM, SRAM, etc.
    /// </summary>
    [XmlEnumAttribute("Memory IP")]
    MemoryIP,
    /// <summary>
    /// IP implementing a specialized processor acting as a programmable controller.
    /// </summary>
    [XmlEnumAttribute("Microcontroller IP")]
    MicrocontrollerIP,
    [XmlEnumAttribute("Network on Chip IP")]
    NetworkonChipIP,
    /// <summary>
    /// IP that controls and/or monitors the power state of a system: voltage regulators, power controllers, power monitors, etc.
    /// </summary>
    [XmlEnumAttribute("Power Management IP")]
    PowerManagementIP,
    /// <summary>
    /// IP implementing a general-purpose computing engine: CPU, GPU, RISC, CISC, etc.
    /// </summary>
    [XmlEnumAttribute("Processor IP")]
    ProcessorIP,
    /// <summary>
    /// IP designed to protect assets: cryptography, auth, tamper detection, etc.
    /// </summary>
    [XmlEnumAttribute("Security IP")]
    SecurityIP,
    [XmlEnumAttribute("Sensor IP")]
    SensorIP,
    [XmlEnumAttribute("Storage IP")]
    StorageIP,
    /// <summary>
    /// IP designed to verify functionality and identify root cause of defects: JTAG, BIST, boundary scan, pattern generator, etc.
    /// </summary>
    [XmlEnumAttribute("Test/Debug IP")]
    TestDebugIP,
    Other,
}
}
#pragma warning restore
