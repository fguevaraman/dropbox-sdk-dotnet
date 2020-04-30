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
    /// <para>The fed admin role object</para>
    /// </summary>
    public class FedAdminRole
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FedAdminRole> Encoder = new FedAdminRoleEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FedAdminRole> Decoder = new FedAdminRoleDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FedAdminRole" /> class.</para>
        /// </summary>
        public FedAdminRole()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotEnterpriseAdmin</para>
        /// </summary>
        public bool IsNotEnterpriseAdmin
        {
            get
            {
                return this is NotEnterpriseAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotEnterpriseAdmin, or <c>null</c>.</para>
        /// </summary>
        public NotEnterpriseAdmin AsNotEnterpriseAdmin
        {
            get
            {
                return this as NotEnterpriseAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EnterpriseAdmin</para>
        /// </summary>
        public bool IsEnterpriseAdmin
        {
            get
            {
                return this is EnterpriseAdmin;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EnterpriseAdmin, or <c>null</c>.</para>
        /// </summary>
        public EnterpriseAdmin AsEnterpriseAdmin
        {
            get
            {
                return this as EnterpriseAdmin;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FedAdminRole" />.</para>
        /// </summary>
        private class FedAdminRoleEncoder : enc.StructEncoder<FedAdminRole>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FedAdminRole value, enc.IJsonWriter writer)
            {
                if (value is NotEnterpriseAdmin)
                {
                    WriteProperty(".tag", "not_enterprise_admin", writer, enc.StringEncoder.Instance);
                    NotEnterpriseAdmin.Encoder.EncodeFields((NotEnterpriseAdmin)value, writer);
                    return;
                }
                if (value is EnterpriseAdmin)
                {
                    WriteProperty(".tag", "enterprise_admin", writer, enc.StringEncoder.Instance);
                    EnterpriseAdmin.Encoder.EncodeFields((EnterpriseAdmin)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FedAdminRole" />.</para>
        /// </summary>
        private class FedAdminRoleDecoder : enc.UnionDecoder<FedAdminRole>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FedAdminRole" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FedAdminRole Create()
            {
                return new FedAdminRole();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FedAdminRole Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "not_enterprise_admin":
                        return NotEnterpriseAdmin.Decoder.DecodeFields(reader);
                    case "enterprise_admin":
                        return EnterpriseAdmin.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The not enterprise admin object</para>
        /// </summary>
        public sealed class NotEnterpriseAdmin : FedAdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotEnterpriseAdmin> Encoder = new NotEnterpriseAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotEnterpriseAdmin> Decoder = new NotEnterpriseAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotEnterpriseAdmin" />
            /// class.</para>
            /// </summary>
            private NotEnterpriseAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotEnterpriseAdmin</para>
            /// </summary>
            public static readonly NotEnterpriseAdmin Instance = new NotEnterpriseAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotEnterpriseAdmin" />.</para>
            /// </summary>
            private class NotEnterpriseAdminEncoder : enc.StructEncoder<NotEnterpriseAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotEnterpriseAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotEnterpriseAdmin" />.</para>
            /// </summary>
            private class NotEnterpriseAdminDecoder : enc.StructDecoder<NotEnterpriseAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotEnterpriseAdmin"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotEnterpriseAdmin Create()
                {
                    return NotEnterpriseAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The enterprise admin object</para>
        /// </summary>
        public sealed class EnterpriseAdmin : FedAdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EnterpriseAdmin> Encoder = new EnterpriseAdminEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EnterpriseAdmin> Decoder = new EnterpriseAdminDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EnterpriseAdmin" />
            /// class.</para>
            /// </summary>
            private EnterpriseAdmin()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EnterpriseAdmin</para>
            /// </summary>
            public static readonly EnterpriseAdmin Instance = new EnterpriseAdmin();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EnterpriseAdmin" />.</para>
            /// </summary>
            private class EnterpriseAdminEncoder : enc.StructEncoder<EnterpriseAdmin>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EnterpriseAdmin value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EnterpriseAdmin" />.</para>
            /// </summary>
            private class EnterpriseAdminDecoder : enc.StructDecoder<EnterpriseAdmin>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EnterpriseAdmin" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EnterpriseAdmin Create()
                {
                    return EnterpriseAdmin.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FedAdminRole
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}