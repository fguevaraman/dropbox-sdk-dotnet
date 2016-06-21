// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The folder metadata object</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Files.Metadata" />
    public class FolderMetadata : Metadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderMetadata> Encoder = new FolderMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderMetadata> Decoder = new FolderMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <param name="name">The last component of the path (including extension). This never
        /// contains a slash.</param>
        /// <param name="id">A unique identifier for the folder.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash. This field will be null if the file or folder is not
        /// mounted.</param>
        /// <param name="pathDisplay">The cased path to be used for display purposes only. In
        /// rare instances the casing will not correctly match the user's filesystem, but this
        /// behavior will match the path provided in the Core API v1. Changes to the casing of
        /// paths won't be returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" />. This field
        /// will be null if the file or folder is not mounted.</param>
        /// <param name="parentSharedFolderId">Deprecated. Please use <see
        /// cref="Dropbox.Api.Files.FileSharingInfo.ParentSharedFolderId" /> or <see
        /// cref="Dropbox.Api.Files.FolderSharingInfo.ParentSharedFolderId" /> instead.</param>
        /// <param name="sharedFolderId">Deprecated. Please use <paramref name="sharingInfo" />
        /// instead.</param>
        /// <param name="sharingInfo">Set if the folder is contained in a shared folder or is a
        /// shared folder mount point.</param>
        /// <param name="propertyGroups">Additional information if the file has custom
        /// properties with the property template specified.</param>
        public FolderMetadata(string name,
                              string id,
                              string pathLower = null,
                              string pathDisplay = null,
                              string parentSharedFolderId = null,
                              string sharedFolderId = null,
                              FolderSharingInfo sharingInfo = null,
                              col.IEnumerable<Dropbox.Api.Properties.PropertyGroup> propertyGroups = null)
            : base(name, pathLower, pathDisplay, parentSharedFolderId)
        {
            if (id == null)
            {
                throw new sys.ArgumentNullException("id");
            }
            if (id.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("id", "Length should be at least 1");
            }

            if (sharedFolderId != null)
            {
                if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("sharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            var propertyGroupsList = enc.Util.ToList(propertyGroups);

            this.Id = id;
            this.SharedFolderId = sharedFolderId;
            this.SharingInfo = sharingInfo;
            this.PropertyGroups = propertyGroupsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FolderMetadata()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the folder.</para>
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// <para>Deprecated. Please use <see cref="SharingInfo" /> instead.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>Set if the folder is contained in a shared folder or is a shared folder mount
        /// point.</para>
        /// </summary>
        public FolderSharingInfo SharingInfo { get; protected set; }

        /// <summary>
        /// <para>Additional information if the file has custom properties with the property
        /// template specified.</para>
        /// </summary>
        public col.IList<Dropbox.Api.Properties.PropertyGroup> PropertyGroups { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderMetadata" />.</para>
        /// </summary>
        private class FolderMetadataEncoder : enc.StructEncoder<FolderMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                if (value.PathLower != null)
                {
                    WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                }
                if (value.PathDisplay != null)
                {
                    WriteProperty("path_display", value.PathDisplay, writer, enc.StringEncoder.Instance);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.SharedFolderId != null)
                {
                    WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                }
                if (value.SharingInfo != null)
                {
                    WriteProperty("sharing_info", value.SharingInfo, writer, Dropbox.Api.Files.FolderSharingInfo.Encoder);
                }
                if (value.PropertyGroups.Count > 0)
                {
                    WriteListProperty("property_groups", value.PropertyGroups, writer, Dropbox.Api.Properties.PropertyGroup.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderMetadata" />.</para>
        /// </summary>
        private class FolderMetadataDecoder : enc.StructDecoder<FolderMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderMetadata Create()
            {
                return new FolderMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FolderMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_display":
                        value.PathDisplay = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "sharing_info":
                        value.SharingInfo = Dropbox.Api.Files.FolderSharingInfo.Decoder.Decode(reader);
                        break;
                    case "property_groups":
                        value.PropertyGroups = ReadList<Dropbox.Api.Properties.PropertyGroup>(reader, Dropbox.Api.Properties.PropertyGroup.Decoder);
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
