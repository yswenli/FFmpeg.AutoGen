namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions
{
    internal class StructureField : ICanGenerateXmlDoc
    {
        public string Name { get; set; }
        public FieldType FieldType { get; set; }
        public string Content { get; set; }
    }
}