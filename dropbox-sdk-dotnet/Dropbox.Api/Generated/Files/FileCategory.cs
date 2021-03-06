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
    /// <para>The file category object</para>
    /// </summary>
    public class FileCategory
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileCategory> Encoder = new FileCategoryEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileCategory> Decoder = new FileCategoryDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileCategory" /> class.</para>
        /// </summary>
        public FileCategory()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Image</para>
        /// </summary>
        public bool IsImage
        {
            get
            {
                return this is Image;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Image, or <c>null</c>.</para>
        /// </summary>
        public Image AsImage
        {
            get
            {
                return this as Image;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Document</para>
        /// </summary>
        public bool IsDocument
        {
            get
            {
                return this is Document;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Document, or <c>null</c>.</para>
        /// </summary>
        public Document AsDocument
        {
            get
            {
                return this as Document;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Pdf</para>
        /// </summary>
        public bool IsPdf
        {
            get
            {
                return this is Pdf;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Pdf, or <c>null</c>.</para>
        /// </summary>
        public Pdf AsPdf
        {
            get
            {
                return this as Pdf;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Spreadsheet</para>
        /// </summary>
        public bool IsSpreadsheet
        {
            get
            {
                return this is Spreadsheet;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Spreadsheet, or <c>null</c>.</para>
        /// </summary>
        public Spreadsheet AsSpreadsheet
        {
            get
            {
                return this as Spreadsheet;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Presentation</para>
        /// </summary>
        public bool IsPresentation
        {
            get
            {
                return this is Presentation;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Presentation, or <c>null</c>.</para>
        /// </summary>
        public Presentation AsPresentation
        {
            get
            {
                return this as Presentation;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Audio</para>
        /// </summary>
        public bool IsAudio
        {
            get
            {
                return this is Audio;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Audio, or <c>null</c>.</para>
        /// </summary>
        public Audio AsAudio
        {
            get
            {
                return this as Audio;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Video</para>
        /// </summary>
        public bool IsVideo
        {
            get
            {
                return this is Video;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Video, or <c>null</c>.</para>
        /// </summary>
        public Video AsVideo
        {
            get
            {
                return this as Video;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Folder</para>
        /// </summary>
        public bool IsFolder
        {
            get
            {
                return this is Folder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Folder, or <c>null</c>.</para>
        /// </summary>
        public Folder AsFolder
        {
            get
            {
                return this as Folder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Paper</para>
        /// </summary>
        public bool IsPaper
        {
            get
            {
                return this is Paper;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Paper, or <c>null</c>.</para>
        /// </summary>
        public Paper AsPaper
        {
            get
            {
                return this as Paper;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Others</para>
        /// </summary>
        public bool IsOthers
        {
            get
            {
                return this is Others;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Others, or <c>null</c>.</para>
        /// </summary>
        public Others AsOthers
        {
            get
            {
                return this as Others;
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
        /// <para>Encoder for  <see cref="FileCategory" />.</para>
        /// </summary>
        private class FileCategoryEncoder : enc.StructEncoder<FileCategory>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileCategory value, enc.IJsonWriter writer)
            {
                if (value is Image)
                {
                    WriteProperty(".tag", "image", writer, enc.StringEncoder.Instance);
                    Image.Encoder.EncodeFields((Image)value, writer);
                    return;
                }
                if (value is Document)
                {
                    WriteProperty(".tag", "document", writer, enc.StringEncoder.Instance);
                    Document.Encoder.EncodeFields((Document)value, writer);
                    return;
                }
                if (value is Pdf)
                {
                    WriteProperty(".tag", "pdf", writer, enc.StringEncoder.Instance);
                    Pdf.Encoder.EncodeFields((Pdf)value, writer);
                    return;
                }
                if (value is Spreadsheet)
                {
                    WriteProperty(".tag", "spreadsheet", writer, enc.StringEncoder.Instance);
                    Spreadsheet.Encoder.EncodeFields((Spreadsheet)value, writer);
                    return;
                }
                if (value is Presentation)
                {
                    WriteProperty(".tag", "presentation", writer, enc.StringEncoder.Instance);
                    Presentation.Encoder.EncodeFields((Presentation)value, writer);
                    return;
                }
                if (value is Audio)
                {
                    WriteProperty(".tag", "audio", writer, enc.StringEncoder.Instance);
                    Audio.Encoder.EncodeFields((Audio)value, writer);
                    return;
                }
                if (value is Video)
                {
                    WriteProperty(".tag", "video", writer, enc.StringEncoder.Instance);
                    Video.Encoder.EncodeFields((Video)value, writer);
                    return;
                }
                if (value is Folder)
                {
                    WriteProperty(".tag", "folder", writer, enc.StringEncoder.Instance);
                    Folder.Encoder.EncodeFields((Folder)value, writer);
                    return;
                }
                if (value is Paper)
                {
                    WriteProperty(".tag", "paper", writer, enc.StringEncoder.Instance);
                    Paper.Encoder.EncodeFields((Paper)value, writer);
                    return;
                }
                if (value is Others)
                {
                    WriteProperty(".tag", "others", writer, enc.StringEncoder.Instance);
                    Others.Encoder.EncodeFields((Others)value, writer);
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
        /// <para>Decoder for  <see cref="FileCategory" />.</para>
        /// </summary>
        private class FileCategoryDecoder : enc.UnionDecoder<FileCategory>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileCategory" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileCategory Create()
            {
                return new FileCategory();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FileCategory Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "image":
                        return Image.Decoder.DecodeFields(reader);
                    case "document":
                        return Document.Decoder.DecodeFields(reader);
                    case "pdf":
                        return Pdf.Decoder.DecodeFields(reader);
                    case "spreadsheet":
                        return Spreadsheet.Decoder.DecodeFields(reader);
                    case "presentation":
                        return Presentation.Decoder.DecodeFields(reader);
                    case "audio":
                        return Audio.Decoder.DecodeFields(reader);
                    case "video":
                        return Video.Decoder.DecodeFields(reader);
                    case "folder":
                        return Folder.Decoder.DecodeFields(reader);
                    case "paper":
                        return Paper.Decoder.DecodeFields(reader);
                    case "others":
                        return Others.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>jpg, png, gif, and more.</para>
        /// </summary>
        public sealed class Image : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Image> Encoder = new ImageEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Image> Decoder = new ImageDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Image" /> class.</para>
            /// </summary>
            private Image()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Image</para>
            /// </summary>
            public static readonly Image Instance = new Image();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Image" />.</para>
            /// </summary>
            private class ImageEncoder : enc.StructEncoder<Image>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Image value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Image" />.</para>
            /// </summary>
            private class ImageDecoder : enc.StructDecoder<Image>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Image" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Image Create()
                {
                    return Image.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>doc, docx, txt, and more.</para>
        /// </summary>
        public sealed class Document : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Document> Encoder = new DocumentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Document> Decoder = new DocumentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Document" /> class.</para>
            /// </summary>
            private Document()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Document</para>
            /// </summary>
            public static readonly Document Instance = new Document();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Document" />.</para>
            /// </summary>
            private class DocumentEncoder : enc.StructEncoder<Document>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Document value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Document" />.</para>
            /// </summary>
            private class DocumentDecoder : enc.StructDecoder<Document>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Document" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Document Create()
                {
                    return Document.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>pdf.</para>
        /// </summary>
        public sealed class Pdf : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Pdf> Encoder = new PdfEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Pdf> Decoder = new PdfDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Pdf" /> class.</para>
            /// </summary>
            private Pdf()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Pdf</para>
            /// </summary>
            public static readonly Pdf Instance = new Pdf();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Pdf" />.</para>
            /// </summary>
            private class PdfEncoder : enc.StructEncoder<Pdf>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Pdf value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Pdf" />.</para>
            /// </summary>
            private class PdfDecoder : enc.StructDecoder<Pdf>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Pdf" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Pdf Create()
                {
                    return Pdf.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>xlsx, xls, csv, and more.</para>
        /// </summary>
        public sealed class Spreadsheet : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Spreadsheet> Encoder = new SpreadsheetEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Spreadsheet> Decoder = new SpreadsheetDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Spreadsheet" />
            /// class.</para>
            /// </summary>
            private Spreadsheet()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Spreadsheet</para>
            /// </summary>
            public static readonly Spreadsheet Instance = new Spreadsheet();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Spreadsheet" />.</para>
            /// </summary>
            private class SpreadsheetEncoder : enc.StructEncoder<Spreadsheet>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Spreadsheet value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Spreadsheet" />.</para>
            /// </summary>
            private class SpreadsheetDecoder : enc.StructDecoder<Spreadsheet>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Spreadsheet" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Spreadsheet Create()
                {
                    return Spreadsheet.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>ppt, pptx, key, and more.</para>
        /// </summary>
        public sealed class Presentation : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Presentation> Encoder = new PresentationEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Presentation> Decoder = new PresentationDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Presentation" />
            /// class.</para>
            /// </summary>
            private Presentation()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Presentation</para>
            /// </summary>
            public static readonly Presentation Instance = new Presentation();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Presentation" />.</para>
            /// </summary>
            private class PresentationEncoder : enc.StructEncoder<Presentation>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Presentation value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Presentation" />.</para>
            /// </summary>
            private class PresentationDecoder : enc.StructDecoder<Presentation>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Presentation" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Presentation Create()
                {
                    return Presentation.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>mp3, wav, mid, and more.</para>
        /// </summary>
        public sealed class Audio : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Audio> Encoder = new AudioEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Audio> Decoder = new AudioDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Audio" /> class.</para>
            /// </summary>
            private Audio()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Audio</para>
            /// </summary>
            public static readonly Audio Instance = new Audio();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Audio" />.</para>
            /// </summary>
            private class AudioEncoder : enc.StructEncoder<Audio>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Audio value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Audio" />.</para>
            /// </summary>
            private class AudioDecoder : enc.StructDecoder<Audio>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Audio" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Audio Create()
                {
                    return Audio.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>mov, wmv, mp4, and more.</para>
        /// </summary>
        public sealed class Video : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Video> Encoder = new VideoEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Video> Decoder = new VideoDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Video" /> class.</para>
            /// </summary>
            private Video()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Video</para>
            /// </summary>
            public static readonly Video Instance = new Video();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Video" />.</para>
            /// </summary>
            private class VideoEncoder : enc.StructEncoder<Video>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Video value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Video" />.</para>
            /// </summary>
            private class VideoDecoder : enc.StructDecoder<Video>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Video" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Video Create()
                {
                    return Video.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>dropbox folder.</para>
        /// </summary>
        public sealed class Folder : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Folder> Encoder = new FolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Folder> Decoder = new FolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Folder" /> class.</para>
            /// </summary>
            private Folder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Folder</para>
            /// </summary>
            public static readonly Folder Instance = new Folder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Folder" />.</para>
            /// </summary>
            private class FolderEncoder : enc.StructEncoder<Folder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Folder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Folder" />.</para>
            /// </summary>
            private class FolderDecoder : enc.StructDecoder<Folder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Folder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Folder Create()
                {
                    return Folder.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>dropbox paper doc.</para>
        /// </summary>
        public sealed class Paper : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Paper> Encoder = new PaperEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Paper> Decoder = new PaperDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Paper" /> class.</para>
            /// </summary>
            private Paper()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Paper</para>
            /// </summary>
            public static readonly Paper Instance = new Paper();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Paper" />.</para>
            /// </summary>
            private class PaperEncoder : enc.StructEncoder<Paper>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Paper value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Paper" />.</para>
            /// </summary>
            private class PaperDecoder : enc.StructDecoder<Paper>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Paper" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Paper Create()
                {
                    return Paper.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>any file not in one of the categories above.</para>
        /// </summary>
        public sealed class Others : FileCategory
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Others> Encoder = new OthersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Others> Decoder = new OthersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Others" /> class.</para>
            /// </summary>
            private Others()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Others</para>
            /// </summary>
            public static readonly Others Instance = new Others();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Others" />.</para>
            /// </summary>
            private class OthersEncoder : enc.StructEncoder<Others>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Others value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Others" />.</para>
            /// </summary>
            private class OthersDecoder : enc.StructDecoder<Others>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Others" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Others Create()
                {
                    return Others.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FileCategory
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
