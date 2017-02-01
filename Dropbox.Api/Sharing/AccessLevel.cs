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
    /// <para>Defines the access levels for collaborators.</para>
    /// </summary>
    public class AccessLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccessLevel> Encoder = new AccessLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccessLevel> Decoder = new AccessLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AccessLevel" /> class.</para>
        /// </summary>
        public AccessLevel()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Owner</para>
        /// </summary>
        public bool IsOwner
        {
            get
            {
                return this is Owner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Owner, or <c>null</c>.</para>
        /// </summary>
        public Owner AsOwner
        {
            get
            {
                return this as Owner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Editor</para>
        /// </summary>
        public bool IsEditor
        {
            get
            {
                return this is Editor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Editor, or <c>null</c>.</para>
        /// </summary>
        public Editor AsEditor
        {
            get
            {
                return this as Editor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Viewer</para>
        /// </summary>
        public bool IsViewer
        {
            get
            {
                return this is Viewer;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Viewer, or <c>null</c>.</para>
        /// </summary>
        public Viewer AsViewer
        {
            get
            {
                return this as Viewer;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ViewerNoComment</para>
        /// </summary>
        public bool IsViewerNoComment
        {
            get
            {
                return this is ViewerNoComment;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ViewerNoComment, or <c>null</c>.</para>
        /// </summary>
        public ViewerNoComment AsViewerNoComment
        {
            get
            {
                return this as ViewerNoComment;
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
        /// <para>Encoder for  <see cref="AccessLevel" />.</para>
        /// </summary>
        private class AccessLevelEncoder : enc.StructEncoder<AccessLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccessLevel value, enc.IJsonWriter writer)
            {
                if (value is Owner)
                {
                    WriteProperty(".tag", "owner", writer, enc.StringEncoder.Instance);
                    Owner.Encoder.EncodeFields((Owner)value, writer);
                    return;
                }
                if (value is Editor)
                {
                    WriteProperty(".tag", "editor", writer, enc.StringEncoder.Instance);
                    Editor.Encoder.EncodeFields((Editor)value, writer);
                    return;
                }
                if (value is Viewer)
                {
                    WriteProperty(".tag", "viewer", writer, enc.StringEncoder.Instance);
                    Viewer.Encoder.EncodeFields((Viewer)value, writer);
                    return;
                }
                if (value is ViewerNoComment)
                {
                    WriteProperty(".tag", "viewer_no_comment", writer, enc.StringEncoder.Instance);
                    ViewerNoComment.Encoder.EncodeFields((ViewerNoComment)value, writer);
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
        /// <para>Decoder for  <see cref="AccessLevel" />.</para>
        /// </summary>
        private class AccessLevelDecoder : enc.UnionDecoder<AccessLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AccessLevel" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccessLevel Create()
            {
                return new AccessLevel();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AccessLevel Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "owner":
                        return Owner.Decoder.DecodeFields(reader);
                    case "editor":
                        return Editor.Decoder.DecodeFields(reader);
                    case "viewer":
                        return Viewer.Decoder.DecodeFields(reader);
                    case "viewer_no_comment":
                        return ViewerNoComment.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The collaborator is the owner of the shared folder. Owners can view and edit
        /// the shared folder as well as set the folder's policies using <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.UpdateFolderPolicyAsync"
        /// />.</para>
        /// </summary>
        public sealed class Owner : AccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Owner> Encoder = new OwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Owner> Decoder = new OwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Owner" /> class.</para>
            /// </summary>
            private Owner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Owner</para>
            /// </summary>
            public static readonly Owner Instance = new Owner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Owner" />.</para>
            /// </summary>
            private class OwnerEncoder : enc.StructEncoder<Owner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Owner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Owner" />.</para>
            /// </summary>
            private class OwnerDecoder : enc.StructDecoder<Owner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Owner" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Owner Create()
                {
                    return new Owner();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Owner DecodeFields(enc.IJsonReader reader)
                {
                    return Owner.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The collaborator can both view and edit the shared folder.</para>
        /// </summary>
        public sealed class Editor : AccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Editor> Encoder = new EditorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Editor> Decoder = new EditorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Editor" /> class.</para>
            /// </summary>
            private Editor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Editor</para>
            /// </summary>
            public static readonly Editor Instance = new Editor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorEncoder : enc.StructEncoder<Editor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Editor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Editor" />.</para>
            /// </summary>
            private class EditorDecoder : enc.StructDecoder<Editor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Editor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Editor Create()
                {
                    return new Editor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Editor DecodeFields(enc.IJsonReader reader)
                {
                    return Editor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The collaborator can only view the shared folder.</para>
        /// </summary>
        public sealed class Viewer : AccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Viewer> Encoder = new ViewerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Viewer> Decoder = new ViewerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Viewer" /> class.</para>
            /// </summary>
            private Viewer()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Viewer</para>
            /// </summary>
            public static readonly Viewer Instance = new Viewer();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerEncoder : enc.StructEncoder<Viewer>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Viewer value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Viewer" />.</para>
            /// </summary>
            private class ViewerDecoder : enc.StructDecoder<Viewer>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Viewer" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Viewer Create()
                {
                    return new Viewer();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Viewer DecodeFields(enc.IJsonReader reader)
                {
                    return Viewer.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The collaborator can only view the shared folder and does not have any access
        /// to comments.</para>
        /// </summary>
        public sealed class ViewerNoComment : AccessLevel
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ViewerNoComment> Encoder = new ViewerNoCommentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ViewerNoComment> Decoder = new ViewerNoCommentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ViewerNoComment" />
            /// class.</para>
            /// </summary>
            private ViewerNoComment()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ViewerNoComment</para>
            /// </summary>
            public static readonly ViewerNoComment Instance = new ViewerNoComment();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ViewerNoComment" />.</para>
            /// </summary>
            private class ViewerNoCommentEncoder : enc.StructEncoder<ViewerNoComment>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ViewerNoComment value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ViewerNoComment" />.</para>
            /// </summary>
            private class ViewerNoCommentDecoder : enc.StructDecoder<ViewerNoComment>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ViewerNoComment" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ViewerNoComment Create()
                {
                    return new ViewerNoComment();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ViewerNoComment DecodeFields(enc.IJsonReader reader)
                {
                    return ViewerNoComment.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AccessLevel
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