// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The relinquish file membership error object</para>
    /// </summary>
    public class RelinquishFileMembershipError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelinquishFileMembershipError> Encoder = new RelinquishFileMembershipErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelinquishFileMembershipError> Decoder = new RelinquishFileMembershipErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelinquishFileMembershipError"
        /// /> class.</para>
        /// </summary>
        public RelinquishFileMembershipError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupAccess</para>
        /// </summary>
        public bool IsGroupAccess
        {
            get
            {
                return this is GroupAccess;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupAccess, or <c>null</c>.</para>
        /// </summary>
        public GroupAccess AsGroupAccess
        {
            get
            {
                return this as GroupAccess;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
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
        /// <para>Encoder for  <see cref="RelinquishFileMembershipError" />.</para>
        /// </summary>
        private class RelinquishFileMembershipErrorEncoder : enc.StructEncoder<RelinquishFileMembershipError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelinquishFileMembershipError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is GroupAccess)
                {
                    WriteProperty(".tag", "group_access", writer, enc.StringEncoder.Instance);
                    GroupAccess.Encoder.EncodeFields((GroupAccess)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
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
        /// <para>Decoder for  <see cref="RelinquishFileMembershipError" />.</para>
        /// </summary>
        private class RelinquishFileMembershipErrorDecoder : enc.UnionDecoder<RelinquishFileMembershipError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelinquishFileMembershipError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelinquishFileMembershipError Create()
            {
                return new RelinquishFileMembershipError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RelinquishFileMembershipError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "group_access":
                        return GroupAccess.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : RelinquishFileMembershipError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(SharingFileAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharingFileAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Sharing.SharingFileAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = Dropbox.Api.Sharing.SharingFileAccessError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The current user has access to the shared file via a group.  You can't
        /// relinquish membership to a file shared via groups.</para>
        /// </summary>
        public sealed class GroupAccess : RelinquishFileMembershipError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupAccess> Encoder = new GroupAccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupAccess> Decoder = new GroupAccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupAccess" />
            /// class.</para>
            /// </summary>
            private GroupAccess()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupAccess</para>
            /// </summary>
            public static readonly GroupAccess Instance = new GroupAccess();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupAccess" />.</para>
            /// </summary>
            private class GroupAccessEncoder : enc.StructEncoder<GroupAccess>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupAccess value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupAccess" />.</para>
            /// </summary>
            private class GroupAccessDecoder : enc.StructDecoder<GroupAccess>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupAccess" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupAccess Create()
                {
                    return new GroupAccess();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupAccess DecodeFields(enc.IJsonReader reader)
                {
                    return GroupAccess.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : RelinquishFileMembershipError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return new NoPermission();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoPermission DecodeFields(enc.IJsonReader reader)
                {
                    return NoPermission.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : RelinquishFileMembershipError
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
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
