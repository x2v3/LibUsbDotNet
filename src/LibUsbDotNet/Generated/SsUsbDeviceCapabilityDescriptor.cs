//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;
using System.Runtime.InteropServices;

namespace LibUsbDotNet
{
    /// <summary>
    ///  A structure representing the SuperSpeed USB Device Capability descriptor
    ///  This descriptor is documented in section 9.6.2.2 of the USB 3.0 specification.
    ///  All multiple-byte fields are represented in host-endian format.
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential, Pack = NativeMethods.Pack)]
    public struct SsUsbDeviceCapabilityDescriptor
    {
        /// <summary>
        ///  Size of this descriptor (in bytes)
        /// </summary>
        public byte Length;

        /// <summary>
        ///  Descriptor type. Will have value
        ///  LIBUSB_DT_DEVICE_CAPABILITY in this context.
        /// </summary>
        public byte DescriptorType;

        /// <summary>
        ///  Capability type. Will have value
        ///  LIBUSB_BT_SS_USB_DEVICE_CAPABILITY in this context.
        /// </summary>
        public byte DevCapabilityType;

        /// <summary>
        ///  Bitmap encoding of supported device level features.
        ///  A value of one in a bit location indicates a feature is
        ///  supported; a value of zero indicates it is not supported.
        ///  See
        /// </summary>
        public byte Attributes;

        /// <summary>
        ///  Bitmap encoding of the speed supported by this device when
        ///  operating in SuperSpeed mode. See
        /// </summary>
        public ushort SpeedSupported;

        /// <summary>
        ///  The lowest speed at which all the functionality supported
        ///  by the device is available to the user. For example if the
        ///  device supports all its functionality when connected at
        ///  full speed and above then it sets this value to 1.
        /// </summary>
        public byte FunctionalitySupport;

        /// <summary>
        ///  U1 Device Exit Latency.
        /// </summary>
        public byte U1DevExitLat;

        /// <summary>
        ///  U2 Device Exit Latency.
        /// </summary>
        public ushort U2DevExitLat;

    }
}
