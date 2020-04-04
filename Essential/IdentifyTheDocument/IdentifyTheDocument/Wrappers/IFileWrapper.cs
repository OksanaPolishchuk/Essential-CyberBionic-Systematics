namespace IdentifyTheDocument.Wrappers
{
    public interface IFileWrapper
    {
        void AppendAllText(string path, string contents);

        string ReadAllText(string path);

        void Move(string sourceFileName, string destFileName);
    }
}
