// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: Enums.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace BasicPackage
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SearchRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"corpus")]
        [global::System.ComponentModel.DefaultValue(global::BasicPackage.Corpus2.CorpusUnspecified)]
        public global::BasicPackage.Corpus2 Corpus { get; set; }

        internal static void Serialize(SearchRequest value, ref global::ProtoBuf.Nano.Writer writer)
        {
            if (value.Corpus != global::BasicPackage.Corpus2.CorpusUnspecified)
            {
                writer.WriteVarint(16); // field 2, varint
                writer.WriteVarint(unchecked((uint)(int)value.Corpus));
            }
        }

        internal static ulong Measure(SearchRequest value)
        {
            ulong len = 0;
            if (value.Corpus != global::BasicPackage.Corpus2.CorpusUnspecified)
            {
                len += global::ProtoBuf.Nano.Writer.MeasureVarint(unchecked((uint)(int)value.Corpus)) + 1;
            }
            return len;
        }

        internal static SearchRequest Merge(SearchRequest value, ref global::ProtoBuf.Nano.Reader reader)
        {
            if (value is null) value = new();
            uint tag;
            while ((tag = reader.ReadTag()) != 0)
            {
                switch (tag)
                {
                    case 16: // field 2, varint
                        value.Corpus = (global::BasicPackage.Corpus2)reader.ReadVarintInt32();
                        break;
                    case 21: // field 2, fixed32
                        value.Corpus = (global::BasicPackage.Corpus2)reader.ReadFixed32Int32();
                        break;
                    case 17: // field 2, fixed64
                        value.Corpus = (global::BasicPackage.Corpus2)reader.ReadFixed64Int32();
                        break;
                    default:
                        if ((tag & 7) == 4) // end-group
                        {
                            reader.PushGroup(tag);
                            goto ExitLoop;
                        }
                        switch (tag >> 3)
                        {
                            case 2:
                                reader.ThrowUnhandledWireType(tag);
                                break;
                        }
                        reader.Skip(tag);
                        break;
                }
            }
        ExitLoop:
            return value;
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum Corpus2
    {
        [global::ProtoBuf.ProtoEnum(Name = @"CORPUS_UNSPECIFIED")]
        CorpusUnspecified = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"CORPUS_UNIVERSAL")]
        CorpusUniversal = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"CORPUS_WEB")]
        CorpusWeb = 2,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
