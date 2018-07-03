// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Host details.</para>
    /// </summary>
    public class HostLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<HostLogInfo> Encoder = new HostLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<HostLogInfo> Decoder = new HostLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="HostLogInfo" /> class.</para>
        /// </summary>
        /// <param name="hostId">Host ID. Might be missing due to historical data gap.</param>
        /// <param name="hostName">Host name. Might be missing due to historical data
        /// gap.</param>
        public HostLogInfo(ulong? hostId = null,
                           string hostName = null)
        {
            this.HostId = hostId;
            this.HostName = hostName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="HostLogInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public HostLogInfo()
        {
        }

        /// <summary>
        /// <para>Host ID. Might be missing due to historical data gap.</para>
        /// </summary>
        public ulong? HostId { get; protected set; }

        /// <summary>
        /// <para>Host name. Might be missing due to historical data gap.</para>
        /// </summary>
        public string HostName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="HostLogInfo" />.</para>
        /// </summary>
        private class HostLogInfoEncoder : enc.StructEncoder<HostLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(HostLogInfo value, enc.IJsonWriter writer)
            {
                if (value.HostId != null)
                {
                    WriteProperty("host_id", value.HostId.Value, writer, enc.UInt64Encoder.Instance);
                }
                if (value.HostName != null)
                {
                    WriteProperty("host_name", value.HostName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="HostLogInfo" />.</para>
        /// </summary>
        private class HostLogInfoDecoder : enc.StructDecoder<HostLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="HostLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override HostLogInfo Create()
            {
                return new HostLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(HostLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "host_id":
                        value.HostId = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    case "host_name":
                        value.HostName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}