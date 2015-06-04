// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Path validation errors.</para>
    /// </summary>
    public class PathError : enc.IEncodable<PathError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PathError" /> class.</para>
        /// </summary>
        public PathError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RootDisallowed</para>
        /// </summary>
        public bool IsRootDisallowed
        {
            get
            {
                return this is RootDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RootDisallowed, or <c>null</c>.</para>
        /// </summary>
        public RootDisallowed AsRootDisallowed
        {
            get
            {
                return this as RootDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MalformedPath</para>
        /// </summary>
        public bool IsMalformedPath
        {
            get
            {
                return this is MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MalformedPath, or <c>null</c>.</para>
        /// </summary>
        public MalformedPath AsMalformedPath
        {
            get
            {
                return this as MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FileDisallowed</para>
        /// </summary>
        public bool IsFileDisallowed
        {
            get
            {
                return this is FileDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FileDisallowed, or <c>null</c>.</para>
        /// </summary>
        public FileDisallowed AsFileDisallowed
        {
            get
            {
                return this as FileDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FolderDisallowed</para>
        /// </summary>
        public bool IsFolderDisallowed
        {
            get
            {
                return this is FolderDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FolderDisallowed, or <c>null</c>.</para>
        /// </summary>
        public FolderDisallowed AsFolderDisallowed
        {
            get
            {
                return this as FolderDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ConflictFile</para>
        /// </summary>
        public bool IsConflictFile
        {
            get
            {
                return this is ConflictFile;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ConflictFile, or <c>null</c>.</para>
        /// </summary>
        public ConflictFile AsConflictFile
        {
            get
            {
                return this as ConflictFile;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ConflictFolder</para>
        /// </summary>
        public bool IsConflictFolder
        {
            get
            {
                return this is ConflictFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ConflictFolder, or <c>null</c>.</para>
        /// </summary>
        public ConflictFolder AsConflictFolder
        {
            get
            {
                return this as ConflictFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ConflictFileAncestor</para>
        /// </summary>
        public bool IsConflictFileAncestor
        {
            get
            {
                return this is ConflictFileAncestor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ConflictFileAncestor, or <c>null</c>.</para>
        /// </summary>
        public ConflictFileAncestor AsConflictFileAncestor
        {
            get
            {
                return this as ConflictFileAncestor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ReadOnly</para>
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return this is ReadOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ReadOnly, or <c>null</c>.</para>
        /// </summary>
        public ReadOnly AsReadOnly
        {
            get
            {
                return this as ReadOnly;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// SharedFolderDisallowed</para>
        /// </summary>
        public bool IsSharedFolderDisallowed
        {
            get
            {
                return this is SharedFolderDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SharedFolderDisallowed, or <c>null</c>.</para>
        /// </summary>
        public SharedFolderDisallowed AsSharedFolderDisallowed
        {
            get
            {
                return this as SharedFolderDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AutorenameFiled</para>
        /// </summary>
        public bool IsAutorenameFiled
        {
            get
            {
                return this is AutorenameFiled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AutorenameFiled, or <c>null</c>.</para>
        /// </summary>
        public AutorenameFiled AsAutorenameFiled
        {
            get
            {
                return this as AutorenameFiled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Misc</para>
        /// </summary>
        public bool IsMisc
        {
            get
            {
                return this is Misc;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Misc, or <c>null</c>.</para>
        /// </summary>
        public Misc AsMisc
        {
            get
            {
                return this as Misc;
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

        #region IEncodable<PathError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<PathError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsRootDisallowed)
            {
                ((enc.IEncodable<RootDisallowed>)this).Encode(encoder);
            }
            else if (this.IsMalformedPath)
            {
                ((enc.IEncodable<MalformedPath>)this).Encode(encoder);
            }
            else if (this.IsNotFound)
            {
                ((enc.IEncodable<NotFound>)this).Encode(encoder);
            }
            else if (this.IsFileDisallowed)
            {
                ((enc.IEncodable<FileDisallowed>)this).Encode(encoder);
            }
            else if (this.IsFolderDisallowed)
            {
                ((enc.IEncodable<FolderDisallowed>)this).Encode(encoder);
            }
            else if (this.IsConflictFile)
            {
                ((enc.IEncodable<ConflictFile>)this).Encode(encoder);
            }
            else if (this.IsConflictFolder)
            {
                ((enc.IEncodable<ConflictFolder>)this).Encode(encoder);
            }
            else if (this.IsConflictFileAncestor)
            {
                ((enc.IEncodable<ConflictFileAncestor>)this).Encode(encoder);
            }
            else if (this.IsReadOnly)
            {
                ((enc.IEncodable<ReadOnly>)this).Encode(encoder);
            }
            else if (this.IsSharedFolderDisallowed)
            {
                ((enc.IEncodable<SharedFolderDisallowed>)this).Encode(encoder);
            }
            else if (this.IsAutorenameFiled)
            {
                ((enc.IEncodable<AutorenameFiled>)this).Encode(encoder);
            }
            else if (this.IsMisc)
            {
                ((enc.IEncodable<Misc>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        PathError enc.IEncodable<PathError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "root_disallowed":
                return RootDisallowed.Instance;
            case "malformed_path":
                using (var obj = decoder.GetObject())
                {
                    return new MalformedPath(obj.GetField<string>("malformed_path"));
                }
            case "not_found":
                return NotFound.Instance;
            case "file_disallowed":
                return FileDisallowed.Instance;
            case "folder_disallowed":
                return FolderDisallowed.Instance;
            case "conflict_file":
                return ConflictFile.Instance;
            case "conflict_folder":
                return ConflictFolder.Instance;
            case "conflict_file_ancestor":
                return ConflictFileAncestor.Instance;
            case "read_only":
                return ReadOnly.Instance;
            case "shared_folder_disallowed":
                return SharedFolderDisallowed.Instance;
            case "autorename_filed":
                return AutorenameFiled.Instance;
            case "misc":
                using (var obj = decoder.GetObject())
                {
                    return new Misc(obj.GetField<string>("misc"));
                }
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The path should not be empty.</para>
        /// </summary>
        public sealed class RootDisallowed : PathError, enc.IEncodable<RootDisallowed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RootDisallowed" />
            /// class.</para>
            /// </summary>
            private RootDisallowed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RootDisallowed</para>
            /// </summary>
            public static readonly RootDisallowed Instance = new RootDisallowed();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<RootDisallowed>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("root_disallowed");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            RootDisallowed enc.IEncodable<RootDisallowed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path is invalid; the message gives more info.</para>
        /// </summary>
        public sealed class MalformedPath : PathError, enc.IEncodable<MalformedPath>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MalformedPath" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MalformedPath(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<MalformedPath>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("malformed_path", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            MalformedPath enc.IEncodable<MalformedPath>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path does not exist.</para>
        /// </summary>
        public sealed class NotFound : PathError, enc.IEncodable<NotFound>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<NotFound>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("not_found");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NotFound enc.IEncodable<NotFound>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path should refer to a folder.</para>
        /// </summary>
        public sealed class FileDisallowed : PathError, enc.IEncodable<FileDisallowed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FileDisallowed" />
            /// class.</para>
            /// </summary>
            private FileDisallowed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FileDisallowed</para>
            /// </summary>
            public static readonly FileDisallowed Instance = new FileDisallowed();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<FileDisallowed>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("file_disallowed");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            FileDisallowed enc.IEncodable<FileDisallowed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path should refer to a file.</para>
        /// </summary>
        public sealed class FolderDisallowed : PathError, enc.IEncodable<FolderDisallowed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FolderDisallowed" />
            /// class.</para>
            /// </summary>
            private FolderDisallowed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FolderDisallowed</para>
            /// </summary>
            public static readonly FolderDisallowed Instance = new FolderDisallowed();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<FolderDisallowed>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("folder_disallowed");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            FolderDisallowed enc.IEncodable<FolderDisallowed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>A file already exists there.</para>
        /// </summary>
        public sealed class ConflictFile : PathError, enc.IEncodable<ConflictFile>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ConflictFile" />
            /// class.</para>
            /// </summary>
            private ConflictFile()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ConflictFile</para>
            /// </summary>
            public static readonly ConflictFile Instance = new ConflictFile();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<ConflictFile>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("conflict_file");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            ConflictFile enc.IEncodable<ConflictFile>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>A folder already exists there.</para>
        /// </summary>
        public sealed class ConflictFolder : PathError, enc.IEncodable<ConflictFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ConflictFolder" />
            /// class.</para>
            /// </summary>
            private ConflictFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ConflictFolder</para>
            /// </summary>
            public static readonly ConflictFolder Instance = new ConflictFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<ConflictFolder>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("conflict_folder");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            ConflictFolder enc.IEncodable<ConflictFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>An ancestor is a file.</para>
        /// </summary>
        public sealed class ConflictFileAncestor : PathError, enc.IEncodable<ConflictFileAncestor>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ConflictFileAncestor" />
            /// class.</para>
            /// </summary>
            private ConflictFileAncestor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ConflictFileAncestor</para>
            /// </summary>
            public static readonly ConflictFileAncestor Instance = new ConflictFileAncestor();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<ConflictFileAncestor>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("conflict_file_ancestor");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            ConflictFileAncestor enc.IEncodable<ConflictFileAncestor>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>No write permission.</para>
        /// </summary>
        public sealed class ReadOnly : PathError, enc.IEncodable<ReadOnly>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ReadOnly" /> class.</para>
            /// </summary>
            private ReadOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ReadOnly</para>
            /// </summary>
            public static readonly ReadOnly Instance = new ReadOnly();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<ReadOnly>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("read_only");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            ReadOnly enc.IEncodable<ReadOnly>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The path should not refer to a shared folder.</para>
        /// </summary>
        public sealed class SharedFolderDisallowed : PathError, enc.IEncodable<SharedFolderDisallowed>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="SharedFolderDisallowed" />
            /// class.</para>
            /// </summary>
            private SharedFolderDisallowed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of SharedFolderDisallowed</para>
            /// </summary>
            public static readonly SharedFolderDisallowed Instance = new SharedFolderDisallowed();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<SharedFolderDisallowed>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("shared_folder_disallowed");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            SharedFolderDisallowed enc.IEncodable<SharedFolderDisallowed>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Automatic rename would result in a malformed path (e.g. too long).</para>
        /// </summary>
        public sealed class AutorenameFiled : PathError, enc.IEncodable<AutorenameFiled>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AutorenameFiled" />
            /// class.</para>
            /// </summary>
            private AutorenameFiled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AutorenameFiled</para>
            /// </summary>
            public static readonly AutorenameFiled Instance = new AutorenameFiled();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<AutorenameFiled>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("autorename_filed");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            AutorenameFiled enc.IEncodable<AutorenameFiled>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>Miscellaneous error (see error message).</para>
        /// </summary>
        public sealed class Misc : PathError, enc.IEncodable<Misc>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Misc" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Misc(string value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Misc>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField("misc", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Misc enc.IEncodable<Misc>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>An unspecified error.</para>
        /// </summary>
        public sealed class Other : PathError, enc.IEncodable<Other>
        {
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

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("other");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}