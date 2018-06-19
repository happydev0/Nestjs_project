// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Net.Models {
    using System;
    using System.Collections.Generic;
    using System.Net;

    public class IPv4Address : IPAddress, IComparable<IPv4Address>,
        IComparer<IPAddress>, IComparer<IPv4Address> {

        /// <summary>
        /// Create address
        /// </summary>
        /// <param name="address"></param>
        public IPv4Address(uint address) :
            base(address) {
        }

        /// <summary>
        /// Create address
        /// </summary>
        /// <param name="address"></param>
        public IPv4Address(IPAddress address) :
            this(address?.GetAddressBytes()) {
        }

        /// <summary>
        /// Create address
        /// </summary>
        /// <param name="address"></param>
        public IPv4Address(byte[] address) : base (address) {
            if (address.Length != 4) {
                throw new ArgumentException(nameof(address.Length));
            }
        }

        /// <summary>
        /// Convert to and from uint as well as increment and decrement operators
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator uint(IPv4Address value) => (uint)
            NetworkToHostOrder((int)BitConverter.ToUInt32(value.GetAddressBytes(), 0));
        public static implicit operator IPv4Address(uint value) =>
            new IPv4Address((uint)HostToNetworkOrder((int)value));
        public static explicit operator long(IPv4Address value) =>
            NetworkToHostOrder((int)BitConverter.ToUInt32(value.GetAddressBytes(), 0));
        public static explicit operator IPv4Address(long value) =>
            new IPv4Address((uint)HostToNetworkOrder((int)value));

        public static IPv4Address operator +(IPv4Address value, int x) =>
            new IPv4Address((uint)((uint)value + x));
        public static IPv4Address operator -(IPv4Address value, int x) =>
            new IPv4Address((uint)((uint)value - x));

        public static IPv4Address operator ++(IPv4Address value) => value + 1;
        public static IPv4Address operator --(IPv4Address value) => value - 1;

        /// <summary>
        /// Equality
        /// </summary>
        /// <param name="addr1"></param>
        /// <param name="addr2"></param>
        /// <returns></returns>
        public static bool operator ==(IPv4Address addr1, IPv4Address addr2) =>
            EqualityComparer<IPv4Address>.Default.Equals(addr1, addr2);

        public static bool operator !=(IPv4Address addr1, IPv4Address addr2) =>
            !(addr1 == addr2);

        /// <inheritdoc/>
        public override int GetHashCode() => base.GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object comparand) => base.Equals(comparand);

        /// <inheritdoc/>
        public int CompareTo(IPv4Address other) => (int)(this - other);

        /// <inheritdoc/>
        public int Compare(IPAddress x, IPAddress y) => Compare(x?.AsV4(), y?.AsV4());

        /// <inheritdoc/>
        public int Compare(IPv4Address x, IPv4Address y) => x.CompareTo(y);
    }
}
